namespace Anura.Styles
{
    public interface IDocumentFunction : IStylesheetNode
    {
        string Name { get; }
        string Data { get; }
    }
}