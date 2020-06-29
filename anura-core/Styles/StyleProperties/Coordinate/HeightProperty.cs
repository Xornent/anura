namespace Anura.Styles
{
    internal sealed class HeightProperty : Property
    {
        private static readonly IValueConverter StyleConverter =
            Converters.AutoLengthOrPercentConverter.OrDefault(Keywords.Auto);

        internal HeightProperty() : base(PropertyNames.Height, PropertyFlags.Unitless | PropertyFlags.Animatable) { }

        internal override IValueConverter Converter => StyleConverter;
    }
}