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
     BSD, 2009-2010, Anura.Typography.Triangulation Contributors, 
	 https://github.com/PaintLab/poly2tri-cs

 V.  LayoutFarm.Typography
     Apache 2. Winter Devs

\*===============================================================================*/

using System;
using Anura.Developer;

namespace Anura {
    public static class Versioning {
        public static Version CoreVersion = new Version (0, 0, 4, 991);
        public static VersionMode Mode = VersionMode.Insider;

        public enum VersionMode {
            Insider,
            Preview,
            Candidate,
            Stable
        }
    }

    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Anura Core: Version [" + Versioning.Mode.ToString () + "] " + Versioning.CoreVersion.ToString ());
            
            Anura.Developer.Logger.OnLog += Logger;
            JavaScript.Engine engine = new JavaScript.Engine (cfg =>
                cfg.AllowClr ().DebugMode ());
            engine.SetValue ("alert", new Action<object> (Alert));
            engine.Execute ("var __anura__ = new __Anura__(); ");

            while (true) {
                Anura.Developer.Logger.Log ("Anura Core JS Debugger", "等待用户输入（多行的）JavaScript 代码，空行启动运行", "", Anura.Developer.Logger.LogStatus.Message);
                bool eoc = false;
                string code = "";

                try {
                    while (!eoc) {
                        string uri = Console.ReadLine ();
                        if (uri == "")
                            eoc = true;
                        else {
                            code = code + uri + "\n";
                        }
                        //// Anura.Developer.Network.NavigationDocument doc = new Developer.Network.NavigationDocument(
                        ////    new Developer.Network.NetworkConfiguration(), uri
                        //// );
                    }
                    engine.Execute (code);
                } catch (Exception ex) {
                    Developer.Logger.Log ("JS Engine", ex.Message, ex.StackTrace, Developer.Logger.LogStatus.Error);
                }
            }
        }

        private static void Alert (object sender) {
            Anura.Developer.Logger.Log ("JS Engine", sender.ToString (), "", Developer.Logger.LogStatus.Message);
        }

        private static void Logger (object sender, Anura.Developer.Logger.LogEventArgs args) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write (args.File + " :> ");
            switch (args.Status) {
                case Anura.Developer.Logger.LogStatus.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Anura.Developer.Logger.LogStatus.Message:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case Anura.Developer.Logger.LogStatus.OK:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Anura.Developer.Logger.LogStatus.Warning:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
            }
            Console.WriteLine (args.Message);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            if (args.Extension != "")
                Console.WriteLine (args.Extension);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}