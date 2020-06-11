using System;
using System.Collections.Generic;
using System.IO;
using Anura.Typography.OpenFont;
using Anura.Typography.OpenFont.IO;
using Anura.Typography.OpenFont.Tables;

namespace Anura.Typography.WebFont {
	internal class TransformedGlyf : UnreadTableEntry {
		private struct TempGlyph {
			public readonly ushort glyphIndex;

			public readonly short numContour;

			public ushort instructionLen;

			public bool compositeHasInstructions;

			public TempGlyph (ushort glyphIndex, short contourCount) {
				this.glyphIndex = glyphIndex;
				numContour = contourCount;
				instructionLen = 0;
				compositeHasInstructions = false;
			}
		}

		private struct TripleEncodingRecord {
			public readonly byte ByteCount;

			public readonly byte XBits;

			public readonly byte YBits;

			public readonly ushort DeltaX;

			public readonly ushort DeltaY;

			public readonly sbyte Xsign;

			public readonly sbyte Ysign;

			public TripleEncodingRecord (byte byteCount, byte xbits, byte ybits, ushort deltaX, ushort deltaY, sbyte xsign, sbyte ysign) {
				ByteCount = byteCount;
				XBits = xbits;
				YBits = ybits;
				DeltaX = deltaX;
				DeltaY = deltaY;
				Xsign = xsign;
				Ysign = ysign;
			}

			public int Tx (int orgX) {
				return (orgX + DeltaX) * Xsign;
			}

			public int Ty (int orgY) {
				return (orgY + DeltaY) * Ysign;
			}
		}

		private class TripleEncodingTable {
			private static TripleEncodingTable s_encTable;

			private List<TripleEncodingRecord> _records = new List<TripleEncodingRecord> ();

			public TripleEncodingRecord this [int index] {
				get {
					return _records[index];
				}
			}

			public static TripleEncodingTable GetEncTable () {
				if (s_encTable == null) {
					s_encTable = new TripleEncodingTable ();
				}
				return s_encTable;
			}

			private TripleEncodingTable () {
				BuildTable ();
			}

			private void BuildTable () {
				BuildRecords (2, 0, 8, null, new ushort[5] {
					0,
					256,
					512,
					768,
					1024
				});
				BuildRecords (2, 8, 0, new ushort[5] {
					0,
					256,
					512,
					768,
					1024
				}, null);
				BuildRecords (2, 4, 4, new ushort[1] {
					1
				}, new ushort[4] {
					1,
					17,
					33,
					49
				});
				BuildRecords (2, 4, 4, new ushort[1] {
					17
				}, new ushort[4] {
					1,
					17,
					33,
					49
				});
				BuildRecords (2, 4, 4, new ushort[1] {
					33
				}, new ushort[4] {
					1,
					17,
					33,
					49
				});
				BuildRecords (2, 4, 4, new ushort[1] {
					49
				}, new ushort[4] {
					1,
					17,
					33,
					49
				});
				BuildRecords (3, 8, 8, new ushort[1] {
					1
				}, new ushort[3] {
					1,
					257,
					513
				});
				BuildRecords (3, 8, 8, new ushort[1] {
					257
				}, new ushort[3] {
					1,
					257,
					513
				});
				BuildRecords (3, 8, 8, new ushort[1] {
					513
				}, new ushort[3] {
					1,
					257,
					513
				});
				BuildRecords (4, 12, 12, new ushort[1], new ushort[1]);
				BuildRecords (5, 16, 16, new ushort[1], new ushort[1]);
			}

			private void AddRecord (byte byteCount, byte xbits, byte ybits, ushort deltaX, ushort deltaY, sbyte xsign, sbyte ysign) {
				TripleEncodingRecord item = new TripleEncodingRecord (byteCount, xbits, ybits, deltaX, deltaY, xsign, ysign);
				_records.Add (item);
			}

