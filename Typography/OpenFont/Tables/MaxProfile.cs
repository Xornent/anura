using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class MaxProfile : TableEntry {
        public const string _N = "maxp";

        public override string Name => "maxp";

        public uint Version {
            get;
            private set;
        }

        public ushort GlyphCount {
            get;
            private set;
        }

        public ushort MaxPointsPerGlyph {
            get;
            private set;
        }

        public ushort MaxContoursPerGlyph {
            get;
            private set;
        }

        public ushort MaxPointsPerCompositeGlyph {
            get;
            private set;
        }

        public ushort MaxContoursPerCompositeGlyph {
            get;
            private set;
        }

        public ushort MaxZones {
            get;
            private set;
        }

        public ushort MaxTwilightPoints {
            get;
            private set;
        }

        public ushort MaxStorage {
            get;
            private set;
        }

        public ushort MaxFunctionDefs {
            get;
            private set;
        }

        public ushort MaxInstructionDefs {
            get;
            private set;
        }

        public ushort MaxStackElements {
            get;
            private set;
        }

        public ushort MaxSizeOfInstructions {
            get;
            private set;
        }

        public ushort MaxComponentElements {
            get;
            private set;
        }

        public ushort MaxComponentDepth {
            get;
            private set;
        }

        protected override void ReadContentFrom (BinaryReader input) {
            Version = input.ReadUInt32 ();
            GlyphCount = input.ReadUInt16 ();
            MaxPointsPerGlyph = input.ReadUInt16 ();
            MaxContoursPerGlyph = input.ReadUInt16 ();
            MaxPointsPerCompositeGlyph = input.ReadUInt16 ();
            MaxContoursPerCompositeGlyph = input.ReadUInt16 ();
            MaxZones = input.ReadUInt16 ();
            MaxTwilightPoints = input.ReadUInt16 ();
            MaxStorage = input.ReadUInt16 ();
            MaxFunctionDefs = input.ReadUInt16 ();
            MaxInstructionDefs = input.ReadUInt16 ();
            MaxStackElements = input.ReadUInt16 ();
            MaxSizeOfInstructions = input.ReadUInt16 ();
            MaxComponentElements = input.ReadUInt16 ();
            MaxComponentDepth = input.ReadUInt16 ();
        }
    }
}