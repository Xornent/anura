using System.IO;

namespace Anura.Typography.WebFont {
    public delegate bool BrotliDecompressStreamFunc (byte[] compressedInput, Stream decompressStream);
}