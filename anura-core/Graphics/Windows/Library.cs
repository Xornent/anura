#if graphics && gl && windows
using System;

namespace Anura.Graphics.Windows {

    internal class Library : IDisposable {
        public static readonly Library Instance = new Library ();

        private Library () {
            libPtr = Win32.LoadLibrary (Win32.opengl32);
        }
        ~Library () {
            this.Dispose (false);
        }

        internal readonly IntPtr libPtr;

        public override string ToString () {
            return string.Format ("OpenGL32 Library Address: {0}", libPtr);
        }

        public void Dispose () {
            this.Dispose (true);
            GC.SuppressFinalize (this);
        }

        private bool disposedValue;

        private void Dispose (bool disposing) {
            if (this.disposedValue == false)
                Win32.FreeLibrary (libPtr);
            this.disposedValue = true;
        }
    }
}
#endif