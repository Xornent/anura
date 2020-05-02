namespace Anura.Typography.Contours {
    public abstract class GlyphOutlineWalker {
        public bool WalkTrianglesAndEdges {
            get;
            set;
        }

        public bool WalkCentroidBone {
            get;
            set;
        }

        public bool WalkGlyphBone {
            get;
            set;
        }

        public GlyphOutlineWalker () {
            bool flag2 = WalkGlyphBone = true;
            bool walkTrianglesAndEdges = WalkCentroidBone = flag2;
            WalkTrianglesAndEdges = walkTrianglesAndEdges;
        }

        public void Walk (GlyphDynamicOutline dynamicOutline) { }
        private void DrawBoneLinks (CentroidLine line) { }
    }
}