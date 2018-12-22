---
_disableBreadcrumb: true
_disableAffix: true
jr.disableMetadata: false
jr.disableLeftMenu: false
jr.disableRightMenu: true
uid: authoring-builds-cli-tools
title: CLI Tools
---

# CLI Tools

Interacting with third-party command-line interface tools (CLIs) is an essential task in build automation. This includes resolution of the tool path, construction of arguments to be passed, evaluation of the exit code and capturing of standard and error output. NUKE can hide those trivialities in dedicated auto-generated CLI task classes. For instance, calling MSBuild can be done as follows:

```c#
// using static Nuke.Common.Tools.MSBuild.MSBuildTasks;

MSBuild($"{SolutionFile} /target:Rebuild /p:Configuration={Configuration} /nr:false");
```

While this example is quite easy to understand, it also illustrates certain weaknesses. What if `SolutionFile` contains a space? How can multiple targets be passed? Should the configuration really be injected as property or as dedicated argument? What does the `/nr` switch stand for? NUKE answers these questions with a fluent syntax.

### Fluent APIs

Another way of invoking CLI tools it to use an individual fluent API. The example from above can be rewritten as:

```c#
// using Nuke.Common.Tools.MSBuild;
// using static Nuke.Common.Tools.MSBuild.MSBuildTasks;

MSBuild(s => s
    .SetTargetPath(SolutionFile)
    .SetTargets("Clean", "Build")
    .SetConfiguration(Configuration)
    .EnableNodeReuse());
```

These fluent APIs are used to manipulate the actual process invocation, including tool path, arguments, working directory, timeout and environment variables.

> [!Note]
> All fluent APIs implement a variation of the [builder pattern](https://en.wikipedia.org/wiki/Builder_pattern), in which every fluent call will create an immutable copy of the current `ToolSettings` instance with the intended changes applied. This enables to compose similar process invocations very easily by reusing an intermediate state of the settings object.

Every fluent API can easily be discovered with popular IDEs using code completion. Most importantly, this contains the original tool documentation:

![CLI Tools](~/images/cli-tools.gif)

> [!Note]
> Occasionally, it may happen that an argument is not available from the fluent API. In this case, the `SetArgumentConfigurator` method can be used to add them manually.

<!--
    SetToolPath
    SetWorkingDirectory
    SetExecutionTimeout
    SetEnvironmentVariables
    LogOutput
    When
    SetArgumentConfigurator
-->

### Unsupported Tools

Many of the most popular tools for .NET development are already implemented either in `Nuke.Common` or dedicated `Nuke.[Tool]` packages. In case that a certain tool is not yet supported with a proper CLI task class, NUKE allows to use **delegate injection** with one of the two attributes `PathExecutable` or `PackageExecutable`:

```c#
[PathExecutable] readonly Tool Git;

[PackageExecutable(
    packageId: "xunit.runner.console",
    packageExecutable: "xunit.console.exe")]
readonly Tool Xunit;
```

The injected delegate has the [same signature]() as generated in CLI task classes:

```c#
Git($"checkout -b {Branch}", workingDirectory: checkoutDirectory);
```

Whenever it is desirable to have the same fluent syntax available for a custom tool, there is a dedicated article about [code generation]() with further information.
