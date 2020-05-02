namespace Anura.Windows.Resources {
    public static class Global {
        public static string ResourceRelative = @"\resources\";

        public static string GetDefaultResourcePath () {
            if (Versioning.DebugMode)
                return @"G:\Github\Anura Core\anura-resources\";
            return System.Windows.Forms.Application.StartupPath + ResourceRelative;
        }

        public static System.Collections.Generic.List<string> Dependencies =
            new System.Collections.Generic.List<string> () {
                "Anura.exe"
            };
    }
}