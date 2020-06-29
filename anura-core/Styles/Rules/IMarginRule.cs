namespace Anura.Styles
{
    public interface IMarginRule : IRule
    {
        string Name { get; }
        StyleDeclaration Style { get; }
    }
}