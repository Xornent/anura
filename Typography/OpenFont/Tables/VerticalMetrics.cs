using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class VerticalMetrics : TableEntry {
        public struct AdvanceHeightAndTopSideBearing {
            public readonly ushort advanceHeight;

            public readonly short topSideBearing;

            public AdvanceHeightAndTopSideBearing (ushort advanceHeight, short topSideBearing) {
                this.advanceHeight = advanceHeight;
                this.topSideBearing = topSideBearing;
            }
        }

        public const string _N = "vmtx";

        private ushort _numOfLongVerMetrics;

        private AdvanceHeightAndTopSideBearing[] _advHeightAndTopSideBearings;

        public override string Name => "vmtx";

        public VerticalMetrics (ushort numOfLongVerMetrics) {
            _numOfLongVerMetrics = numOfLongVerMetrics;
        }

        protected override void ReadContentFrom (BinaryReader reader) {
            _advHeightAndTopSideBearings = new AdvanceHeightAndTopSideBearing[_numOfLongVerMetrics];
            int num = 0;
            for (int num2 = _numOfLongVerMetrics - 1; num2 >= 0; num2--) {
                _advHeightAndTopSideBearings[num] = new AdvanceHeightAndTopSideBearing (reader.ReadUInt16 (), reader.ReadInt16 ());
            }
        }
    }
}