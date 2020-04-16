using System.Collections.Generic;
using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class HorizontalMetrics : TableEntry {
        public const string _N = "hmtx";

        private List<ushort> _advanceWidths;

        private List<short> _leftSideBearings;

        private int _numOfHMetrics;

        private int _numGlyphs;

        public override string Name => "hmtx";

        public HorizontalMetrics (ushort numOfHMetrics, ushort numGlyphs) {
            _advanceWidths = new List<ushort> (numGlyphs);
            _leftSideBearings = new List<short> (numGlyphs);
            _numOfHMetrics = numOfHMetrics;
            _numGlyphs = numGlyphs;
        }

        public ushort GetAdvanceWidth (int index) {
            return _advanceWidths[index];
        }

        public short GetLeftSideBearing (int index) {
            return _leftSideBearings[index];
        }

        public void GetHMatric (int index, out ushort advWidth, out short lsb) {
            advWidth = _advanceWidths[index];
            lsb = _leftSideBearings[index];
        }

        protected override void ReadContentFrom (BinaryReader input) {
            int numOfHMetrics = _numOfHMetrics;
            for (int i = 0; i < numOfHMetrics; i++) {
                _advanceWidths.Add (input.ReadUInt16 ());
                _leftSideBearings.Add (input.ReadInt16 ());
            }
            int num = _numGlyphs - numOfHMetrics;
            ushort item = _advanceWidths[numOfHMetrics - 1];
            for (int j = 0; j < num; j++) {
                _advanceWidths.Add (item);
                _leftSideBearings.Add (input.ReadInt16 ());
            }
        }
    }
}