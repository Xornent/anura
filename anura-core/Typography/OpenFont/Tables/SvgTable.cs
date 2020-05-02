using System;
using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class SvgTable : TableEntry {
        private struct SvgDocumentEntry {
            public ushort startGlyphID;

            public ushort endGlyphID;

            public uint svgDocOffset;

            public uint svgDocLength;

            public byte[] svgBuffer;

            public bool compressed;
        }

        public const string _N = "SVG ";

        private SvgDocumentEntry[] _entries;

        public override string Name => "SVG ";

        protected override void ReadContentFrom (BinaryReader reader) {
            long position = reader.BaseStream.Position;
            reader.ReadUInt16 ();
            uint num = reader.ReadUInt32 ();
            reader.ReadUInt32 ();
            long num2 = position + num;
            reader.BaseStream.Seek (num2, SeekOrigin.Begin);
            ushort num3 = reader.ReadUInt16 ();
            _entries = new SvgDocumentEntry[num3];
            for (int i = 0; i < num3; i++) {
                _entries[i] = new SvgDocumentEntry {
                    startGlyphID = reader.ReadUInt16 (),
                    endGlyphID = reader.ReadUInt16 (),
                    svgDocOffset = reader.ReadUInt32 (),
                    svgDocLength = reader.ReadUInt32 ()
                };
            }
            int num4 = 0;
            while (true) {
                if (num4 < num3) {
                    SvgDocumentEntry svgDocumentEntry = _entries[num4];
                    if (svgDocumentEntry.endGlyphID - svgDocumentEntry.startGlyphID > 0) {
                        throw new NotSupportedException ();
                    }
                    reader.BaseStream.Seek (num2 + svgDocumentEntry.svgDocOffset, SeekOrigin.Begin);
                    if (svgDocumentEntry.svgDocLength == 0) {
                        break;
                    }
                    byte[] array = reader.ReadBytes ((int) svgDocumentEntry.svgDocLength);
                    _entries[num4].svgBuffer = array;
                    if (array[0] != 60) {
                        _entries[num4].compressed = true;
                    }
                    num4++;
                    continue;
                }
                return;
            }
            throw new NotSupportedException ();
        }
    }
}