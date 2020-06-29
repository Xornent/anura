namespace Anura.Styles
{
    internal sealed class LastChildSelector : ChildSelector
    {
        public LastChildSelector() : base(PseudoClassNames.NthLastChild) { }
    }
}