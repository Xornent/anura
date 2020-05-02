namespace Anura.Typography.Contours {
    public class InsideEdgeLine : EdgeLine {
        internal GlyphBoneJoint inside_joint;

        public override bool IsOutside => false;

        internal InsideEdgeLine (GlyphTriangle ownerTriangle, GlyphPoint p, GlyphPoint q) : base (ownerTriangle, p, q) { }
    }
}