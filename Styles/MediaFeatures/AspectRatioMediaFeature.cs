using System;

namespace Anura.Styles {
    internal sealed class AspectRatioMediaFeature : MediaFeature {
        public AspectRatioMediaFeature (string name) : base (name) { }

        internal override IValueConverter Converter => Converters.RatioConverter;

    }
}