namespace Anura.Styles
{
    internal sealed class GridMediaFeature : MediaFeature
    {
        public GridMediaFeature() : base(FeatureNames.Grid) { }

        internal override IValueConverter Converter => Converters.BinaryConverter;

    }
}