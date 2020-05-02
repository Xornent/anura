using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Anura.Typography.OpenFont.Tables {
    internal class PostTable : TableEntry {
        public const string _N = "post";

        private uint _italicAngle;

        private short _underlinePosition;

        private short _underlineThickness;

        private Dictionary<ushort, string> _glyphNames;

        private Dictionary<string, ushort> _glyphIndiceByName;

        public override string Name => "post";

        public int Version {
            get;
            set;
        }

        internal Dictionary<ushort, string> GlyphNames => _glyphNames;

        protected override void ReadContentFrom (BinaryReader reader) {
            uint num = reader.ReadUInt32 ();
            _italicAngle = reader.ReadUInt32 ();
            _underlinePosition = reader.ReadInt16 ();
            _underlineThickness = reader.ReadInt16 ();
            reader.ReadUInt32 ();
            reader.ReadUInt32 ();
            reader.ReadUInt32 ();
            reader.ReadUInt32 ();
            reader.ReadUInt32 ();
            switch (num) {
                case 65536u:
                case 196608u:
                    Version = 1;
                    break;
                case 131072u:
                    {
                        Version = 2;
                        _glyphNames = new Dictionary<ushort, string> ();
                        ushort num2 = reader.ReadUInt16 ();
                        ushort[] array = Utils.ReadUInt16Array (reader, num2);
                        string[] stdMacGlyphNames = MacPostFormat1.GetStdMacGlyphNames ();
                        for (ushort num3 = 0; num3 < num2; num3 = (ushort) (num3 + 1)) {
                            ushort num4 = array[num3];
                            if (num4 < 258) {
                                _glyphNames[num3] = stdMacGlyphNames[num4];
                            } else {
                                int count = reader.ReadByte ();
                                _glyphNames.Add (num3, Encoding.UTF8.GetString (reader.ReadBytes (count), 0, count));
                            }
                        }
                        break;
                    }
                case 151552u:
                    throw new NotSupportedException ();
            }
        }

        internal ushort GetGlyphIndex (string glyphName) {
            if (_glyphNames == null) {
                return 0;
            }
            if (_glyphIndiceByName == null) {
                _glyphIndiceByName = new Dictionary<string, ushort> ();
                foreach (KeyValuePair<ushort, string> glyphName2 in _glyphNames) {
                    _glyphIndiceByName[glyphName2.Value] = glyphName2.Key;
                }
            }
            _glyphIndiceByName.TryGetValue (glyphName, out ushort value);
            return value;
        }
    }
}