#if graphics && gl && gi
using Anura.Graphics.Gl;
using Anura.Graphics.Infrastructure.Data;
using System;
using System.Runtime.InteropServices;

namespace Anura.Graphics.Infrastructure {
    
    /// <summary>
    /// 表示一个可以调用 OpenGL 引擎绘图的表面，每个 `RenderTarget` 都有一个特异的
    /// OpenGL 句柄。 这个类是许多不同系统上 `RenderTarget` 实现的基类
    /// </summary>
    public class RenderTarget {
        
        /// <summary>
        /// 没有初始化参数的默认方法，用此方法初始的对象不能直接使用，保留此方法的目的只是为
        /// 系统兼容性考虑。
        /// </summary>
        public RenderTarget() { }

        /// <summary>
        /// OpenGl 渲染目标句柄
        /// </summary>
        public IntPtr Handle = IntPtr.Zero;

        /// <summary>
        /// 使用指定的颜色清空屏幕
        /// </summary>
        public void Clear(Color background) {
            var gl = Current.Instance;
            if (gl == null) throw new Exceptions.GraphicSystemIncompatibleException();

            gl.ClearColor(background.R / 255f, background.G / 255f, background.B / 255f, background.A / 255f);
            gl.Clear(Constants.GL_COLOR_BUFFER_BIT);
        }

        /// <summary>
        /// 结束绘制并将所有绘图步骤加以执行
        /// </summary>
        public void End() {
            var gl = Current.Instance;
            if (gl == null) throw new Exceptions.GraphicSystemIncompatibleException();

            gl.Flush();
            gl.Finish();
        }
    }
}
#endif