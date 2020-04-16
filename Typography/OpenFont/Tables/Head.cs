using System;
using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class Head : TableEntry {
        public const string _N = "head";

        private short _indexToLocFormat;

        private Bounds _bounds;

        public override string Name => "head";

        public uint Version {
            get;
            private set;
        }

        public uint FontRevision {
            get;
            private set;
        }

        public uint CheckSumAdjustment {
            get;
            private set;
        }

        public uint MagicNumber {
            get;
            private set;
        }

        public ushort Flags {
            get;
            private set;
        }

        public ushort UnitsPerEm {
            get;
            private set;
        }

        public ulong Created {
            get;
            private set;
        }

        public ulong Modified {
            get;
            private set;
        }

        public Bounds Bounds => _bounds;

        public ushort MacStyle {
            get;
            private set;
        }

        public ushort LowestRecPPEM {
            get;
            private set;
        }

        public short FontDirectionHint {
            get;
            private set;
        }

        public bool WideGlyphLocations => _indexToLocFormat > 0;

        public short GlyphDataFormat {
            get;
            private set;
        }

        protected override void ReadContentFrom (BinaryReader input) {
            Version = input.ReadUInt32 ();
            FontRevision = input.ReadUInt32 ();
            CheckSumAdjustment = input.ReadUInt32 ();
            MagicNumber = input.ReadUInt32 ();
            if (MagicNumber != 1594834165) {
                throw new Exception ("Invalid magic number!" + MagicNumber.ToString ("x"));
            }
            Flags = input.ReadUInt16 ();
            UnitsPerEm = input.ReadUInt16 ();
            Created = input.ReadUInt64 ();
            Modified = input.ReadUInt64 ();
            _bounds = Utils.ReadBounds (input);
            MacStyle = input.ReadUInt16 ();
            LowestRecPPEM = input.ReadUInt16 ();
            FontDirectionHint = input.ReadInt16 ();
            _indexToLocFormat = input.ReadInt16 ();
            GlyphDataFormat = input.ReadInt16 ();
        }
    }
}