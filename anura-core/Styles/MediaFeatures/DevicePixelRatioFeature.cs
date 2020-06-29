namespace Anura.Styles
{
    internal sealed class DevicePixelRatioFeature : MediaFeature
    {
        public DevicePixelRatioFeature(string name) : base(name) { }

        internal override IValueConverter Converter => Converters.NaturalNumberConverter;

    }
}