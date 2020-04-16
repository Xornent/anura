namespace Anura.Typography.TextLayout {
    public interface IUnscaledGlyphPlanList {
        int Count {
            get;
        }

        UnscaledGlyphPlan this [int index] {
            get;
        }

        void Append (UnscaledGlyphPlan glyphPlan);
    }
}