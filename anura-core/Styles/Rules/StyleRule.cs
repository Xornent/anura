using System.IO;
using System.Linq;

namespace Anura.Styles
{
    internal sealed class StyleRule : Rule
    {
        internal StyleRule(StylesheetParser parser) : base(RuleType.Style, parser) {
            AppendChild(SimpleSelector.All);
            AppendChild(new StyleDeclaration(this));
        }

        public override void ToCss(TextWriter writer, IStyleFormatter formatter) {
            writer.Write(formatter.Style(SelectorText, Style));
        }

        public ISelector Selector {
            get => Children.OfType<ISelector>().FirstOrDefault();
            set => ReplaceSingle(Selector, value);
        }

        public string SelectorText {
            get => Selector.Text;
            set => Selector = Parser.ParseSelector(value);
        }

        public StyleDeclaration Style => Children.OfType<StyleDeclaration>().FirstOrDefault();
    }
}