#if graphics && gl && windows && gi
using System;
using System.Runtime.InteropServices;
using Anura.Graphics.Windows;
using static Anura.Graphics.Windows.Win32;
using Anura.Graphics.Gl;

namespace Anura.Graphics.Infrastructure {

    /// <summary>
    /// 使用 Windows 的窗口句柄创建一个只适用于 Windows 操作系统的渲染对象
    /// </summary>
    public class WindowsRenderTarget : RenderTarget {

        /// <summary>
        /// 显示器句柄
        /// </summary>
        public IntPtr DcHandle { get; private set; } = IntPtr.Zero;

        /// <summary>
        /// 从 Windows 的窗口句柄初始化一个渲染目标
        /// </summary>
        /// <param name="handle">需要绘制的窗口句柄</param>
        public unsafe WindowsRenderTarget (IntPtr handle, ContextGenerationParams parameters) : base () {
            IntPtr hDC = Win32.GetDC (handle);
            DcHandle = hDC;
            WindowHandle = handle;

            Win32.PixelFormatDescriptor pxDesc = new Win32.PixelFormatDescriptor ();
            pxDesc.nSize = 40;
            pxDesc.nVersion = 1;
            pxDesc.dwFlags = Win32.PFD_DRAW_TO_WINDOW | Win32.PFD_SUPPORT_OPENGL | Win32.PFD_DOUBLEBUFFER;
            pxDesc.iPixelType = (byte) Win32.PFD_TYPE_RGBA;
            pxDesc.cColorBits = 32;
            pxDesc.cRedBits = 0;
            pxDesc.cRedShift = 0;
            pxDesc.cGreenBits = 0;
            pxDesc.cGreenShift = 0;
            pxDesc.cBlueBits = 0;
            pxDesc.cBlueShift = 0;
            pxDesc.cAlphaBits = 0;
            pxDesc.cAlphaShift = 0;
            pxDesc.cAccumBits = 0;
            pxDesc.cAccumRedBits = 0;
            pxDesc.cAccumGreenBits = 0;
            pxDesc.cAccumBlueBits = 0;
            pxDesc.cAccumAlphaBits = 0;
            pxDesc.cDepthBits = 16;
            pxDesc.cStencilBits = 0;
            pxDesc.cAuxBuffers = 0;
            pxDesc.iLayerType = (sbyte) Win32.PFD_MAIN_PLANE;
            pxDesc.bReserved = 0;
            pxDesc.dwLayerMask = 0;
            pxDesc.dwVisibleMask = 0;
            pxDesc.dwDamageMask = 0;

            int pixelFormat;
            pixelFormat = Win32.ChoosePixelFormat(hDC, pxDesc);
            Win32.SetPixelFormat(hDC, pixelFormat, pxDesc);

            this.Handle = Win32.wglCreateContext(hDC);
            Win32.wglMakeCurrent(DcHandle, Handle);

            if (parameters.UpdateContextVersion) {
                this.UpdateContextVersion(parameters);
            }
        }

