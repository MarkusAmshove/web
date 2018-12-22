---
_disableBreadcrumb: true
_disableAffix: true
jr.disableMetadata: false
jr.disableLeftMenu: false
jr.disableRightMenu: true
uid: authoring-builds-fundamentals
title: Fundamentals
---

# Fundamentals

Builds are **implemented as console applications**. For a first impression, here is a "Hello World!" example:

```c#
class Build : NukeBuild
{
    public static int Main() => Execute<Build>(x => x.Foo);
    
    Target Foo => _ => _
        .Executes(() =>
        {
            Logger.Log("Hello World!");
        });
}
```

The `Build` class inherits from `NukeBuild` and must provide a `static int Main` method that delegates to the execution engine via `Execute<T>`, which passes the build type `Build` and the default target `Foo`. Targets are represented as **expression-bodied properties** that return a `Target` delegate. This delegate is used as a starting point for a fluent API. One of the most essential methods of this fluent API, is the `Executes` method, as it assigns a target with its actual action to be executed.

### DependsOn/DependentFor

Similar to other build systems, NUKE implements a **dependency-based execution model**. This is expressed with the `DependsOn` (inverse `DependentFor`) method, which accepts a `params Target[]` that allows to pass several targets as dependencies. Note, that **dependencies are solely specified at individual targets**. In the next example, the two targets `Pack` and `Test` could theoretically run in parallel when invoking the `Full` target:

```c#
Target Compile => _ => _
    .Executes(() => { });
    
Target Pack => _ => _
    .DependsOn(Compile)
    .Executes(() => { });
    
Target Test => _ => _
    .DependsOn(Compile)
    .Executes(() => { });
    
Target Full => _ => _
    .DependsOn(Pack, Test);
```

### Before/After

Sometimes, targets are not dependent on each other, but require each other to be executed in a certain order. This can be achieved by defining **order dependencies** with `Before` or `After`:

```c#
Target Clean => _ => _
    .Executes(() => { });
    
Target Compile => _ => _
    .DependsOn(Clean)
    .Executes(() => { });
    
Target Analyse => _ => _
    .After(Clean)
    .Executes(() => { });
```

### Triggers/TriggeredBy

Occasionally, certain targets are intended to trigger other targets as soon as they are done. NUKE allows to define such **trigger dependencies** by calling the `Triggers` (inverse `TriggeredBy`) method:

```c#
Target Publish => _ => _
    .Triggers(Update)
    .Executes(() => { });
    
Target Update => _ => _
    .Executes(() => { });
```

### Requires

Assuming a target has a certain requirement and is part of a complex dependency chain. This requirement could be an environment variable `ApiKey` being set. If this requirement would be checked in the moment the target is executed, it would imply a lot of execution time wasted. Following the [**fail-fast philosophy**](https://en.wikipedia.org/wiki/Fail-fast), NUKE provides a way to check such requirements prior to build execution with the `Requires` method:

```c#
Target Compile => _ => _
    .DependsOn(Clean)
    .Executes(() => { });
    
Target Pack => _ => _
    .Requires(() => ApiKey != null)
    // or shorthand null-check
    .Requires(() => ApiKey)
    .DependsOn(Compile)
    .Executes(() => { });
```

### OnlyWhen

The fluent API is also capable of defining **runtime conditions** that are checked if a target should be executed or not. Such conditions are defined via `OnlyWhen`. If a condition is not met, the target is marked as _skipped_:

```c#
Target Changelog => _ => _
    .OnlyWhen(() => Branch == "master")
    .Executes(() => { });
```

<!--

- Fluent syntax
    - Before/After
    - DependsOn
    - Requires 2x
    - OnlyWhen
    - WhenSkipped
    - Executes
- Escape DSL into normal classes

-->
