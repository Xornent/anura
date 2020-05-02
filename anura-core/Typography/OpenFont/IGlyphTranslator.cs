namespace Anura.Typography.OpenFont {
    public interface IGlyphTranslator {
        void BeginRead (int contourCount);

        void EndRead ();

        void MoveTo (float x0, float y0);

        void LineTo (float x1, float y1);

        void Curve3 (float x1, float y1, float x2, float y2);

        void Curve4 (float x1, float y1, float x2, float y2, float x3, float y3);

        void CloseContour ();
    }
}