using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.Direct3D11;
using SharpDX.Direct2D1.Effects;
using SharpDX.WIC;
using WIC = SharpDX.WIC;
using DW = SharpDX.DirectWrite;
using D2D1 = SharpDX.Direct2D1;
using SharpDX.Mathematics.Interop;
using D3D11 = SharpDX.Direct3D11;
using DXGI = SharpDX.DXGI;
using SharpDX.DXGI;

namespace Anura.Windows {
    public static class Graphics {

        /// <summary>
        /// 向指定的 Direct2D.GeometrySink 图形对象中追加一段圆角矩形的路径
        /// </summary>
        /// <param name="sinkAddress">需要追加的 GeometrySink 对象</param>
        /// <param name="left">圆角矩形左侧的坐标</param>
        /// <param name="top">圆角矩形顶端的坐标</param>
        /// <param name="width">宽度</param>
        /// <param name="height">高度</param>
        /// <param name="radius">圆角半径，值不应超过 Min(width, height)/2 大小.</param>
        public static void RoundedRectanglePath (D2D1.GeometrySink sinkAddress, int left, int top, int width, int height, int radius){
            sinkAddress.BeginFigure (new RawVector2 (left, top), D2D1.FigureBegin.Filled);
            sinkAddress.AddArc (new D2D1.ArcSegment () {
                ArcSize = D2D1.ArcSize.Small,
                    SweepDirection = D2D1.SweepDirection.Clockwise,
                    Point = new RawVector2 (left + radius, top),
                    RotationAngle = 90,
                    Size = new Size2F (radius, radius)
            });
            sinkAddress.AddLine (new RawVector2 (left+width-radius, 8));
            sinkAddress.AddArc (new D2D1.ArcSegment () {
                ArcSize = D2D1.ArcSize.Small,
                    SweepDirection = D2D1.SweepDirection.Clockwise,
                    Point = new RawVector2 (left+width, top+radius),
                    RotationAngle = 90,
                    Size = new Size2F (radius,radius)
            });
            sinkAddress.AddLine (new RawVector2 (left+width, top+height-radius));
            sinkAddress.AddArc(new D2D1.ArcSegment()
            {
                ArcSize = D2D1.ArcSize.Small,
                SweepDirection = D2D1.SweepDirection.Clockwise,
                Point = new RawVector2(left + width - radius, top + height),
                RotationAngle = 90,
                Size = new Size2F(radius, radius)
            });
            sinkAddress.AddLine (new RawVector2 (left+radius, top+height));
            sinkAddress.AddArc (new D2D1.ArcSegment () {
                ArcSize = D2D1.ArcSize.Small,
                    SweepDirection = D2D1.SweepDirection.Clockwise,
                    Point = new RawVector2 (left, top+height-radius),
                    RotationAngle = 90,
                    Size = new Size2F (radius,radius)
            });
            sinkAddress.EndFigure (D2D1.FigureEnd.Closed);
            sinkAddress.Close ();
        }
    }
}