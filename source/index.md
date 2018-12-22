---
_disableBreadcrumb: true
_disableContribution: true
_disableAffix: true
_disableContainer: true
jr.disableMetadata: true
jr.disableLeftMenu: true
jr.disableRightMenu: true
uid: index
title: Home
---

<!-- MAIN JUMBOTRON -->
<div id="header" class="jumbotron feature">
  <div class="container">
    <div class="row">
        <h1>/njuːk/</h1>
<!--
<style type="text/css">

<![CDATA[

  text {
    filter: url(#filter);
    fill: white;
      font-family: 'Share Tech Mono', sans-serif;
      font-size: 100px;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
        }
]]>
</style>
  <defs>

    <filter id="filter">
        <feFlood flood-color="red" result="flood1" />
        <feFlood flood-color="limegreen" result="flood2" />
      <feOffset in="SourceGraphic" dx="3" dy="0" result="off1a"/>
      <feOffset in="SourceGraphic" dx="2" dy="0" result="off1b"/>
      <feOffset in="SourceGraphic" dx="-3" dy="0" result="off2a"/>
      <feOffset in="SourceGraphic" dx="-2" dy="0" result="off2b"/>
        <feComposite in="flood1" in2="off1a" operator="in"  result="comp1" />
        <feComposite in="flood2" in2="off2a" operator="in" result="comp2" />

        <feMerge x="0" width="100%" result="merge1">
        <feMergeNode in = "black" />
        <feMergeNode in = "comp1" />
        <feMergeNode in = "off1b" />

        <animate 
          attributeName="y" 
            id = "y"
            dur ="4s"
            
            values = '104px; 104px; 30px; 105px; 30px; 2px; 2px; 50px; 40px; 105px; 105px; 20px; 6ßpx; 40px; 104px; 40px; 70px; 10px; 30px; 104px; 102px'

            keyTimes = '0; 0.362; 0.368; 0.421; 0.440; 0.477; 0.518; 0.564; 0.593; 0.613; 0.644; 0.693; 0.721; 0.736; 0.772; 0.818; 0.844; 0.894; 0.925; 0.939; 1'

            repeatCount = "indefinite" />
 
        <animate attributeName="height" 
            id = "h" 
            dur ="4s"
            
            values = '10px; 0px; 10px; 30px; 50px; 0px; 10px; 0px; 0px; 0px; 10px; 50px; 40px; 0px; 0px; 0px; 40px; 30px; 10px; 0px; 50px'

            keyTimes = '0; 0.362; 0.368; 0.421; 0.440; 0.477; 0.518; 0.564; 0.593; 0.613; 0.644; 0.693; 0.721; 0.736; 0.772; 0.818; 0.844; 0.894; 0.925; 0.939; 1'

            repeatCount = "indefinite" />
        </feMerge>
      

      <feMerge x="0" width="100%" y="60px" height="65px" result="merge2">
        <feMergeNode in = "black" />
        <feMergeNode in = "comp2" />
        <feMergeNode in = "off2b" />

        <animate attributeName="y" 
            id = "y"
            dur ="4s"
            values = '103px; 104px; 69px; 53px; 42px; 104px; 78px; 89px; 96px; 100px; 67px; 50px; 96px; 66px; 88px; 42px; 13px; 100px; 100px; 104px;' 

            keyTimes = '0; 0.055; 0.100; 0.125; 0.159; 0.182; 0.202; 0.236; 0.268; 0.326; 0.357; 0.400; 0.408; 0.461; 0.493; 0.513; 0.548; 0.577; 0.613; 1'

            repeatCount = "indefinite" />
 
        <animate attributeName="height" 
            id = "h"
            dur = "4s"
          
          values = '0px; 0px; 0px; 16px; 16px; 12px; 12px; 0px; 0px; 5px; 10px; 22px; 33px; 11px; 0px; 0px; 10px'

            keyTimes = '0; 0.055; 0.100; 0.125; 0.159; 0.182; 0.202; 0.236; 0.268; 0.326; 0.357; 0.400; 0.408; 0.461; 0.493; 0.513;  1'
             
            repeatCount = "indefinite" />
        </feMerge>
      
      <feMerge>
        <feMergeNode in="SourceGraphic" />  

        <feMergeNode in="merge1" /> 
      <feMergeNode in="merge2" />

        </feMerge>
      </filter>

  </defs>

<g>
  <text x="0" y="80">/njuːk/</text>
</g>
</svg>
-->
        <ol class="definition">
          <li>A cross-platform <a href="https://martinfowler.com/articles/continuousIntegration.html#AutomateTheBuild">build automation</a> system with C# <a href="https://martinfowler.com/bliki/DomainSpecificLanguage.html">DSL</a>.</li>
          <li>An approach to embrace existing IDE tooling.</li>
          <li>A state where everyone in a team is able to manage and change the build.</li>
        </ol>
        <p>
        <a class="btn btn-default btn-md" href="/docs/getting-started/philosophy.html" role="button">Read documentation</a>
        <a class="btn btn-default btn-md" href="https://dotnetrocks.com/?show=1598" role="button">Listen to podcast</a>
        <a class="btn btn-default btn-md" href="https://www.youtube.com/watch?v=7gEqxzD6hbs" role="button">Watch presentation</a>
      </div>
  </div>
</div>


<!-- FULL IDE SUPPORT -->
<div class="container feature">
  <div class="row">
    <div class="col-md-5">
      <h2><span class="icon icon-keyboard"></span> Native IDE support</h2>
      <p>Build projects are simple C# console applications - no pre-processing or scripting involved, and <a id="solution-view">part of your solution</a>! That means all the powerful IDE features that we love - like <a id="code-completion">code-completion</a>, refactorings and formatting - will work without any extensions. Targets are defined as <em>expression-bodied properties</em>, so you might want to say good-bye to magic strings! But most importantly, <a id="debugging">debugging</a> is available just as you know it. There is no more need to debug code by writing output to the console!</p>
    </div>
    <div class="col-md-7">
      <div id="ide-support-carousel" class="carousel slide" data-ride="carousel1">
        <ol class="carousel-indicators">
          <li data-target="#ide-support-carousel" data-slide-to="0" class="active"></li>
          <li data-target="#ide-support-carousel" data-slide-to="1"></li>
          <li data-target="#ide-support-carousel" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner" role="listbox">
          <div class="item"><img src="images/rider-solution-view.png" data-color="lightblue" alt="Solution View"></div>
          <div class="item"><img src="images/vscode-code-completion.png" data-color="firebrick" alt="Code Completion"></div>
          <div class="item"><img src="images/vscode-debugging.png" data-color="firebrick" alt="Debugging"></div>
        </div>
        <a class="left carousel-control" href="#ide-support-carousel" role="button" data-slide="prev">
          <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
          <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#ide-support-carousel" role="button" data-slide="next">
          <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
          <span class="sr-only">Next</span>
        </a>
      </div>
    </div>
  </div>
</div>



<!-- BOOTSTRAPPING JUMBOTRON -->
<div class="jumbotron small-jumbotron feature">
  <div class="container">
    <div class="row">
      <h2>Supports .NET Core, .NET Framework and Mono!</h2>
      <span class="icon icon-windows8"></span>
      <span class="icon icon-tux"></span>
      <span class="icon icon-appleinc"></span>
    </div>
  </div>
</div>



<!-- EXTENDED TOOLING -->
<div class="container feature">
  <div class="row">
    <div class="col-md-5 col-md-push-7">
      <h2><span class="icon icon-fire"></span> Extended Tooling</h2>
      <p>The .NET ecosystem is just a wonderful place. Although build projects integrate natively into existing tooling, we are not stopping there! A <a id="global-tool">global tool</a> can be installed, that assists with the setup and invocation of builds by a single <code>nuke</code> command. Also extensions for VSCode, Rider and ReSharper are available that enhance the <a id="command-palette">command palette</a> and the <a id="alt-enter">Alt-Enter menu</a> to execute build targets in the most convenient way!</p>
    </div>
    <div class="col-md-7 col-lg-pull-5">
      <div id="global-extension-carousel" class="carousel slide" data-ride="carousel5">
        <ol class="carousel-indicators">
          <li data-target="#global-extension-carousel" data-slide-to="0" class="active"></li>
          <li data-target="#global-extension-carousel" data-slide-to="1"></li>
          <li data-target="#global-extension-carousel" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner" role="listbox">
          <div class="item"><img src="images/global-tool.png" data-color="lightblue" alt="Global tool"></div>
          <div class="item"><img src="images/vscode-command-palette.png" data-color="firebrick" alt="Command palette integration in VSCode"></div>
          <div class="item"><img src="images/rider-alter-enter.png" data-color="firebrick" alt="Alt-Enter integration in JetBrains Rider"></div>
        </div>
        <a class="left carousel-control" href="#global-extension-carousel" role="button" data-slide="prev">
          <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
          <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#global-extension-carousel" role="button" data-slide="next">
          <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
          <span class="sr-only">Next</span>
        </a>
      </div>
    </div>
  </div>
</div>




<!-- WHAT ELSE JUMBOTRON -->
<div class="jumbotron small-jumbotron feature">
  <div class="container">
    <div class="row">
      <h2>Wonder which tools we support?</h2>
      <h2>...</h2>
      <h2>That's the best part!</h2>
    </div>
  </div>
</div>


<!-- CODE-GENERATION -->
<div class="container feature">
  <div class="row">
    <div class="col-md-5">
      <h2><span class="icon icon-magic-wand"></span> Code-Generation</h2>
      <p>Execution APIs for third-party command-line tools are based on data from <a id="references">official references</a>. We're extracing information like argument types, formatting and others into so-called <a id="metadata">specification files</a>. These files are then processed by a code-generator that generates a rich and consistent fluent API. Official help texts are shown in IntelliSense! And no more need to worry about escaping or separators! Check out our addons for <a href="https://github.com/nuke-build/azure/tree/master/src/Nuke.Azure/Generated">Azure CLI</a> and <a href="https://github.com/nuke-build/docker/blob/master/src/Nuke.Docker/Generated/Docker.Generated.cs">Docker</a>, which are even automatically updated whenever a new version of the related tool is published.</p>
    </div>
    <div class="col-md-7">
      <div id="code-generation-carousel" class="carousel slide" data-ride="carousel4">
        <ol class="carousel-indicators">
          <li data-target="#code-generation-carousel" data-slide-to="0" class="active"></li>
          <li data-target="#code-generation-carousel" data-slide-to="1"></li>
          <li data-target="#code-generation-carousel" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner" role="listbox">
          <div class="item"><img src="images/references.png" data-color="lightblue" alt="CLI Reference"></div>
          <div class="item"><img src="images/metadata.png" data-color="firebrick" alt="Converted Metadata"></div>
          <div class="item"><img src="images/schema.png" data-color="firebrick" alt="JSON Schema"></div>
        </div>
        <a class="left carousel-control" href="#code-generation-carousel" role="button" data-slide="prev">
          <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
          <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#code-generation-carousel" role="button" data-slide="next">
          <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
          <span class="sr-only">Next</span>
        </a>
      </div>
    </div>
  </div>
</div>



<!-- WHAT ELSE JUMBOTRON -->
<div class="jumbotron small-jumbotron feature">
  <div class="container">
    <div class="row">
      <h2>What else?</h2>
      <h2>...</h2>
      <h2>A lot more!</h2>
    </div>
  </div>
</div>



<!-- FEATURE LIST -->
<div id="feature-list" class="container feature">
  <div class="row">
    <div class="col-md-6 list-left">
      <h2><span class="icon icon-syringe2"></span> Value Injections</h2>
      <p>Fields can be marked with different attributes to get their value injected prior to execution. For instance, <code>[Parameter]</code> retrieves the value from command-line arguments and environment variables with the same name as the field.</p>
      <img src="images/parameter-injection.png" alt="Parameter Injection">
    </div>
    <div class="col-md-6 list-right">
      <h2><span class="icon icon-price-tag2"></span> Path Construction</h2>
      <p>Absolute and relative paths can be constructed using the <code>/</code> division operator, which will automatically adjust the directory separator to the underlying OS. If required, paths can also be casted to match other platforms.</p>
      <div class="feature-list-img"><img src="images/path-construction.png" alt="Path Construction"></div>
    </div>
  </div>
  <div class="row">
    <div class="col-md-6 list-left">
      <h2><span class="icon icon-equalizer"></span> Default Settings</h2>
      <p>Common metadata, like <em>solution file</em> or <em>repository url</em>, and best-practice settings, like <em>custom loggers</em> or <em>coverage filters</em>, are automatically loaded into <code>DefaultSettings</code> and can be used to invoke tools more efficiently.</p>
      <div id="default-settings-carousel" class="carousel slide" data-ride="carousel2">
        <ol class="carousel-indicators">
          <li data-target="#default-settings-carousel" data-slide-to="0" class="active"></li>
          <li data-target="#default-settings-carousel" data-slide-to="1"></li>
        </ol>
        <div class="carousel-inner" role="listbox">
          <div class="item"><img src="images/default-settings01.png" data-color="lightblue" alt="Default Setting Declaration"></div>
          <div class="item"><img src="images/default-settings02.png" data-color="firebrick" alt="Default Setting Usage"></div>
        </div>
        <a class="left carousel-control" href="#default-settings-carousel" role="button" data-slide="prev">
          <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
          <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#default-settings-carousel" role="button" data-slide="next">
          <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
          <span class="sr-only">Next</span>
        </a>
      </div>
    </div>
    <div class="col-md-6 list-right">
      <h2><span class="icon icon-notebook"></span> Adaptive Logging</h2>
      <p>Log output is optimized for the best readability. Depending on the current environment the build is running on, target captions will be printed in various figlet fonts or utilize service messages if supported by the CI system.</p>
      <div id="adaptive-logging-carousel" class="carousel slide" data-ride="carousel3">
        <ol class="carousel-indicators">
          <li data-target="#adaptive-logging-carousel" data-slide-to="0" class="active"></li>
          <li data-target="#adaptive-logging-carousel" data-slide-to="1"></li>
          <li data-target="#adaptive-logging-carousel" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner" role="listbox">
          <div class="item"><img src="images/logging01.png" data-color="lightblue" alt="Bitrise Logging"></div>
          <div class="item"><img src="images/logging02.png" data-color="lightblue" alt="Console Logging"></div>
          <div class="item"><img src="images/logging03.png" data-color="lightblue" alt="TeamCity Logging"></div>
        </div>
        <a class="left carousel-control" href="#adaptive-logging-carousel" role="button" data-slide="prev">
          <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
          <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#adaptive-logging-carousel" role="button" data-slide="next">
          <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
          <span class="sr-only">Next</span>
        </a>
      </div>
    </div>
  </div>
</div>

