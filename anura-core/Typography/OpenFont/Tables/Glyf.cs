using System;
using System.Collections.Generic;
using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class Glyf : TableEntry {
        [Flags]
        private enum SimpleGlyphFlag : byte {
            OnCurve = 0x1,
            XByte = 0x2,
            YByte = 0x4,
            Repeat = 0x8,
            XSignOrSame = 0x10,
            YSignOrSame = 0x20
        }

        [Flags]
        internal enum CompositeGlyphFlags : ushort {
            ARG_1_AND_2_ARE_WORDS = 0x1,
            ARGS_ARE_XY_VALUES = 0x2,
            ROUND_XY_TO_GRID = 0x4,
            WE_HAVE_A_SCALE = 0x8,
            RESERVED = 0x10,
            MORE_COMPONENTS = 0x20,
            WE_HAVE_AN_X_AND_Y_SCALE = 0x40,
            WE_HAVE_A_TWO_BY_TWO = 0x80,
            WE_HAVE_INSTRUCTIONS = 0x100,
            USE_MY_METRICS = 0x200,
            OVERLAP_COMPOUND = 0x400,
            SCALED_COMPONENT_OFFSET = 0x800,
            UNSCALED_COMPONENT_OFFSET = 0x1000
        }

        public const string _N = "glyf";

        private Glyph[] _glyphs;

        public override string Name => "glyf";

        public Glyph[] Glyphs {
            get {
                return _glyphs;
            }
            internal set {
                _glyphs = value;
            }
        }

        private GlyphLocations GlyphLocations {
            get;
        }

        public Glyf (GlyphLocations glyphLocations) {
            GlyphLocations = glyphLocations;
        }

        protected override void ReadContentFrom (BinaryReader reader) {
            uint offset = base.Header.Offset;
            GlyphLocations glyphLocations = GlyphLocations;
            int glyphCount = glyphLocations.GlyphCount;
            _glyphs = new Glyph[glyphCount];
            List<ushort> list = new List<ushort> ();
            for (int i = 0; i < glyphCount; i++) {
                reader.BaseStream.Seek (offset + glyphLocations.Offsets[i], SeekOrigin.Begin);
                if (glyphLocations.Offsets[i + 1] - glyphLocations.Offsets[i] != 0) {
                    short num = reader.ReadInt16 ();
                    if (num >= 0) {
                        Bounds bounds = Utils.ReadBounds (reader);
                        _glyphs[i] = ReadSimpleGlyph (reader, num, bounds, (ushort) i);
                    } else {
                        list.Add ((ushort) i);
                    }
                } else {
                    _glyphs[i] = Glyph.Empty;
                }
            }
            foreach (ushort item in list) {
                _glyphs[item] = ReadCompositeGlyph (_glyphs, reader, offset, item);
            }
        }

        private static bool HasFlag (SimpleGlyphFlag target, SimpleGlyphFlag test) {
            return (target & test) == test;
        }

        internal static bool HasFlag (CompositeGlyphFlags target, CompositeGlyphFlags test) {
            return (target & test) == test;
        }

        private static SimpleGlyphFlag[] ReadFlags (BinaryReader input, int flagCount) {
            SimpleGlyphFlag[] array = new SimpleGlyphFlag[flagCount];
            int num = 0;
            int num2 = 0;
            SimpleGlyphFlag simpleGlyphFlag = (SimpleGlyphFlag) 0;
            while (num < flagCount) {
                if (num2 > 0) {
                    num2--;
                } else {
                    simpleGlyphFlag = (SimpleGlyphFlag) input.ReadByte ();
                    if (HasFlag (simpleGlyphFlag, SimpleGlyphFlag.Repeat)) {
                        num2 = input.ReadByte ();
                    }
                }
                array[num++] = simpleGlyphFlag;
            }
            return array;
        }

        private static short[] ReadCoordinates (BinaryReader input, int pointCount, SimpleGlyphFlag[] flags, SimpleGlyphFlag isByte, SimpleGlyphFlag signOrSame) {
            short[] array = new short[pointCount];
            int num = 0;
            for (int i = 0; i < pointCount; i++) {
                int num2;
                if (HasFlag (flags[i], isByte)) {
                    byte b = input.ReadByte ();
                    num2 = (HasFlag (flags[i], signOrSame) ? b : (-b));
                } else {
                    num2 = ((!HasFlag (flags[i], signOrSame)) ? input.ReadInt16 () : 0);
                }
                num += num2;
                array[i] = (short) num;
            }
            return array;
        }

        private static Glyph ReadSimpleGlyph (BinaryReader reader, int contourCount, Bounds bounds, ushort index) {
            ushort[] array = Utils.ReadUInt16Array (reader, contourCount);
            ushort count = reader.ReadUInt16 ();
            byte[] glyphInstructions = reader.ReadBytes (count);
            int num = array[contourCount - 1] + 1;
            SimpleGlyphFlag[] array2 = ReadFlags (reader, num);
            short[] array3 = ReadCoordinates (reader, num, array2, SimpleGlyphFlag.XByte, SimpleGlyphFlag.XSignOrSame);
            short[] array4 = ReadCoordinates (reader, num, array2, SimpleGlyphFlag.YByte, SimpleGlyphFlag.YSignOrSame);
            int num2 = array3.Length;
            GlyphPointF[] array5 = new GlyphPointF[num2];
            for (int num3 = num2 - 1; num3 >= 0; num3--) {
                bool onCurve = HasFlag (array2[num3], SimpleGlyphFlag.OnCurve);
                array5[num3] = new GlyphPointF (array3[num3], array4[num3], onCurve);
            }
            return new Glyph (array5, array, bounds, glyphInstructions, index);
        }

        private Glyph ReadCompositeGlyph (Glyph[] createdGlyphs, BinaryReader reader, uint tableOffset, ushort compositeGlyphIndex) {
            reader.BaseStream.Seek (tableOffset + GlyphLocations.Offsets[compositeGlyphIndex], SeekOrigin.Begin);
            reader.ReadInt16 ();
            Utils.ReadBounds (reader);
            Glyph glyph = null;
            CompositeGlyphFlags target;
            do {
                target = (CompositeGlyphFlags) reader.ReadUInt16 ();
                ushort num = reader.ReadUInt16 ();
                if (createdGlyphs[num] == null) {
                    long position = reader.BaseStream.Position;
                    Glyph glyph2 = createdGlyphs[num] = ReadCompositeGlyph (createdGlyphs, reader, tableOffset, num);
                    reader.BaseStream.Position = position;
                }
                Glyph glyph3 = Glyph.Clone (createdGlyphs[num], compositeGlyphIndex);
                short dx = 0;
                short dy = 0;
                if (HasFlag (target, CompositeGlyphFlags.ARG_1_AND_2_ARE_WORDS)) {
                    dx = reader.ReadInt16 ();
                    dy = reader.ReadInt16 ();
                } else {
                    reader.ReadUInt16 ();
                }
                float num2 = 1f;
                float m = 0f;
                float m2 = 0f;
                float num3 = 1f;
                bool flag = false;
                bool flag2 = false;
                if (HasFlag (target, CompositeGlyphFlags.WE_HAVE_A_SCALE)) {
                    num2 = (num3 = (float) reader.ReadInt16 () / 16384f);
                    flag2 = true;
                } else if (HasFlag (target, CompositeGlyphFlags.WE_HAVE_AN_X_AND_Y_SCALE)) {
                    num2 = (float) reader.ReadInt16 () / 16384f;
                    num3 = (float) reader.ReadInt16 () / 16384f;
                    flag2 = true;
                } else if (HasFlag (target, CompositeGlyphFlags.WE_HAVE_A_TWO_BY_TWO)) {
                    flag = true;
                    flag2 = true;
                    num2 = (float) reader.ReadInt16 () / 16384f;
                    m = (float) reader.ReadInt16 () / 16384f;
                    m2 = (float) reader.ReadInt16 () / 16384f;
                    num3 = (float) reader.ReadInt16 () / 16384f;
                    HasFlag (target, CompositeGlyphFlags.UNSCALED_COMPONENT_OFFSET);
                    HasFlag (target, CompositeGlyphFlags.USE_MY_METRICS);
                }
                if (HasFlag (target, CompositeGlyphFlags.ARGS_ARE_XY_VALUES)) {
                    if (flag) {
                        Glyph.TransformNormalWith2x2Matrix (glyph3, num2, m, m2, num3);
                        Glyph.OffsetXY (glyph3, dx, dy);
                    } else if (flag2) {
                        if ((double) num2 != 1.0 || (double) num3 != 1.0) {
                            Glyph.TransformNormalWith2x2Matrix (glyph3, num2, 0f, 0f, num3);
                        }
                        Glyph.OffsetXY (glyph3, dx, dy);
                    } else {
                        HasFlag (target, CompositeGlyphFlags.ROUND_XY_TO_GRID);
                        Glyph.OffsetXY (glyph3, dx, dy);
                    }
                }
                if (glyph == null) {
                    glyph = glyph3;
                } else {
                    Glyph.AppendGlyph (glyph, glyph3);
                }
            }
            while (HasFlag (target, CompositeGlyphFlags.MORE_COMPONENTS));
            if (HasFlag (target, CompositeGlyphFlags.WE_HAVE_INSTRUCTIONS)) {
                ushort count = reader.ReadUInt16 ();
                byte[] array2 = glyph.GlyphInstructions = reader.ReadBytes (count);
            }
            return glyph ?? Glyph.Empty;
        }
    }
}