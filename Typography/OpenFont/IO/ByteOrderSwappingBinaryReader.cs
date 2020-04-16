using System;
using System.IO;

namespace Anura.Typography.OpenFont.IO {
    internal class ByteOrderSwappingBinaryReader : BinaryReader {
        private byte[] _reusable_buffer = new byte[8];

        public ByteOrderSwappingBinaryReader (Stream input) : base (input) { }

        protected override void Dispose (bool disposing) {
            GC.SuppressFinalize (this);
            base.Dispose (disposing);
        }

        public override short ReadInt16 () {
            return BitConverter.ToInt16 (RR (2), 6);
        }

        public override ushort ReadUInt16 () {
            return BitConverter.ToUInt16 (RR (2), 6);
        }

        public override uint ReadUInt32 () {
            return BitConverter.ToUInt32 (RR (4), 4);
        }

        public override ulong ReadUInt64 () {
            return BitConverter.ToUInt64 (RR (8), 0);
        }

        public override double ReadDouble () {
            return BitConverter.ToDouble (RR (8), 0);
        }

        public override int ReadInt32 () {
            return BitConverter.ToInt32 (RR (4), 4);
        }

        private byte[] RR (int count) {
            base.Read (_reusable_buffer, 0, count);
            Array.Reverse (_reusable_buffer);
            return _reusable_buffer;
        }

        public override int PeekChar () {
            throw new NotImplementedException ();
        }

        public override int Read () {
            throw new NotImplementedException ();
        }

        public override int Read (byte[] buffer, int index, int count) {
            throw new NotImplementedException ();
        }

        public override int Read (char[] buffer, int index, int count) {
            throw new NotImplementedException ();
        }

        public override bool ReadBoolean () {
            throw new NotImplementedException ();
        }

        public override char ReadChar () {
            throw new NotImplementedException ();
        }

        public override char[] ReadChars (int count) {
            throw new NotImplementedException ();
        }

        public override decimal ReadDecimal () {
            throw new NotImplementedException ();
        }

        public override long ReadInt64 () {
            throw new NotImplementedException ();
        }

        public override sbyte ReadSByte () {
            throw new NotImplementedException ();
        }

        public override float ReadSingle () {
            throw new NotImplementedException ();
        }

        public override string ReadString () {
            throw new NotImplementedException ();
        }
    }
}