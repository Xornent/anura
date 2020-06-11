<br/>
<center><img width='128' src='./anura-resources/application/logo/anura.ico' alt='anura project logo'/></center><center><h1>
    Project Anura
    </h1></center>



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

# foot notes

the project has other references, but their code have already been merged into the project, and
some changes in types, extensions and architecture have been applied. the full dependencies are listed:
* The SharpDx Projects ***MIT***
  * SharpDx.Core
  * SharpDx.DXGI
  * SharpDx.Direct3D11
  * SharpDx.Direct3D11.Effects
  * SharpDx.Direct2D1
  * SharpDx.D3DCompiler*
* Esprima-dotnet (2020) ***3-Clause BSD***
* Jint ***2-Clause BSD***
* ExCss ***MIT***

`Thanks to the contributors of these projects`

[anura public license](./anura-resources/licenses/apl-zh-cn.md)

[anura references open-source licenses](./anura-resources/licenses/reference-zh-cn.md)

**[Status Notice]**: the project of this state is* **far from complete** , much of its functions
 and utilities was still **not implemented** , and that bugs remain unnoticed and unfixed. so 
 please not try to fork and spread this immature repos.

**[Internationalization Notice]**: *due to regional reasons and my lack in English knowledge, 
a full documentation and guideline in English prove too difficult. the contents of the project 
are mainly provided in Simplified Chinese.*

---
Last Edited: 11th June, 2020. yang-z.