#if graphics && gl && gi
using System;
using System.Collections.Generic;
using System.Text;

namespace Anura.Graphics.Infrastructure.Data {

    /// <summary>
    /// 表示一个 OpenGl 中的颜色，包含 Alpha, R, G, B 四通道
    /// </summary>
    public struct Color {

        /// <summary>
        /// 从红色分量，绿色分量，蓝色分量创建一个完全不透明的颜色
        /// </summary>
        public Color(byte red, byte green, byte blue) {
            this.A = 255;
            this.R = red;
            this.G = green;
            this.B = blue;
        }

        /// <summary>
        /// 从红色分量，绿色分量，蓝色分量，和透明度创建一个颜色
        /// </summary>
        public Color(byte red, byte green, byte blue, byte alpha) {
            this.A = alpha;
            this.R = red;
            this.G = green;
            this.B = blue;
        }

        /// <summary>
        /// 使用 [System.Drawing.Color] 对象创建一个颜色
        /// </summary>
        public Color(System.Drawing.Color color) {
            this.A = color.A;
            this.R = color.R;
            this.G = color.G;
            this.B = color.B;
        }

        /// <summary>
        /// 透明度分量， [0, 255]
        /// </summary>
        public byte A { get; set; }

        /// <summary>
        /// 红色分量， [0, 255]
        /// </summary>
        public byte R { get; set; }

        /// <summary>
        /// 绿色分量， [0, 255]
        /// </summary>
        public byte G { get; set; }

        /// <summary>
        /// 蓝色分量， [0, 255]
        /// </summary>
        public byte B { get; set; }
    }
}
#endif