			private void BuildRecords (byte byteCount, byte xbits, byte ybits, ushort[] deltaXs, ushort[] deltaYs) {
				if (deltaXs == null) {
					for (int i = 0; i < deltaYs.Length; i++) {
						AddRecord (byteCount, xbits, ybits, 0, deltaYs[i], 0, -1);
						AddRecord (byteCount, xbits, ybits, 0, deltaYs[i], 0, 1);
					}
					return;
				}
				if (deltaYs == null) {
					for (int j = 0; j < deltaXs.Length; j++) {
						AddRecord (byteCount, xbits, ybits, deltaXs[j], 0, -1, 0);
						AddRecord (byteCount, xbits, ybits, deltaXs[j], 0, 1, 0);
					}
					return;
				}
				foreach (ushort deltaX in deltaXs) {
					foreach (ushort deltaY in deltaYs) {
						AddRecord (byteCount, xbits, ybits, deltaX, deltaY, -1, -1);
						AddRecord (byteCount, xbits, ybits, deltaX, deltaY, 1, -1);
						AddRecord (byteCount, xbits, ybits, deltaX, deltaY, -1, 1);
						AddRecord (byteCount, xbits, ybits, deltaX, deltaY, 1, 1);
					}
				}
			}
		}

		private static TripleEncodingTable s_encTable = TripleEncodingTable.GetEncTable ();

		public Woff2TableDirectory TableDir {
			get;
		}

		public TransformedGlyf (TableHeader header, Woff2TableDirectory tableDir) : base (header) {
			base.HasCustomContentReader = true;
			TableDir = tableDir;
		}

		public override T CreateTableEntry<T> (BinaryReader reader, T expectedResult) {
			Glyf glyf = expectedResult as Glyf;
			if (glyf == null) {
				throw new NotSupportedException ();
			}
			ReconstructGlyfTable (reader, TableDir, glyf);
			return expectedResult;
		}

		private static void ReconstructGlyfTable (BinaryReader reader, Woff2TableDirectory woff2TableDir, Glyf glyfTable) {
			reader.BaseStream.Position = woff2TableDir.ExpectedStartAt;
			long position2 = reader.BaseStream.Position;
			reader.ReadUInt32 ();
			ushort num = reader.ReadUInt16 ();
			reader.ReadUInt16 ();
			uint num2 = reader.ReadUInt32 ();
			uint num3 = reader.ReadUInt32 ();
			uint num4 = reader.ReadUInt32 ();
			uint num5 = reader.ReadUInt32 ();
			uint num6 = reader.ReadUInt32 ();
			uint num7 = reader.ReadUInt32 ();
			uint num8 = reader.ReadUInt32 ();
			long num9 = reader.BaseStream.Position + num2 + num3 + num4;
			long num10 = num9 + num5;
			long position = num10 + num6 + num7;
			Glyph[] array = new Glyph[num];
			TempGlyph[] array2 = new TempGlyph[num];
			List<ushort> list = new List<ushort> ();
			int num11 = 0;
			for (ushort num12 = 0; num12 < num; num12 = (ushort) (num12 + 1)) {
				short num13 = reader.ReadInt16 ();
				array2[num12] = new TempGlyph (num12, num13);
				if (num13 > 0) {
					num11 += num13;
				} else if (num13 < 0) {
					list.Add (num12);
				}
			}
			ushort[] array3 = new ushort[num11];
			for (int i = 0; i < num11; i++) {
				array3[i] = Woff2Utils.Read255UInt16 (reader);
			}
			byte[] flagStream = reader.ReadBytes ((int) num4);
			using (MemoryStream memoryStream = new MemoryStream ()) {
				reader.BaseStream.Position = num10;
				memoryStream.Write (reader.ReadBytes ((int) num6), 0, (int) num6);
				memoryStream.Position = 0L;
				int count = list.Count;
				ByteOrderSwappingBinaryReader reader2 = new ByteOrderSwappingBinaryReader (memoryStream);
				for (ushort num14 = 0; num14 < count; num14 = (ushort) (num14 + 1)) {
					ushort num15 = list[num14];
					array2[num15].compositeHasInstructions = CompositeHasInstructions (reader2, num15);
				}
				reader.BaseStream.Position = num9;
			}
			int flagStreamIndex = 0;
			int pntContourIndex = 0;
			for (int j = 0; j < array2.Length; j++) {
				array[j] = BuildSimpleGlyphStructure (reader, ref array2[j], array3, ref pntContourIndex, flagStream, ref flagStreamIndex);
			}
			int count2 = list.Count;
			for (ushort num16 = 0; num16 < count2; num16 = (ushort) (num16 + 1)) {
				int num17 = list[num16];
				array[num17] = ReadCompositeGlyph (array, reader, num16);
			}
			int count3 = (num + 7) / 8;
			byte[] array4 = ExpandBitmap (reader.ReadBytes (count3));
			for (ushort num18 = 0; num18 < num; num18 = (ushort) (num18 + 1)) {
				TempGlyph tempGlyph = array2[num18];
				Glyph glyph = array[num18];
				if (array4[num18] == 1) {
					glyph.Bounds = new Bounds (reader.ReadInt16 (), reader.ReadInt16 (), reader.ReadInt16 (), reader.ReadInt16 ());
				} else {
					if (tempGlyph.numContour < 0) {
						throw new NotSupportedException ();
					}
					if (tempGlyph.numContour > 0) {
						glyph.Bounds = FindSimpleGlyphBounds (glyph);
					}
				}
			}
			reader.BaseStream.Position = position;
			for (ushort num19 = 0; num19 < num; num19 = (ushort) (num19 + 1)) {
				TempGlyph tempGlyph2 = array2[num19];
				if (tempGlyph2.instructionLen > 0) {
					array[num19].GlyphInstructions = reader.ReadBytes (tempGlyph2.instructionLen);
				}
			}
			glyfTable.Glyphs = array;
		}

