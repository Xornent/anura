using System;
using System.Text;

namespace Anura.Typography.Triangulation {
    internal class AdvancingFront {
        public readonly AdvancingFrontNode Head;

        public readonly AdvancingFrontNode Tail;

        private AdvancingFrontNode _search;

        public AdvancingFront (AdvancingFrontNode head, AdvancingFrontNode tail) {
            Head = head;
            Tail = tail;
            _search = head;
        }

        public override string ToString () {
            StringBuilder stringBuilder = new StringBuilder ();
            for (AdvancingFrontNode advancingFrontNode = Head; advancingFrontNode != Tail; advancingFrontNode = advancingFrontNode.Next) {
                stringBuilder.Append (advancingFrontNode.Point.X).Append ("->");
            }
            stringBuilder.Append (Tail.Point.X);
            return stringBuilder.ToString ();
        }

        public AdvancingFrontNode LocateNode (TriangulationPoint point) {
            return LocateNode (point.X);
        }

        private AdvancingFrontNode LocateNode (double x) {
            AdvancingFrontNode advancingFrontNode = _search;
            if (x < advancingFrontNode.XValue) {
                while ((advancingFrontNode = advancingFrontNode.Prev) != null) {
                    if (x >= advancingFrontNode.XValue) {
                        _search = advancingFrontNode;
                        return advancingFrontNode;
                    }
                }
            } else {
                while ((advancingFrontNode = advancingFrontNode.Next) != null) {
                    if (x < advancingFrontNode.XValue) {
                        _search = advancingFrontNode.Prev;
                        return advancingFrontNode.Prev;
                    }
                }
            }
            return null;
        }

        public AdvancingFrontNode LocatePoint (TriangulationPoint point) {
            double x = point.X;
            AdvancingFrontNode advancingFrontNode = _search;
            double x2 = advancingFrontNode.Point.X;
            if (x == x2) {
                if (point != advancingFrontNode.Point) {
                    if (point == advancingFrontNode.Prev.Point) {
                        advancingFrontNode = advancingFrontNode.Prev;
                    } else {
                        if (point != advancingFrontNode.Next.Point) {
                            throw new Exception ("Failed to find Node for given afront point");
                        }
                        advancingFrontNode = advancingFrontNode.Next;
                    }
                }
            } else if (x < x2) {
                while ((advancingFrontNode = advancingFrontNode.Prev) != null && point != advancingFrontNode.Point) { }
            } else {
                while ((advancingFrontNode = advancingFrontNode.Next) != null && point != advancingFrontNode.Point) { }
            }
            _search = advancingFrontNode;
            return advancingFrontNode;
        }
    }
}