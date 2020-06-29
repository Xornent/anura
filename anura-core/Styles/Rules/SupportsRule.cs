using System;
using System.IO;
using System.Linq;

namespace Anura.Styles
{
    internal sealed class SupportsRule : ConditionRule, ISupportsRule
    {
        internal SupportsRule(StylesheetParser parser) : base(RuleType.Supports, parser) { }

        public override void ToCss(TextWriter writer, IStyleFormatter formatter) {
            var rules = formatter.Block(Rules);
            writer.Write(formatter.Rule("@supports", ConditionText, rules));
        }

        public string ConditionText {
            get => Condition.ToCss();
            set {
                var condition = Parser.ParseCondition(value);

                if (condition == null) {
                    throw new ParseException("Unable to parse condition");
                }

                Condition = condition;
            }
        }

        public IConditionFunction Condition {
            get => Children.OfType<IConditionFunction>().FirstOrDefault() ?? new EmptyCondition();
            set {
                if (value == null) {
                    return;
                }

                RemoveChild(Condition);
                AppendChild(value);
            }
        }
    }
}