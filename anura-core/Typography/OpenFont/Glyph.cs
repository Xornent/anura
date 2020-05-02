using System;
using Anura.Typography.OpenFont.CFF;
using Anura.Typography.OpenFont.MathGlyphs;

namespace Anura.Typography.OpenFont {
    public class Glyph {
        private GlyphPointF[] glyphPoints;

        private ushort[] _contourEndPoints;

        private ushort _orgAdvWidth;

        private bool _hasOrgAdvWidth;

        private Bounds _bounds;

        public static readonly Glyph Empty = new Glyph (new GlyphPointF[0], new ushort[0], Bounds.Zero, null, 0);

        internal Cff1Font _ownerCffFont;

        internal Cff1GlyphData _cff1GlyphData;

        public Bounds Bounds {
            get {
                return _bounds;
            }
            internal set {
                _bounds = value;
            }
        }

        public ushort[] EndPoints => _contourEndPoints;

        public GlyphPointF[] GlyphPoints => glyphPoints;

        public ushort OriginalAdvanceWidth {
            get {
                return _orgAdvWidth;
            }
            set {
                _orgAdvWidth = value;
                _hasOrgAdvWidth = true;
            }
        }

        public bool HasOriginalAdvancedWidth => _hasOrgAdvWidth;

        internal byte[] GlyphInstructions {
            get;
            set;
        }

        public bool HasGlyphInstructions => GlyphInstructions != null;

        public GlyphClassKind GlyphClass {
            get;
            set;
        }

        internal ushort MarkClassDef {
            get;
            set;
        }

        public short MinX => _bounds.XMin;

        public short MaxX => _bounds.XMax;

        public short MinY => _bounds.YMin;

        public short MaxY => _bounds.YMax;

        public ushort GlyphIndex {
            get;
        }

        public bool IsCffGlyph => _ownerCffFont != null;

        public MathGlyphInfo MathGlyphInfo {
            get;
            internal set;
        }

        public bool HasMathGlyphInfo {
            get;
            internal set;
        }

        internal Glyph (GlyphPointF[] glyphPoints, ushort[] contourEndPoints, Bounds bounds, byte[] glyphInstructions, ushort index) {
            this.glyphPoints = glyphPoints;
            _contourEndPoints = contourEndPoints;
            Bounds = bounds;
            GlyphInstructions = glyphInstructions;
            GlyphIndex = index;
        }

        internal static void OffsetXY (Glyph glyph, short dx, short dy) {
            GlyphPointF[] array = glyph.glyphPoints;
            for (int num = array.Length - 1; num >= 0; num--) {
                array[num] = array[num].Offset (dx, dy);
            }
            Bounds bounds = glyph._bounds;
            glyph._bounds = new Bounds ((short) (bounds.XMin + dx), (short) (bounds.YMin + dy), (short) (bounds.XMax + dx), (short) (bounds.YMax + dy));
        }

        internal static void TransformNormalWith2x2Matrix (Glyph glyph, float m00, float m01, float m10, float m11) {
            float num = 0f;
            float num2 = 0f;
            float num3 = 0f;
            float num4 = 0f;
            GlyphPointF[] array = glyph.glyphPoints;
            for (int num5 = array.Length - 1; num5 >= 0; num5--) {
                GlyphPointF glyphPointF = array[num5];
                float x = glyphPointF.P.X;
                float y = glyphPointF.P.Y;
                float num6;
                float num7;
                array[num5] = new GlyphPointF (num6 = (float) Math.Round (x * m00 + y * m10), num7 = (float) Math.Round (x * m01 + y * m11), glyphPointF.onCurve);
                if (num6 < num) {
                    num = num6;
                }
                if (num6 > num3) {
                    num3 = num6;
                }
                if (num7 < num2) {
                    num2 = num7;
                }
                if (num7 > num4) {
                    num4 = num7;
                }
            }
            glyph._bounds = new Bounds ((short) num, (short) num2, (short) num3, (short) num4);
        }

        internal static Glyph Clone (Glyph original, ushort newGlyphIndex) {
            return new Glyph (Utils.CloneArray (original.glyphPoints), Utils.CloneArray (original._contourEndPoints), original.Bounds, (original.GlyphInstructions != null) ? Utils.CloneArray (original.GlyphInstructions) : null, newGlyphIndex);
        }

        internal static void AppendGlyph (Glyph dest, Glyph src) {
            int num = dest._contourEndPoints.Length;
            int num4 = src._contourEndPoints.Length;
            ushort num2 = (ushort) (dest._contourEndPoints[num - 1] + 1);
            dest.glyphPoints = Utils.ConcatArray (dest.glyphPoints, src.glyphPoints);
            dest._contourEndPoints = Utils.ConcatArray (dest._contourEndPoints, src._contourEndPoints);
            int num3 = dest._contourEndPoints.Length;
            for (int i = num; i < num3; i++) {
                dest._contourEndPoints[i] += num2;
            }
            Bounds bounds = dest.Bounds;
            Bounds bounds2 = src.Bounds;
            short xmin = Math.Min (bounds.XMin, bounds2.XMin);
            short ymin = Math.Min (bounds.YMin, bounds2.YMin);
            short xmax = Math.Max (bounds.XMax, bounds2.XMax);
            short ymax = Math.Max (bounds.YMax, bounds2.YMax);
            dest._bounds = new Bounds (xmin, ymin, xmax, ymax);
        }

        internal Glyph (Cff1Font owner, Cff1GlyphData cff1Glyph) {
            _ownerCffFont = owner;
            _cff1GlyphData = cff1Glyph;
            GlyphIndex = cff1Glyph.GlyphIndex;
        }

        public Cff1Font GetOwnerCff () {
            return _ownerCffFont;
        }

        public Cff1GlyphData GetCff1GlyphData () {
            return _cff1GlyphData;
        }
    }
}