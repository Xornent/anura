namespace Anura.Styles {
    internal sealed class FontFamilyProperty : Property {
        private static readonly IValueConverter StyleConverter =
            Converters.FontFamiliesConverter.OrDefault ("Times New Roman");

        internal FontFamilyProperty () : base (PropertyNames.FontFamily, PropertyFlags.Inherited) { }

        internal override IValueConverter Converter => StyleConverter;
    }
}