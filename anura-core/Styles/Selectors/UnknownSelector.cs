using System.IO;

namespace Anura.Styles {
    internal sealed class UnknownSelector : StylesheetNode, ISelector {
        public Priority Specifity => Priority.Zero;

        public string Text => this.ToCss ();

        public override void ToCss (TextWriter writer, IStyleFormatter formatter) {
            writer.Write (StylesheetText?.Text);
        }
    }
}