namespace Anura.Styles
{
    public interface IConditionRule : IGroupingRule
    {
        string ConditionText { get; set; }
    }
}