		private static Bounds FindSimpleGlyphBounds (Glyph glyph) {
			GlyphPointF[] glyphPoints = glyph.GlyphPoints;
			int num = glyphPoints.Length;
			float num2 = float.MaxValue;
			float num3 = float.MaxValue;
			float num4 = float.MinValue;
			float num5 = float.MinValue;
			for (int i = 0; i < num; i++) {
				GlyphPointF glyphPointF = glyphPoints[i];
				if (glyphPointF.X < num2) {
					num2 = glyphPointF.X;
				}
				if (glyphPointF.X > num4) {
					num4 = glyphPointF.X;
				}
				if (glyphPointF.Y < num3) {
					num3 = glyphPointF.Y;
				}
				if (glyphPointF.Y > num5) {
					num5 = glyphPointF.Y;
				}
			}
			return new Bounds ((short) Math.Round (num2), (short) Math.Round (num3), (short) Math.Round (num4), (short) Math.Round (num5));
		}

		private static byte[] ExpandBitmap (byte[] orgBBoxBitmap) {
			byte[] array = new byte[orgBBoxBitmap.Length * 8];
			int num = 0;
			foreach (byte b in orgBBoxBitmap) {
				array[num++] = (byte) ((b >> 7) & 1);
				array[num++] = (byte) ((b >> 6) & 1);
				array[num++] = (byte) ((b >> 5) & 1);
				array[num++] = (byte) ((b >> 4) & 1);
				array[num++] = (byte) ((b >> 3) & 1);
				array[num++] = (byte) ((b >> 2) & 1);
				array[num++] = (byte) ((b >> 1) & 1);
				array[num++] = (byte) (b & 1);
			}
			return array;
		}

