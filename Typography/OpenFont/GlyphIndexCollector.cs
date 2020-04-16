using System.Collections.Generic;

namespace Anura.Typography.OpenFont {
    public class GlyphIndexCollector {
        private Dictionary<int, List<ushort>> _registerSegments = new Dictionary<int, List<ushort>> ();

        public bool HasRegisterSegment (int segmentNumber) {
            return _registerSegments.ContainsKey (segmentNumber);
        }

        public void RegisterGlyphRangeIndex (int segmentNumber, List<ushort> glyphIndexList) {
            _registerSegments.Add (segmentNumber, glyphIndexList);
        }

        public IEnumerable<ushort> GetGlyphIndexIter () {
            foreach (List<ushort> list in _registerSegments.Values) {
                int j = list.Count;
                int num;
                for (int i = 0; i < j; i = num) {
                    yield return list[i];
                    num = i + 1;
                }
            }
        }
    }
}