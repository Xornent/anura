using System;
using System.Collections.Generic;

namespace Anura.Styles
{
    public sealed class PseudoElementSelectorFactory
    {
        private static readonly Lazy<PseudoElementSelectorFactory> Lazy =
            new Lazy<PseudoElementSelectorFactory>(() => new PseudoElementSelectorFactory());

        internal static PseudoElementSelectorFactory Instance => Lazy.Value;

        private PseudoElementSelectorFactory() { }

        #region Selectors
        private readonly Dictionary<string, ISelector> _selectors =
            new Dictionary<string, ISelector>(StringComparer.OrdinalIgnoreCase) {
                // TODO: 有些选择器没有实现 (selection, content, ...)
                // 还有一下如下，是不能肯定的 (first-line, first-letter, ...)
                {
                PseudoElementNames.Before,
                SimpleSelector.PseudoElement (
                PseudoElementNames.Before)
                }, {
                PseudoElementNames.After,
                SimpleSelector.PseudoElement (
                PseudoElementNames.After)
                }, {
                PseudoElementNames.Selection,
                SimpleSelector.PseudoElement (PseudoElementNames.Selection)
                }, {
                PseudoElementNames.FirstLine,
                SimpleSelector.PseudoElement (PseudoElementNames.FirstLine)
                }, {
                PseudoElementNames.FirstLetter,
                SimpleSelector.PseudoElement (PseudoElementNames.FirstLetter)
                }, { PseudoElementNames.Content, SimpleSelector.PseudoElement (PseudoElementNames.Content) }
            };
        #endregion

        public ISelector Create(string name) {
            ISelector selector;

            return _selectors.TryGetValue(name, out selector) ? selector : null;
        }
    }
}