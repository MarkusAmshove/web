---
_disableBreadcrumb: true
_disableAffix: true
jr.disableMetadata: false
jr.disableLeftMenu: false
jr.disableRightMenu: true
uid: running-builds-global-tool
title: Global Tool
---

# Global Tool

Besides invoking one of the bootstrapping scripts `build.sh` or `build.ps1`, builds can also be executed via the `nuke` command provided as a global tool:

```powershell
$ nuke [targets] [arguments]
```

Using the global tool has two benefits:

Firstly, builds are **invokable from any directory beneath the root directory**. More specifically, the global tool will search for the `.nuke` marker file upwards the current directory and then search for `build.ps1` or `build.sh` from there. This allows to work and inspect any subdirectory of the current repository without switching to the root directory or constructing obscure relative path calls.

Secondly, the global tool provides **completion for targets, parameters and enumerations**:

![Shell-Completion](~/images/shell-completion.gif)

In order for completion to work, one of the [shell snippets](#shell-snippets) must be installed. These shell snippets are used to pass the current input to the global tool, which in turn evaluates the `.tmp/shell-completion.yml` file containing information about possible completion tokens. Note, that this file is updated with every execution of the build, meaning that for modified parameters or clean repositories, the build must be executed once for completion to be consistent. Alternatively, the `shell-completion.yml` file can also be moved to the root directory and committed to VCS as other persistent files.

### Shell snippets

For **PowerShell**, add the following to `$PROFILE`:
```powershell
Register-ArgumentCompleter -Native -CommandName nuke -ScriptBlock {
    param($commandName, $wordToComplete, $cursorPosition)
        nuke :complete "$wordToComplete" | ForEach-Object {
           [System.Management.Automation.CompletionResult]::new($_, $_, 'ParameterValue', $_)
        }
}
```

For **ZSH**, add the following to `.zshrc`:
```bash
_nuke_zsh_complete()
{
  local completions=("$(nuke :complete "$words")")
  reply=( "${(ps:\n:)completions}" )
}
compctl -K _nuke_zsh_complete nuke
```

For **BASH**, add the following to `.bashrc`:
```bash
_nuke_bash_complete()
{
  local word=${COMP_WORDS[COMP_CWORD]}
  local completions="$(nuke :complete "${COMP_LINE}")"
  COMPREPLY=( $(compgen -W "$completions" -- "$word") )
}
complete -f -F _nuke_bash_complete nuke
```

For **fish**, add the following to `config.fish`:
```bash
complete -fc nuke --arguments '(nuke :complete (commandline -cp))'
```
