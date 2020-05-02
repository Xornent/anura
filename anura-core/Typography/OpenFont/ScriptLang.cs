namespace Anura.Typography.OpenFont {
    public sealed class ScriptLang {
        public readonly string fullname;

        public readonly string shortname;

        public readonly int internalName;

        internal ScriptLang (string fullname, string shortname, int internalName) {
            this.fullname = fullname;
            this.shortname = shortname;
            this.internalName = internalName;
        }

        public override string ToString () {
            return fullname;
        }
    }
}