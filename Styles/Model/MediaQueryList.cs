namespace Anura.Styles {
    internal sealed class MediaQueryList {
        public MediaQueryList (MediaList media) {
            Media = media;
        }
        public string MediaText => Media.MediaText;
        public MediaList Media { get; }
    }
}