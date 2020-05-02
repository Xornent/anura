using System.Collections.Generic;
using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    public class COLR : TableEntry {
        public const string _N = "COLR";

        public readonly Dictionary<ushort, ushort> LayerIndices = new Dictionary<ushort, ushort> ();

        public readonly Dictionary<ushort, ushort> LayerCounts = new Dictionary<ushort, ushort> ();

        public override string Name => "COLR";

        public ushort[] GlyphLayers {
            get;
            private set;
        }

        public ushort[] GlyphPalettes {
            get;
            private set;
        }

        protected override void ReadContentFrom (BinaryReader reader) {
            long position = reader.BaseStream.Position;
            reader.ReadUInt16 ();
            ushort num = reader.ReadUInt16 ();
            uint num2 = reader.ReadUInt32 ();
            uint num3 = reader.ReadUInt32 ();
            ushort num4 = reader.ReadUInt16 ();
            GlyphLayers = new ushort[num4];
            GlyphPalettes = new ushort[num4];
            reader.BaseStream.Seek (position + num2, SeekOrigin.Begin);
            for (int i = 0; i < num; i++) {
                ushort key = reader.ReadUInt16 ();
                LayerIndices[key] = reader.ReadUInt16 ();
                LayerCounts[key] = reader.ReadUInt16 ();
            }
            reader.BaseStream.Seek (position + num3, SeekOrigin.Begin);
            for (int j = 0; j < GlyphLayers.Length; j++) {
                GlyphLayers[j] = reader.ReadUInt16 ();
                GlyphPalettes[j] = reader.ReadUInt16 ();
            }
        }
    }
}