/*===============================================================================*\
                                                                (ORIGINAL MASTERS)
 © Xornent S.I. 2016-2020.                                 Yang Zheng. CHINA/WUHAN 
 
                                      PROJECT                 
                                       ANURA                    
 
===================================================================================
 Project timeline

 2020
 - Mar. 3rd
   Start this project. using Esprima, AgilityPack and Excss. Build some 
   0.0.2.123 (123 builds)
 - Mar. 5th night
   Notice Anglesharp.core try alternative.                                    (#1)
 - Mar. 7th
   Build first runnable library.
 - Mar. 15th
   Change back and write a simple javascript interpret engine and simlify the html
   and css dom. thus abandoning Anglesharp.                                   (#2)
 - Mar. 16th
   Change back to AgilityPack and Excss, and simply using it for parsing with 
   future attempts to re-packaging it into a full javascript and c# universal DOM.            
   See works of Anura.Developer namespace                                     (#3)
 - Mar. 25th
   Anura was transported to the .Net Core 2.1 platform.(partly due to my computer
   just couldn't compile .Net Core 3 but kept throwing unsolvable Sdk errors) and
   branches at Anura Core.
 - Mar. 26th
   Due to lack of user portability, abandoned HtmlAgilityPack and began to write
   a Html Dom Parser myself.
 - Apr. 10th
   Change the project system and establish a os-free library anura core. and using
   visual studio code to publish it onto 'branch core' of anura repos.        (#5)
 ---------------------------------------------------------------------------------
 The project Anura is an attempt to implement pure csharp explorer engines
===================================================================================
 The project is based (partially or partially its components) on the following open-
 source pure-csharp projects. ALL OF THEM OFFER PERMISSIVE LICENCES. ANYONE who is
 to REDISTRIBUTE AND(OR) MODIFY THIS PROJECT CONTENT SHOULD CARRY ONE COPY OF THIS 
 STATEMENT. (originally at the head of Anura/Program.cs).
 ---------------------------------------------------------------------------------
 I.  Javascript Parser and Tokenizer.
     Esprima (dotnet portal) : MIT

 II. The Freetype Project
     The FreeType Project LICENSE (3-clauses BSD style),2003-2016, David Turner,
     Robert Wilhelm, and Werner Lemberg and others.
	 https://www.freetype.org/

 III.msdfgen
     MIT, 2016, Viktor Chlumsky.
	 https://github.com/Chlumsky/msdfgen

 IV. poly2tri (dotnet portal)
     BSD, 2009-2010, poly2tri Contributors, 
	 https://github.com/PaintLab/poly2tri-cs

 V.  LayoutFarm.Typography
     Winter Devs : Apache 2
===================================================================================
 List of Contributors
 ---------------------------------------------------------------------------------
 1. Yang Zheng                                                 xornent@outlook.com

\*===============================================================================*/