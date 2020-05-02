using System.Collections.Generic;

namespace Anura.Typography.TextLayout {
    public class UnscaledGlyphPlanList : IUnscaledGlyphPlanList {
        private List<UnscaledGlyphPlan> _list = new List<UnscaledGlyphPlan> ();

        private float _accumAdvanceX;

        public int Count => _list.Count;

        public UnscaledGlyphPlan this [int index] {
            get {
                return _list[index];
            }
        }

        public float AccumAdvanceX => _accumAdvanceX;

        public void Clear () {
            _list.Clear ();
            _accumAdvanceX = 0f;
        }

        public void Append (UnscaledGlyphPlan glyphPlan) {
            _list.Add (glyphPlan);
            _accumAdvanceX += glyphPlan.AdvanceX;
        }
    }
}