		private static Glyph BuildSimpleGlyphStructure (BinaryReader glyphStreamReader, ref TempGlyph tmpGlyph, ushort[] pntPerContours, ref int pntContourIndex, byte[] flagStream, ref int flagStreamIndex) {
			if (tmpGlyph.numContour == 0) {
				return Glyph.Empty;
			}
			if (tmpGlyph.numContour < 0) {
				if (tmpGlyph.compositeHasInstructions) {
					tmpGlyph.instructionLen = Woff2Utils.Read255UInt16 (glyphStreamReader);
				}
				return null;
			}
			int num = 0;
			int num2 = 0;
			int numContour = tmpGlyph.numContour;
			ushort[] array = new ushort[numContour];
			ushort num3 = 0;
			for (ushort num4 = 0; num4 < numContour; num4 = (ushort) (num4 + 1)) {
				ushort num5 = pntPerContours[pntContourIndex++];
				num3 = (ushort) (num3 + num5);
				array[num4] = (ushort) (num3 - 1);
			}
			GlyphPointF[] array2 = new GlyphPointF[num3];
			int i = 0;
			for (int j = 0; j < numContour; j++) {
				for (int num6 = array[j]; i <= num6; i++) {
					byte b = flagStream[flagStreamIndex++];
					int index = b & 0x7F;
					TripleEncodingRecord tripleEncodingRecord = s_encTable[index];
					byte[] array3 = glyphStreamReader.ReadBytes (tripleEncodingRecord.ByteCount - 1);
					int num7 = 0;
					int num8 = 0;
					switch (tripleEncodingRecord.XBits) {
						default : throw new NotSupportedException ();
						case 0:
								num7 = 0;
							num8 = tripleEncodingRecord.Ty (array3[0]);
							break;
						case 4:
								num7 = tripleEncodingRecord.Tx (array3[0] >> 4);
							num8 = tripleEncodingRecord.Ty (array3[0] & 0xF);
							break;
						case 8:
								num7 = tripleEncodingRecord.Tx (array3[0]);
							num8 = ((tripleEncodingRecord.YBits == 8) ? tripleEncodingRecord.Ty (array3[1]) : 0);
							break;
						case 12:
								num7 = tripleEncodingRecord.Tx ((array3[0] << 4) | (array3[1] >> 4));
							num8 = tripleEncodingRecord.Ty (((array3[1] & 0xF) << 8) | array3[2]);
							break;
						case 16:
								num7 = tripleEncodingRecord.Tx ((array3[0] << 8) | array3[1]);
							num8 = tripleEncodingRecord.Ty ((array3[2] << 8) | array3[3]);
							break;
					}
					array2[i] = new GlyphPointF (num += num7, num2 += num8, b >> 7 == 0);
				}
			}
			tmpGlyph.instructionLen = Woff2Utils.Read255UInt16 (glyphStreamReader);
			return new Glyph (array2, array, default (Bounds), null, tmpGlyph.glyphIndex);
		}

		private static bool CompositeHasInstructions (BinaryReader reader, ushort compositeGlyphIndex) {
			Glyf.CompositeGlyphFlags target;
			do {
				target = (Glyf.CompositeGlyphFlags) reader.ReadUInt16 ();
				reader.ReadUInt16 ();
				if (Glyf.HasFlag (target, Glyf.CompositeGlyphFlags.ARG_1_AND_2_ARE_WORDS)) {
					reader.ReadInt16 ();
					reader.ReadInt16 ();
				} else {
					reader.ReadUInt16 ();
				}
				if (Glyf.HasFlag (target, Glyf.CompositeGlyphFlags.WE_HAVE_A_SCALE)) {
					float num = (float) reader.ReadInt16 () / 16384f;
				} else if (Glyf.HasFlag (target, Glyf.CompositeGlyphFlags.WE_HAVE_AN_X_AND_Y_SCALE)) {
					float num2 = (float) reader.ReadInt16 () / 16384f;
					float num3 = (float) reader.ReadInt16 () / 16384f;
				} else if (Glyf.HasFlag (target, Glyf.CompositeGlyphFlags.WE_HAVE_A_TWO_BY_TWO)) {
					float num4 = (float) reader.ReadInt16 () / 16384f;
					float num5 = (float) reader.ReadInt16 () / 16384f;
					float num6 = (float) reader.ReadInt16 () / 16384f;
					float num7 = (float) reader.ReadInt16 () / 16384f;
				}
			}
			while (Glyf.HasFlag (target, Glyf.CompositeGlyphFlags.MORE_COMPONENTS));
			return Glyf.HasFlag (target, Glyf.CompositeGlyphFlags.WE_HAVE_INSTRUCTIONS);
		}

