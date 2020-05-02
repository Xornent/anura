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
    public class Render : System.Windows.Forms.Form {
        public Render () {
            InitializeComponent ();
            InitializeDeviceResources ();
            LoadResources();
            this.Resize += ResizeDevices;
            renderLoop.Interval = 20;
            renderLoop.Tick += RenderLoop;
            renderLoop.Enabled = true;
            gradAnimator.Interval = 15;
            gradAnimator.Tick += AnimatorTick;
            gradAnimator.Enabled = true;
            this.FormClosed += CloseApplication;
            this.MouseMove += RenderMouseMove;
            this.GradientAnimations.Add (new AnimationNumber (true, 1, 4, 0.85f, 1));
        }

        public void RenderLoop (object sender, EventArgs e) {
            if (this.WindowState != FormWindowState.Minimized) Draw ();
        }

        public void Draw () {
            System.Diagnostics.Stopwatch stop = new System.Diagnostics.Stopwatch ();
            stop.Start ();
            deviceContext.AntialiasMode = AntialiasMode.PerPrimitive;
            deviceContext.TextAntialiasMode = TextAntialiasMode.Cleartype;
            deviceContext.BeginDraw ();

            // TODO: 绘制主循环
            deviceContext.Clear (ColorToRaw4 (Color.White));
            SolidColorBrush fontBrush = new SolidColorBrush (deviceContext, ColorToRaw4 (Color.Red));

            // Initialization
            var lightGrayBrush = new D2D1.SolidColorBrush (deviceContext, new RawColor4 (0.9f, 0.9f, 0.9f, 0.8f));
            var uiShadow = new D2D1.SolidColorBrush (deviceContext, new RawColor4 (0.5f, 0.5f, 0.5f, 0.5f));
            var uiLight = new D2D1.SolidColorBrush (deviceContext, new RawColor4 (GradientAnimations[0].value, GradientAnimations[0].value, GradientAnimations[0].value, 1));
            // Initialize Drawer of Top Address Bar
            var pathAddress = new D2D1.PathGeometry (deviceContext.Factory);
            var sinkAddress = pathAddress.Open ();
            int position = (this.Width / 2) - 225;
            Graphics.RoundedRectanglePath(sinkAddress, position, 8, 450, 22, 3);

            for (int i = 0; i < 1; i++) {
                deviceContext.DrawBitmap((D2D1.Bitmap) Resources[0], new RawRectangleF(0, 0, 600, 450), 1, D2D1.BitmapInterpolationMode.NearestNeighbor);
                deviceContext.DrawImage((D2D1.Effect)Resources[1], new RawVector2(0, 0));
                deviceContext.FillRectangle (new RawRectangleF (0, 0, this.Width, 68), lightGrayBrush);
                deviceContext.DrawRoundedRectangle (new D2D1.RoundedRectangle () {
                    Rect = new RawRectangleF (position + 0.8f, 9.1f, position + 450.8f, 31.8f),
                        RadiusX = 3,
                        RadiusY = 3
                }, uiShadow);
                deviceContext.FillGeometry (pathAddress, uiLight);
            }

            if (pathAddress.FillContainsPoint (mouse)) {
                GradientAnimations[0].upper = false;
            } else {
                GradientAnimations[0].upper = true;
            }

            deviceContext.DrawText ("Current FPS: " + (float) 1 / (elapsed / 1000f) + " F (Elapse " + elapsed + ")",
                new DW.TextFormat (dwFactory, "PingFang SC Regular", 13), new RawRectangleF (0, 0, 1000, 50), fontBrush);

            long tag1, tag2;
            deviceContext.TryEndDraw (out tag1, out tag2);

            // TODO: 销毁 COM 对象
            uiLight.Dispose ();
            uiShadow.Dispose ();
            lightGrayBrush.Dispose ();
            fontBrush.Dispose ();
            sinkAddress.Dispose ();
            pathAddress.Dispose ();

            RawColor4 ColorToRaw4 (Color color) {
                const float n = 255f;
                return new RawColor4 (color.R / n, color.G / n, color.B / n, color.A / n);
            }

            swapChain.Present (1, PresentFlags.None);
            stop.Stop ();
            elapsed = stop.ElapsedMilliseconds;
        }

        D2D1.DeviceContext deviceContext = null;
        DXGI.Surface backBuffer = null;
        D2D1.Bitmap targetBitmap = null;
        D2D1.Bitmap contentBitmap = null;
        D2D1.Bitmap contentBitmapBlur = null;
        D3D11.Device d3DDevice = null;
        DXGI.Device dxgiDevice = null;
        D2D1.Device d2DDevice = null;
        DXGI.SwapChain swapChain = null;
        DW.Factory dwFactory = null;
        WIC.ImagingFactory imgFactory = null;
        Timer renderLoop = new Timer ();
        Timer gradAnimator = new Timer ();
        List<object> Resources = new List<object>();
        long elapsed = 1;

        private const int DisplayWidth = 1280;
        private const int DisplayHeight = 720;

        protected override void Dispose (bool disposing) {
            this.d2DDevice.Dispose ();
            this.d3DDevice.Dispose ();
            this.dxgiDevice.Dispose ();
            this.deviceContext.Dispose ();
            this.swapChain.Dispose ();
            this.targetBitmap.Dispose ();
        }

        private void InitializeComponent () {
            this.WindowState = FormWindowState.Normal;
            this.Text = "Anura";
            this.Size = new Size (DisplayWidth, DisplayHeight);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeDeviceResources () {
            this.dwFactory = new DW.Factory ();
            // 创建 Dierect3D 设备。
            this.d3DDevice = new D3D11.Device (SharpDX.Direct3D.DriverType.Hardware, DeviceCreationFlags.BgraSupport);
            this.dxgiDevice = d3DDevice.QueryInterface<D3D11.Device1> ().QueryInterface<DXGI.Device> ();
            // 创建 Direct2D 设备和工厂。
            this.d2DDevice = new D2D1.Device (dxgiDevice);
            this.deviceContext = new D2D1.DeviceContext (d2DDevice, DeviceContextOptions.None);
            Format format = Format.B8G8R8A8_UNorm;

            // 创建 DXGI SwapChain。
            SwapChainDescription swapChainDesc = new SwapChainDescription () {
                BufferCount = 1,
                Usage = Usage.RenderTargetOutput,
                OutputHandle = this.Handle,
                IsWindowed = true,
                // 这里宽度和高度都是 0，表示自动获取。
                ModeDescription = new ModeDescription (0, 0, new Rational (60, 1), format),
                SampleDescription = new SampleDescription (1, 0),
                SwapEffect = SwapEffect.Discard
            };
            this.swapChain = new SwapChain (dxgiDevice.GetParent<Adapter> ().GetParent<DXGI.Factory> (),
                d3DDevice, swapChainDesc);
            // 创建 BackBuffer。
            this.backBuffer = Surface.FromSwapChain (this.swapChain, 0);
            // 从 BackBuffer 创建 DeviceContext 可用的目标。
            this.targetBitmap = new Bitmap1 (this.deviceContext, backBuffer);
            this.deviceContext.Target = targetBitmap;
        }

        public void ResizeDevices (object sender, EventArgs e) {
            this.d2DDevice.Dispose ();
            this.d3DDevice.Dispose ();
            this.dxgiDevice.Dispose ();
            this.deviceContext.Dispose ();
            this.targetBitmap.Dispose ();

            // 创建 Dierect3D 设备。
            this.d3DDevice = new D3D11.Device (SharpDX.Direct3D.DriverType.Hardware, DeviceCreationFlags.BgraSupport);
            this.dxgiDevice = d3DDevice.QueryInterface<D3D11.Device1> ().QueryInterface<DXGI.Device> ();
            // 创建 Direct2D 设备和工厂。
            this.d2DDevice = new D2D1.Device (dxgiDevice);
            this.deviceContext = new D2D1.DeviceContext (d2DDevice, DeviceContextOptions.None);
            this.swapChain.Dispose ();

            // 创建 DXGI SwapChain。
            SwapChainDescription swapChainDesc = new SwapChainDescription () {
                BufferCount = 1,
                Usage = Usage.RenderTargetOutput,
                OutputHandle = this.Handle,
                IsWindowed = true,
                // 这里宽度和高度都是 0，表示自动获取。
                ModeDescription = new ModeDescription (0, 0, new Rational (60, 1), Format.B8G8R8A8_UNorm),
                SampleDescription = new SampleDescription (1, 0),
                SwapEffect = SwapEffect.Discard
            };
            this.swapChain = new SwapChain (dxgiDevice.GetParent<Adapter> ().GetParent<DXGI.Factory> (),
                d3DDevice, swapChainDesc);
            // 创建 BackBuffer。
            this.backBuffer = Surface.FromSwapChain (this.swapChain, 0);
            // 从 BackBuffer 创建 DeviceContext 可用的目标。
            this.targetBitmap = new Bitmap1 (this.deviceContext, backBuffer);
            this.deviceContext.Target = targetBitmap;
            LoadResources();
        }

        private void LoadResources(){
            Resources.Clear();
            imgFactory = new WIC.ImagingFactory();

            WIC.BitmapDecoder bmpdec = new WIC.BitmapDecoder(imgFactory, @"g:\28.jpg", WIC.DecodeOptions.CacheOnLoad);
            var Converter = new WIC.FormatConverter(imgFactory);
            Converter.Initialize(bmpdec.GetFrame(0), WIC.PixelFormat.Format32bppPBGRA);
            Resources.Add(D2D1.Bitmap.FromWicBitmap(deviceContext, Converter));

            var gaussBlurEffect = new GaussianBlur(deviceContext);
            gaussBlurEffect.SetInput(0,(D2D1.Bitmap) Resources[0], true);
            gaussBlurEffect.StandardDeviation = 20;
            Resources.Add(gaussBlurEffect);
        }

        private void RenderMouseMove (object sender, MouseEventArgs e) {
            mouse = new RawPoint (e.X, e.Y);
        }

        private void AnimatorTick (object sender, EventArgs e) {
            if (GradientAnimations.Count > 0)
                for (int i = 0; i < GradientAnimations.Count; i++) {
                    var item = GradientAnimations[i];
                    if (item.upper)
                        if (item.value < item.max)
                            item.value += (item.step / 100f);
                    if (!item.upper)
                        if (item.value > item.min)
                            item.value -= (item.step / 100f);
                    if (item.value < item.min) item.value = item.min;
                    if (item.value > item.max) item.value = item.max;
                }
            Draw ();
        }

        public void CloseApplication (object sender, EventArgs e) {
            Application.Exit ();
        }

        RawPoint mouse = new RawPoint (-1, -1);
        List<AnimationNumber> GradientAnimations = new List<AnimationNumber> ();

        public class AnimationNumber {
            public AnimationNumber (bool up, float val, int stp, float i, float a) {
                upper = up;
                value = val;
                step = stp;
                min = i;
                max = a;
            }
            public bool upper;
            public float value;
            public int step;
            public float min;
            public float max;
        }
    }
}