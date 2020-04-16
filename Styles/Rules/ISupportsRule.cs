namespace Anura.Styles {
    public interface ISupportsRule : IConditionRule {
        IConditionFunction Condition { get; }
    }
}