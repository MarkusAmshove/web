---
_disableBreadcrumb: true
_disableAffix: true
jr.disableMetadata: false
jr.disableLeftMenu: false
jr.disableRightMenu: true
uid: authoring-builds-snippets
title: Snippets
---

# Snippets

Target declarations are great in the way that they use actual symbols and their fluent API is easily extensible. However, starting to write a new target including the expression body and lambda part `=> _ => _` is not very convenient to type. In order to solve this, all [IDE extensions](../running-builds/from-ides.md) ship with an `ntarget` code snippet, that takes care of generating the boilerplate code:

![Snippet](~/images/snippet.gif)
