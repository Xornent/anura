

<p style="font-family: PingFang SC Light;font-size:4em; margin:0; text-align:center;"><img width='128' src='https://github.com/xornent/anura-core/blob/master/anura-resources/application/logo/anura.ico' alt='anura project logo' style='margin-top:30px'/><br>Project Anura</h1>

---

# status

> the project is far from complete. please not download this for 
  build and other productive purposes. if I think it is stable enough
  to be used, I will remove this notice.

if you are members of anura developers, or want to improve the project,
you can still get to know how to clone the repository and learn the steps
to build it.

## set up visual studio code environment for anura ***recommended***
for some environments, the visual studio code sometimes meets with unexpected problems. this readme also **provide ways to 
tackle with these problems**. `:)` they usually starts with tag (bug-firing).

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
* ***bug-firing*** if you find your omnisharp server throw errors `Cannot find specific SDK "xxx"`, check if your
  enviroment variables are set correctly. if `xxx.xxxxxx() cannot be evaluated`, you had better install a previous
  version of `C#` extension, `(version 1.15.2 is great)`
* this is the project file structure, including its nuget dependencies
  ``` xml
  <Project Sdk="Microsoft.NET.Sdk.WindowsDesktop">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <UseWindowsForms>true</UseWindowsForms>
    <TargetFramework>netcoreapp3.1</TargetFramework>
    <OutputPath>..\anura core\.vscode\out\netcoreapp3.1</OutputPath>
  </PropertyGroup>
  
  <PropertyGroup>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
  </PropertyGroup>
  
  <ItemGroup>
    <PackageReference Include="SharpDX.Direct3D11" Version="4.2.0" />
    <PackageReference Include="SharpDX.Direct3D11.Effects" Version="4.2.0" />
    <PackageReference Include="SharpDX" Version="4.2.0" />
    <PackageReference Include="SharpDX.D3DCompiler" Version="4.2.0" />
    <PackageReference Include="SharpDX.Direct2D1" Version="4.2.0" />
    <PackageReference Include="SharpDX.DXGI" Version="4.2.0" />
  </ItemGroup>

  </Project>
  ```


## if you prefer other IDEs
## clone

* if you have git installed, git command:
  ```
  git clone https://www.github.com/xornent/anura.git
  ```
* or you can download the zip archieve from github.

## dependencies

the project(or part of it) is dependent on the following third-party libraries (or open-source projects)
* **anura-core**
  * *no package references*
* **anura-windows**
  * SharpDx.Core
  * SharpDx.DXGI
  * SharpDx.Direct3D11
  * SharpDx.Direct3D11.Effects
  * SharpDx.Direct2D1
  * SharpDx.D3DCompiler
* **anura-resources**
  * *no package references*

## runtime and sdks
the project is compiled on **.Net Core 3.1.3**. with sdk dependencies on **Windows Forms**.
the project runtime system-compatible list is as follows:
* **anura-core**
  * *all systems that can run **.Net Core 3.1***
* **anura-windows**
  * all **Microsoft Windows** versions that can run **.Net Core 3.1** and **DirectX 11**
* **anura-resources**
  * *no executable files*

# vista

I am working on the following features before the first public milestone. (0.1.0)

| feature                                                     | work-item-id | progress                                                                                                                    |
|-------------------------------------------------------------|--------------|-----------------------------------------------------------------------------------------------------------------------------|
| **javascript es6 standardizing**                            |              | the javascript interpreting engine is forked on an open-source repos *jint*, and with further extensions of es6 capability. |
| arrows                                                      | jint         | :white_check_mark:                                                                                                          |
| classes                                                     | #5-01        | :x:                                                                                                                         |
| enhanced object literals                                    | jint         | :white_check_mark:                                                                                                          |
| template strings                                            | jint         | :white_check_mark:                                                                                                          |
| destructuring                                               | jint         | :white_check_mark:                                                                                                          |
| default + rest + spread                                     | jint         | :white_check_mark:                                                                                                          |
| let + const                                                 | #5-02        | :x:                                                                                                                         |
| iterators + for..of                                         | #5-03        | :x:                                                                                                                         |
| generators                                                  | #5-04        | :x:                                                                                                                         |
| unicode                                                     | #5-05        | :x:                                                                                                                         |
| modules                                                     | #5-06        | :x:                                                                                                                         |
| module loaders                                              | #5-07        | :x:                                                                                                                         |
| map + set                                                   | #5-08        | :x:                                                                                                                         |
| weakmap + weakset                                           | #5-09        | :x:                                                                                                                         |
| proxies                                                     | #5-0A        | :x:                                                                                                                         |
| symbols                                                     | #5-0B        | :x:                                                                                                                         |
| subclassable built-ins                                      | #5-0C        | :x:                                                                                                                         |
| promises                                                    | #5-0D        | :x:                                                                                                                         |
| math APIs                                                   | #5-0E        | :white_check_mark:                                                                                                          |
| number APIs                                                 | #5-0F        | :white_check_mark:                                                                                                          |
| string APIs                                                 | #5-10        | :white_check_mark:                                                                                                          |
| array APIs                                                  | #5-11        | :white_check_mark:                                                                                                          |
| object APIs                                                 | #5-12        | :white_check_mark:                                                                                                          |
| binary and octal literals                                   | #5-13        | :x:                                                                                                                         |
| reflect api                                                 | #5-14        | :x:                                                                                                                         |
| tail calls                                                  | #5-15        | :x:                                                                                                                         |
| **javascript web application interfaces**                   |              | extend the javascript object model used in a browser (known as bom.)                                                        |
| **cascading stylesheet capabilities**                       |              | parsing and utilizing css files and combine its definitions into a render tree                                              |
| **html parsing**                                            |              | parse html and construct a proto render tree                                                                                |
| **error tolerance**                                         |              | tolerate simple and common errors made by web designers and developers                                                      |
| **rendering tree building and presentation infrastructure** |              | packaging a set of common graphic function interfaces for the later implementation on windows and/or other platforms        |
| **mime and application processors**                         |              | accessing web requests and process the downloaded files                                                                     |
| **web fontload and font rendering**                         |              | turn font-load into glyph path regardless of format and system settings.                                                    |

# foot notes

the project has other references, but their code have already been merged into the project, and
some changes in types, extensions and architecture have been applied. the full dependencies are listed:
* The SharpDx Projects
  * SharpDx.Core
  * SharpDx.DXGI
  * SharpDx.Direct3D11
  * SharpDx.Direct3D11.Effects
  * SharpDx.Direct2D1
  * SharpDx.D3DCompiler*
* Esprima-dotnet (2020)
* Jint (a release published in 2019)

`Thanks to the contributors of these projects`

**[Status Notice]**: the project of this state is* **far from complete** , much of its functions
 and utilities was still **not implemented** , and that bugs remain unnoticed and unfixed. so 
 please not try to fork and spread this inmature repos.

**[Internationalization Notice]**: *due to regional reasons and my lack in English knowledge, 
a full documentation and guideline in English prove too difficult. the contents of the project 
are mainly provided in Simplified Chinese.*

---
Last Edited: 2nd May, 2020. yang-z.