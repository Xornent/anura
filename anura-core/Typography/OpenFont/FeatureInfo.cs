namespace Anura.Typography.OpenFont {
    public sealed class FeatureInfo {
        public readonly string fullname;

        public readonly string shortname;

        public FeatureInfo (string fullname, string shortname) {
            this.fullname = fullname;
            this.shortname = shortname;
        }
    }
}