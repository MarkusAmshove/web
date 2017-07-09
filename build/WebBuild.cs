﻿// Copyright Matthias Koch 2017.
// Distributed under the MIT License.
// https://github.com/nuke-build/web/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Nuke.Common;
using Nuke.Common.Git;
using Nuke.Common.Tools;
using Nuke.Common.Tools.DocFx;
using Nuke.Common.Tools.MSBuild;
using Nuke.Core;
using Nuke.Core.Tooling;
using Nuke.Core.Utilities.Collections;
using static CustomToc;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.FtpTasks;
using static Nuke.Common.IO.YamlTasks;
using static Nuke.Common.Tools.DocFx.DocFxTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.MSBuild.MSBuildTasks;
using static Nuke.Common.Tools.NuGet.NuGetTasks;
using static Nuke.Core.ControlFlow;
using static Nuke.Core.EnvironmentInfo;
using static Nuke.Core.Logger;
using static Nuke.Git.GitTasks;

class WebBuild : Build
{
    public static int Main () => Execute<WebBuild>(x => x.BuildSite);

    string DocFxFile => Path.Combine(RootDirectory, "docfx.json");
    string RepositoriesDirectory => Path.Combine(RootDirectory, "repos");
    string ApiDirectory => Path.Combine(SourceDirectory, "api");
    string SiteDirectory => Path.Combine(OutputDirectory, "site");

    Target Clean => _ => _
            .Executes(
                () => DeleteDirectory(RepositoriesDirectory),
                () => DeleteDirectory(ApiDirectory),
                () => PrepareCleanDirectory(OutputDirectory));

    Target Clone => _ => _
            .DependsOn(Clean)
            .Executes(() => YamlDeserializeFromFile<List<string>>(Path.Combine(RootDirectory, "repos.yml"))
                    .Select(GitRepository.TryParse)
                    .ForEachLazy(x => Info($"Cloning repository '{x.SvnUrl}'..."))
                    .ForEach(x => GitClone(x.CloneUrl, Path.Combine(RepositoriesDirectory, x.Identifier))));

    Target Restore => _ => _
            .DependsOn(Clone)
            .Executes(() => GlobFiles(RepositoriesDirectory, "**/*.sln")
                    .ForEach(x =>
                    {
                        SuppressErrors(() => DotNetRestore(Path.GetDirectoryName(x)));
                        SuppressErrors(() => MSBuild(s => DefaultSettings.MSBuildRestore.SetSolutionFile(x)));
                        SuppressErrors(() => NuGetRestore(x));
                    }));

    Target CustomToc => _ => _
            .DependsOn(Restore)
            .Executes(() => WriteCustomToc(Path.Combine(ApiDirectory, "toc.yml"), GlobFiles(RepositoriesDirectory, "**/*.sln")));

    Target Metadata => _ => _
            .DependsOn(Restore)
            .Executes(() => DocFxMetadata(DocFxFile, s => s.SetLogLevel(DocFxLogLevel.Verbose)));

    IEnumerable<string> XRefMapFiles
        => GlobFiles(NuGetPackageResolver.GetLocalInstalledPackageDirectory("msdn.4.5.2"), "content/*.zip")
                .Concat(GlobFiles(RepositoriesDirectory, "specs/xrefmap.yml"));

    Target BuildSite => _ => _
            .DependsOn(Metadata, CustomToc)
            .Executes(() => DocFxBuild(DocFxFile, s => s
                    .SetLogLevel(DocFxLogLevel.Verbose)
                    // TODO: use AddXRefMapFiles
                    .SetArgumentConfigurator(x => x.Add("--xref {value} --serve", XRefMapFiles, mainSeparator: ","))));

    Target Publish => _ => _
            .DependsOn(BuildSite)
            .Executes(
                () => FtpCredentials = new NetworkCredential(EnsureVariable("FTP_USERNAME"), EnsureVariable("FTP_PASSWORD")),
                () => FtpUploadDirectoryRecursively(SiteDirectory, "ftp://www58.world4you.com"));
}
