using System;
using System.IO;
using System.Text;

namespace Anura.Typography.OpenFont {
    internal static class Utils {
        public static Bounds ReadBounds (BinaryReader input) {
            short xmin = input.ReadInt16 ();
            short ymin = input.ReadInt16 ();
            short xmax = input.ReadInt16 ();
            short ymax = input.ReadInt16 ();
            return new Bounds (xmin, ymin, xmax, ymax);
        }

        public static string TagToString (uint tag) {
            byte[] bytes = BitConverter.GetBytes (tag);
            Array.Reverse (bytes);
            return Encoding.UTF8.GetString (bytes, 0, bytes.Length);
        }

        public static int ReadUInt24 (BinaryReader reader) {
            return (reader.ReadByte () << 16) | reader.ReadUInt16 ();
        }

        public static ushort[] ReadUInt16Array (BinaryReader reader, int nRecords) {
            ushort[] array = new ushort[nRecords];
            for (int i = 0; i < nRecords; i++) {
                array[i] = reader.ReadUInt16 ();
            }
            return array;
        }

        public static uint[] ReadUInt16ArrayAsUInt32Array (BinaryReader reader, int nRecords) {
            uint[] array = new uint[nRecords];
            for (int i = 0; i < nRecords; i++) {
                array[i] = reader.ReadUInt16 ();
            }
            return array;
        }

        public static uint[] ReadUInt32Array (BinaryReader reader, int nRecords) {
            uint[] array = new uint[nRecords];
            for (int i = 0; i < nRecords; i++) {
                array[i] = reader.ReadUInt32 ();
            }
            return array;
        }

        public static T[] CloneArray<T> (T[] original, int newArrLenExtend = 0) {
            int num = original.Length;
            T[] array = new T[num + newArrLenExtend];
            Array.Copy (original, array, num);
            return array;
        }

        public static T[] ConcatArray<T> (T[] arr1, T[] arr2) {
            T[] array = new T[arr1.Length + arr2.Length];
            Array.Copy (arr1, 0, array, 0, arr1.Length);
            Array.Copy (arr2, 0, array, arr1.Length, arr2.Length);
            return array;
        }

        public static void WarnUnimplemented (string format, params object[] args) { }

        internal static void WarnUnimplementedCollectAssocGlyphs (string msg) { }
    }
}