		private static Glyph ReadCompositeGlyph (Glyph[] createdGlyphs, BinaryReader reader, ushort compositeGlyphIndex) {
			Glyph glyph = null;
			Glyf.CompositeGlyphFlags target;
			do {
				target = (Glyf.CompositeGlyphFlags) reader.ReadUInt16 ();
				ushort num = reader.ReadUInt16 ();
				if (createdGlyphs[num] == null) {
					long position = reader.BaseStream.Position;
					Glyph glyph2 = createdGlyphs[num] = ReadCompositeGlyph (createdGlyphs, reader, num);
					reader.BaseStream.Position = position;
				}
				Glyph glyph3 = Glyph.Clone (createdGlyphs[num], compositeGlyphIndex);
				short dx = 0;
				short dy = 0;
				if (Glyf.HasFlag (target, Glyf.CompositeGlyphFlags.ARG_1_AND_2_ARE_WORDS)) {
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
				if (Glyf.HasFlag (target, Glyf.CompositeGlyphFlags.WE_HAVE_A_SCALE)) {
					num2 = (num3 = (float) reader.ReadInt16 () / 16384f);
					flag2 = true;
				} else if (Glyf.HasFlag (target, Glyf.CompositeGlyphFlags.WE_HAVE_AN_X_AND_Y_SCALE)) {
					num2 = (float) reader.ReadInt16 () / 16384f;
					num3 = (float) reader.ReadInt16 () / 16384f;
					flag2 = true;
				} else if (Glyf.HasFlag (target, Glyf.CompositeGlyphFlags.WE_HAVE_A_TWO_BY_TWO)) {
					flag = true;
					flag2 = true;
					num2 = (float) reader.ReadInt16 () / 16384f;
					m = (float) reader.ReadInt16 () / 16384f;
					m2 = (float) reader.ReadInt16 () / 16384f;
					num3 = (float) reader.ReadInt16 () / 16384f;
					Glyf.HasFlag (target, Glyf.CompositeGlyphFlags.UNSCALED_COMPONENT_OFFSET);
					Glyf.HasFlag (target, Glyf.CompositeGlyphFlags.USE_MY_METRICS);
				}
				if (Glyf.HasFlag (target, Glyf.CompositeGlyphFlags.ARGS_ARE_XY_VALUES)) {
					if (flag) {
						Glyph.TransformNormalWith2x2Matrix (glyph3, num2, m, m2, num3);
						Glyph.OffsetXY (glyph3, dx, dy);
					} else if (flag2) {
						if ((double) num2 != 1.0 || (double) num3 != 1.0) {
							Glyph.TransformNormalWith2x2Matrix (glyph3, num2, 0f, 0f, num3);
						}
						Glyph.OffsetXY (glyph3, dx, dy);
					} else {
						Glyf.HasFlag (target, Glyf.CompositeGlyphFlags.ROUND_XY_TO_GRID);
						Glyph.OffsetXY (glyph3, dx, dy);
					}
				}
				if (glyph == null) {
					glyph = glyph3;
				} else {
					Glyph.AppendGlyph (glyph, glyph3);
				}
			}
			while (Glyf.HasFlag (target, Glyf.CompositeGlyphFlags.MORE_COMPONENTS));
			Glyf.HasFlag (target, Glyf.CompositeGlyphFlags.WE_HAVE_INSTRUCTIONS);
			return glyph ?? Glyph.Empty;
		}
	}
}