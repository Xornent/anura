namespace Anura.Styles {
    public interface IMediaRule : IConditionRule {
        MediaList Media { get; }
    }
}