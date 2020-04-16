namespace Anura.Typography.OpenFont {
    public static class UnicodeLangBitsExtension {
        public static UnicodeRangeInfo ToUnicodeRangeInfo (this UnicodeLangBits unicodeLangBits) {
            int bitNo = (int) ((long) unicodeLangBits >> 32);
            uint num = (uint) (unicodeLangBits & (UnicodeLangBits) 4294967295L);
            return new UnicodeRangeInfo (bitNo, (int) (num >> 16), (int) (num & 0xFFFF));
        }
    }
}