using System.IO;
namespace Anura.Styles
{
    public interface IStyleFormattable
    {
        void ToCss(TextWriter writer, IStyleFormatter formatter);
    }
}