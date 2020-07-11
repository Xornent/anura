#if graphics && gl
namespace Anura.Graphics.Gl {
    internal static class Current {
        internal static OpenGL Instance { get; set; } = null;
        internal static bool Implemented { get; set; } = false;
    }
}
#endif