        /// <summary>
        /// 这个函数只有在渲染上下文建立之后调用才是有效的，它尝试将原有的 OpenGl 渲染
        /// 上下文转移到最开始请求的相应版本。 如果这个版本小于 2.1，我们就会创建一个新的渲染对象
        /// 
        /// 对于 OpenGl 3.0 以上的版本，原有的 Windows 是不支持的（Windows 系统原生只提供了最新
        /// OpenGl 1.1 的相应标准），我们需要使用拓展方法 wglCreateContext 来生成渲染对象
        /// </summary>
        /// <param name="parameters"></param>
        protected bool UpdateContextVersion(ContextGenerationParams parameters) {
            try {
                var wglChoosePixelFormatARB = WindowsOpenGl.GetDelegateFor("wglChoosePixelFormatARB", GLDelegates.typeof_bool_IntPtr_intN_floatN_uint_intN_uintN) as GLDelegates.bool_IntPtr_intN_floatN_uint_intN_uintN;
                if (wglChoosePixelFormatARB == null) { return false; }
                var wglCreateContextAttribs = WindowsOpenGl.GetDelegateFor("wglCreateContextAttribsARB", GLDelegates.typeof_IntPtr_IntPtr_IntPtr_intN) as GLDelegates.IntPtr_IntPtr_IntPtr_intN;
                if (wglCreateContextAttribs == null) { return false; }

                int major, minor;
                GetHighestVersion(out major, out minor);
                if ((major > 2) || (major == 2 && minor > 1)) {

                    int[] attribList = new int[]
                    {
                        WGL_SUPPORT_OPENGL_ARB,   (int)Gl.Constants.GL_TRUE,
                        WGL_DRAW_TO_WINDOW_ARB,   (int)Gl.Constants.GL_TRUE,
                        WGL_DOUBLE_BUFFER_ARB,    (int)Gl.Constants.GL_TRUE,
                        WGL_ACCELERATION_ARB,     WGL_FULL_ACCELERATION_ARB,
                        WGL_PIXEL_TYPE_ARB,       WGL_TYPE_RGBA_ARB,
                        WGL_COLOR_BITS_ARB,       parameters.ColorBits,
                        WGL_ACCUM_BITS_ARB,       parameters.AccumBits,
                        WGL_ACCUM_RED_BITS_ARB,   parameters.AccumRedBits,
                        WGL_ACCUM_GREEN_BITS_ARB, parameters.AccumGreenBits,
                        WGL_ACCUM_BLUE_BITS_ARB,  parameters.AccumBlueBits,
                        WGL_ACCUM_ALPHA_BITS_ARB, parameters.AccumAlphaBits,
                        WGL_DEPTH_BITS_ARB,       parameters.DepthBits,
                        WGL_STENCIL_BITS_ARB,     parameters.StencilBits,
                        0,
                    };

                    IntPtr dc = this.DcHandle;
                    int[] pixelFormat = new int[1];
                    uint[] numFormats = new uint[1];
                    if (false == wglChoosePixelFormatARB(dc, attribList, null, 1, pixelFormat, numFormats)) { return false; }
                    if (false == Win32.SetPixelFormat(dc, pixelFormat[0], new PixelFormatDescriptor())) {
                        return false;
                    }

                    int[] attributes =
                    {
                        WGL_CONTEXT_MAJOR_VERSION_ARB,
                        major,
                        WGL_CONTEXT_MINOR_VERSION_ARB,
                        minor,
                        WGL_CONTEXT_PROFILE_MASK_ARB,
                        WGL_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB,
                        0
                    };
                    IntPtr hrc = wglCreateContextAttribs(dc, IntPtr.Zero, attributes);
                    Win32.wglMakeCurrent(IntPtr.Zero, IntPtr.Zero);
                    Win32.wglDeleteContext(this.Handle);
                    Win32.wglMakeCurrent(dc, hrc);
                    this.Handle = hrc;
                }
            } catch { }

            return true;
        }

        private void GetHighestVersion(out int major, out int minor) {
            major = 2; minor = 1;
            try {
                string version = Gl.Current.Instance.GetString(Gl.Constants.GL_VERSION);
                string[] parts = version.Split('.');
                major = int.Parse(parts[0]);
                minor = int.Parse(parts[1]);
            } catch { }
        }

        /// <summary>
        /// 销毁非托管对象
        /// </summary>
        protected void Dispose() {
            Win32.ReleaseDC(WindowHandle, this.DcHandle);

            if (this.Handle != IntPtr.Zero) {
                Win32.wglDeleteContext(this.Handle);
                this.Handle = IntPtr.Zero;
            }
        }

        /// <summary>
        /// 窗口句柄
        /// </summary>
        protected IntPtr WindowHandle = IntPtr.Zero;

