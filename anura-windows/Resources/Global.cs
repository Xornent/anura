namespace Anura.Windows.Resources {
    public static class Global {
        public static void InitializeGlobals (){
            LoadFonts();
        }

        public static string ResourceRelative = @"\resources\";

        public static string GetDefaultResourcePath () {
            if (Versioning.DebugMode)
                return @"G:\Github\Anura Core\anura-resources\";
            return System.Windows.Forms.Application.StartupPath + ResourceRelative;
        }

        public static void LoadFonts() {
            System.IO.DirectoryInfo dfonts = new System.IO.DirectoryInfo(GetDefaultResourcePath() + @"application\fonts\");
            foreach(var fonts in dfonts.GetFiles()){
                if(fonts.Extension.ToLower().Contains("ttf") || 
                fonts.Extension.ToLower().Contains("otf")){
                    ApplicationFontCollection.AddFontFile(fonts.FullName);
                    ApplicationFontDictionary.Add(fonts.Name.ToLower().Replace(".ttf", "").Replace(".otf", ""),
                    ApplicationFontCollection.Families[ApplicationFontCollection.Families.Length - 1]);
                }
            }
        }

        public static System.Drawing.Font GetInstalledFont(string culture, string style, float pts){
            System.Drawing.FontFamily family = null;
            bool success = ApplicationFontDictionary.TryGetValue(culture + "-" + style, out family);
            if(success)
                return new System.Drawing.Font(family, pts);
            else return new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, pts);
        }

        public static System.Drawing.Font GetInstalledFont(string style, float pts){
            System.Drawing.FontFamily family = null;
            bool success = ApplicationFontDictionary.TryGetValue(DefaultCulture + "-" + style, out family);
            if(success)
                return new System.Drawing.Font(family, pts);
            else return new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, pts);
        }

        public static string DefaultCulture = "zh-cn";

        public static System.Collections.Generic.List<string> Dependencies =
            new System.Collections.Generic.List<string> () {
                "Anura.dll",
                "SharpDx.D3DCompiler.dll",
                "SharpDx.Direct2D1.dll",
                "SharpDx.Direct3D11.dll",
                "SharpDx.dll",
                "SharpDx.Direct3D11.Effects.dll",
                "SharpDx.DXGI.dll",
                "license.txt"
            };

        public static System.Drawing.Text.PrivateFontCollection ApplicationFontCollection = new System.Drawing.Text.PrivateFontCollection();
        public static System.Collections.Generic.Dictionary<string, System.Drawing.FontFamily> ApplicationFontDictionary = new System.Collections.Generic.Dictionary<string, System.Drawing.FontFamily>() { };
    }
}