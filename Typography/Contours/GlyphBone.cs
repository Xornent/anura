using System;
using System.Numerics;

namespace Anura.Typography.Contours {
    public class GlyphBone {
        public readonly GlyphBoneJoint JointA;

        public readonly GlyphBoneJoint JointB;

        public readonly EdgeLine TipEdge;

        private double _len;

        public bool IsTipBone => TipEdge != null;

        public LineSlopeKind SlopeKind {
            get;
            private set;
        }

        internal double Length => _len;

        public bool IsLongBone {
            get;
            internal set;
        }

        public GlyphBone (GlyphBoneJoint a, GlyphBoneJoint b) {
            JointA = a;
            JointB = b;
            Vector2 originalJointPos = b.OriginalJointPos;
            _len = Math.Sqrt (a.CalculateSqrDistance (originalJointPos));
            EvaluateSlope ();
        }

        public GlyphBone (GlyphBoneJoint a, EdgeLine tipEdge) {
            JointA = a;
            TipEdge = tipEdge;
            Vector2 midPoint = tipEdge.GetMidPoint ();
            _len = Math.Sqrt (a.CalculateSqrDistance (midPoint));
            EvaluateSlope ();
        }

        public Vector2 GetVector () {
            if (JointB != null) {
                return JointB.OriginalJointPos - JointA.OriginalJointPos;
            }
            if (TipEdge != null) {
                return TipEdge.GetMidPoint () - JointA.OriginalJointPos;
            }
            throw new NotSupportedException ();
        }

        internal void EvaluateSlope () {
            if (JointB != null) {
                EvaluateSlope (JointA.DynamicFitPos, JointB.DynamicFitPos);
            } else {
                EvaluateSlope (JointA.DynamicFitPos, TipEdge.GetMidPoint ());
            }
        }

        internal float EvaluateFitLength () {
            if (JointB != null) {
                return (JointA.DynamicFitPos - JointB.DynamicFitPos).Length ();
            }
            return (JointA.DynamicFitPos - TipEdge.GetMidPoint ()).Length ();
        }

        internal float EvaluateY () {
            if (JointB != null) {
                return (JointA.DynamicFitPos.Y + JointB.DynamicFitPos.Y) / 2f;
            }
            return (JointA.DynamicFitPos.Y + TipEdge.GetMidPoint ().Y) / 2f;
        }

        private void EvaluateSlope (Vector2 p, Vector2 q) {
            double num = p.X;
            double num2 = p.Y;
            double num3 = q.X;
            double num4 = Math.Abs (Math.Atan2 (Math.Abs ((double) q.Y - num2), Math.Abs (num3 - num)));
            if (num3 == num) {
                SlopeKind = LineSlopeKind.Vertical;
            } else if (num4 > MyMath._85degreeToRad) {
                SlopeKind = LineSlopeKind.Vertical;
            } else if (num4 < MyMath._03degreeToRad) {
                SlopeKind = LineSlopeKind.Horizontal;
            } else {
                SlopeKind = LineSlopeKind.Other;
            }
        }
    }
}