        internal const int WGL_CONTEXT_DEBUG_BIT_ARB = 0x0001;
        internal const int WGL_CONTEXT_FORWARD_COMPATIBLE_BIT_ARB = 0x0002;
        internal const int WGL_CONTEXT_CORE_PROFILE_BIT_ARB = 0x00000001;
        internal const int WGL_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB = 0x00000002;
        internal const int WGL_DRAW_TO_WINDOW_ARB = 0x2001;
        internal const int WGL_ACCELERATION_ARB = 0x2003;
        internal const int WGL_SWAP_METHOD_ARB = 0x2007;
        internal const int WGL_SUPPORT_OPENGL_ARB = 0x2010;
        internal const int WGL_DOUBLE_BUFFER_ARB = 0x2011;
        internal const int WGL_PIXEL_TYPE_ARB = 0x2013;
        internal const int WGL_COLOR_BITS_ARB = 0x2014;
        internal const int WGL_RED_BITS_ARB = 0x2015;
        internal const int WGL_GREEN_BITS_ARB = 0x2017;
        internal const int WGL_BLUE_BITS_ARB = 0x2019;
        internal const int WGL_ALPHA_BITS_ARB = 0x201B;
        internal const int WGL_ACCUM_BITS_ARB = 0x201D;
        internal const int WGL_ACCUM_RED_BITS_ARB = 0x201E;
        internal const int WGL_ACCUM_GREEN_BITS_ARB = 0x201F;
        internal const int WGL_ACCUM_BLUE_BITS_ARB = 0x2020;
        internal const int WGL_ACCUM_ALPHA_BITS_ARB = 0x2021;
        internal const int WGL_DEPTH_BITS_ARB = 0x2022;
        internal const int WGL_STENCIL_BITS_ARB = 0x2023;
        internal const int WGL_AUX_BUFFERS_ARB = 0x2024;
        internal const int WGL_FULL_ACCELERATION_ARB = 0x2027;
        internal const int WGL_SWAP_EXCHANGE_ARB = 0x2028;
        internal const int WGL_TYPE_RGBA_ARB = 0x202B;
        internal const int WGL_CONTEXT_MAJOR_VERSION_ARB = 0x2091;
        internal const int WGL_CONTEXT_MINOR_VERSION_ARB = 0x2092;
        internal const int WGL_CONTEXT_LAYER_PLANE_ARB = 0x2093;
        internal const int WGL_CONTEXT_FLAGS_ARB = 0x2094;
        internal const int ERROR_INVALID_VERSION = 0x2095;
        internal const int ERROR_INVALID_PROFILE = 0x2096;
        internal const int WGL_CONTEXT_PROFILE_MASK_ARB = 0x9126;
    }

    /// <summary>
    /// OpenGl 渲染上下文参数
    /// </summary>
    public class ContextGenerationParams {

        private byte colorBits = 32;
        public byte ColorBits {
            get { return colorBits; }
            set { colorBits = value; }
        }

        private byte accumBits = 0;
        public byte AccumBits {
            get { return accumBits; }
            set { accumBits = value; }
        }
        private byte accumRedBits = 0;
        public byte AccumRedBits {
            get { return accumRedBits; }
            set { accumRedBits = value; }
        }
        private byte accumGreenBits = 0;
        public byte AccumGreenBits {
            get { return accumGreenBits; }
            set { accumGreenBits = value; }
        }
        private byte accumBlueBits = 0;
        public byte AccumBlueBits {
            get { return accumBlueBits; }
            set { accumBlueBits = value; }
        }
        private byte accumAlphaBits = 0;
        public byte AccumAlphaBits {
            get { return accumAlphaBits; }
            set { accumAlphaBits = value; }
        }

        private byte depthBits = 24;
        public byte DepthBits {
            get { return depthBits; }
            set { depthBits = value; }
        }

        private bool updateContextVersion = true;
        public bool UpdateContextVersion {
            get { return updateContextVersion; }
            set { updateContextVersion = value; }
        }

        private byte stencilBits = 0;
        public byte StencilBits {
            get { return stencilBits; }
            set { stencilBits = value; }
        }
    }
}
#endif