<br/>
<center>
  <img width='128' src='./anura-resources/application/logo/anura.ico' alt='anura project logo'/>
</center>
<center>
  <h1>
    Project Anura
  </h1>
</center>

# status

> the project is far from complete. please not download this for 
  build and other productive purposes. if I think it is stable enough
  to be used, I will remove this notice.

if you are members of anura developers, or want to improve the project,
you can still get to know how to clone the repository and learn the steps
to build it.

## set up visual studio code environment for anura ***recommended***
for some environments, the visual studio code sometimes meets with unexpected problems. 
this readme also **provide ways to tackle with these problems**. `:)` they usually 
starts with tag (bug-firing).

* Download Visual Studio Code
* Download .Net Core 3.1.3 Development Pack.
* ***bug-firing*** append to 'PATH' environment variables
  **the location of sdks in which you install dotnet core**, and create new 
  variable called  `MSBuildSdksPath`. for example:
  ```
  SET PATH %PATH%;C:\Program Files\dotnet\sdks\3.0.201\sdks\
  SET MSBuildSdksPath C:\Program Files\dotnet\sdks\3.0.201\sdks\
  ```
* Install extensions "C#" `ms-vscode`, "Better Comments" `Copyright Aaron Bond`.
* ***bug-firing*** if you find your omnisharp server throw errors 
  `Cannot find specific SDK "xxx"`, check if yourenviroment variables are set correctly.
  if `xxx.xxxxxx() cannot be evaluated`, you had better install a previous
  version of `C#` extension, `(version 1.15.2 is great)`

## clone

* if you have git installed, git command:
  ```
  git clone https://www.github.com/xornent/anura.git
  ```
* or you can download the zip archive from github.

## dependencies

the project(or part of it) is dependent on the following third-party libraries (or open-source projects)
  * *no package references*

## runtime and sdks
the project is compiled on **.Net Core 3.1.3**
the project runtime system-compatible list is as follows:
  * *all systems that can run **.Net Core 3.1***

# references

the project has other references, but their code have already been merged into the 
project, and some changes in types, extensions and architecture have been applied. 
the full dependencies are listed:

* LayoutFarm.Typography ***MIT***
  
  Geometry

  * BSD, 2002-2005, Maxim Shemanarev, http://www.antigrain.com , Anti-Grain Geometry - Version 2.4,

  * BSD, 2007-2014, Lars Brubaker, agg-sharp, https://github.com/MatterHackers/agg-sharp

  * ZLIB, 2015, burningmine, CurveUtils.

  * Boost, 2010-2014, Angus Johnson, Clipper.

  * BSD, 2009-2010, Poly2Tri Contributors, https://github.com/PaintLab/poly2tri-cs

  * SGI, 2000, Eric Veach, Tesselate.

  * MIT, 2016, Viktor Chlumsky, https://github.com/Chlumsky/msdfgen

  Font

  * MIT, 2016-2017, WinterDev, https://github.com/LayoutFarm/Typography

  * Apache2, 2014-2016, Samuel Carlsson, https://github.com/vidstige/NRasterizer

  * MIT, 2015, Michael Popoloski MIT, https://github.com/MikePopoloski/SharpFont

  * The FreeType Project LICENSE (3-clauses BSD style),2003-2016, David Turner, Robert Wilhelm, and Werner Lemberg and others, https://www.freetype.org/

  * Apache2, 2018, Apache/PDFBox Authors, https://github.com/apache/pdfbox

  Text Processing

  * Apache2, 2014 , Muhammad Tayyab Akram, https://sheenbidi.codeplex.com/ , https://github.com/Tehreer

  * Unpack, Zlib,Brotli

  * MIT, 2018, SharpZipLib, https://github.com/icsharpcode/SharpZipLib

  * MIT, 2009, 2010, 2013-2016 by the Brotli Authors., https://github.com/google/brotli

  * MIT, 2017, brezza92 (C# port from original code, by hand), https://github.com/brezza92/brotli

  * MIT, 2019, master131, https://github.com/master131/BrotliSharpLib

* Esprima-dotnet (2020) ***3-Clause BSD***

* Jint ***2-Clause BSD***

* ExCss ***MIT***

* OpenGL

`Thanks to the contributors of these projects`

# foot notes

[anura public license](./anura-resources/licenses/apl-zh-cn.md)

[anura references open-source licenses](./anura-resources/licenses/reference-zh-cn.md)

**[Status Notice]**: the project of this state is **far from complete** , much of its functions
 and utilities was still **not implemented** , and that bugs remain unnoticed and unfixed. so 
 please not try to fork and spread this immature repos.

**[Internationalization Notice]**: *due to regional reasons and my lack in English knowledge, 
a full documentation and guideline in English prove too difficult. the contents of the project 
are mainly provided in Simplified Chinese.*

---
Last Edited: 11th June, 2020. yang-z.