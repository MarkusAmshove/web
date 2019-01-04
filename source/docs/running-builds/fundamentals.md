---
_disableBreadcrumb: true
_disableAffix: true
jr.disableMetadata: false
jr.disableLeftMenu: false
jr.disableRightMenu: true
uid: running-builds-fundamentals
title: Fundamentals
---

# Fundamentals

Depending on the operating system, one of the two bootstrapping scripts for PowerShell or BASH can be used to execute a build:

```powershell
$ ./build.sh [targets] [arguments]
$ .\build.ps1 [targets] [arguments]
```

> [!Note]
> Executing a build triggers the creation of a directory `./tmp` for temporary files that should not be committed. It is recommended to create an VCS ignore entry.

### Arguments

Arguments can be passed either in **lisp-case or camel-case** style with either **single or double dash** as prefix. The preferred variant is lisp-case with two dashes, which is also used for the [global tool shell completion](../running-builds/global-tool.md):

```powershell
$ build --target pack --configuration release --api-key 12345
```

Certain parameters can accept **collections of values** that are separated with a _space_. The built-in parameters `--target` or `--skip` also allow the _plus sign_ for value separation:

```powershell
$ build --target test pack --skip clean+restore
```

> [!Note]
> The `--skip` parameter can also be passed as a pure switch, i.e. without any targets as arguments. In this case, only the invoked targets will be executed, which greatly enhances troubleshooting.

### Summary

At the end of every build execution, a summary with statuses and elapsed time per each target is displayed. Also error and warning descriptions are repeatedly printed:

```powershell
No errors or warnings.

=======================================
Target             Status      Duration
---------------------------------------
Clean              Executed        0:00
Restore            Executed        0:05
Compile            Executed        0:26
---------------------------------------
Total                              0:32
=======================================

Build succeeded on 01/01/2018 14:00:00.
```

### Help

A list of available targets, [predefined parameters](../authoring-builds/predefined-parameters.md) as well as [custom declared parameters](../authoring-builds/parameter-declaration.md) can always be shown by passing the `--help` switch. Targets are shown along their direct dependencies, while custom parameters are separated from predefined ones:

![Help](~/images/help.png)

A visual representation for all target dependencies can be shown by passing the `--plan` switch. Hovering a target reveals its individual execution plan:

![Plan](~/images/plan.gif)

The default target is highlighted in light-blue. Solid grey edges mark [execution dependencies](../authoring-builds/fundamentals.md#execution-dependencies), dashed grey edges signal [ordering dependencies](../authoring-builds/fundamentals.md#ordering-dependencies) and solid yellow lines indicate [triggers](../authoring-builds/fundamentals.md#trigger-dependencies).
