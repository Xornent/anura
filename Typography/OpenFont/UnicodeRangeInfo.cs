namespace Anura.Typography.OpenFont {
    public struct UnicodeRangeInfo {
        public readonly int BitNo;

        public readonly int StartAt;

        public readonly int EndAt;

        public UnicodeRangeInfo (int bitNo, int startAt, int endAt) {
            BitNo = bitNo;
            StartAt = startAt;
            EndAt = endAt;
        }

        public bool IsInRange (int value) {
            if (value >= StartAt) {
                return value <= EndAt;
            }
            return false;
        }
    }
}