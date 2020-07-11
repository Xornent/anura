#if graphics && gl && windows

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Anura.Graphics.Gl;

namespace Anura.Graphics.Windows {
    
    internal partial class WindowsOpenGl : OpenGL {

        public override IntPtr GetCurrentContext () {
            return Win32.wglGetCurrentContext ();
        }

        [DllImport (Win32.opengl32, EntryPoint = "glAccum", SetLastError = true)]
        private static extern void glAccum (uint op, float value);
        [DllImport (Win32.opengl32, EntryPoint = "glAlphaFunc", SetLastError = true)]
        private static extern void glAlphaFunc (uint func, float ref_notkeword);
        [DllImport (Win32.opengl32, EntryPoint = "glAreTexturesResident", SetLastError = true)]
        private static extern byte glAreTexturesResident (int n, uint[] textures, byte[] residences);
        [DllImport (Win32.opengl32, EntryPoint = "glArrayElement", SetLastError = true)]
        private static extern void glArrayElement (int i);
        [DllImport (Win32.opengl32, EntryPoint = "glBegin", SetLastError = true)]
        private static extern void glBegin (uint mode);
        [DllImport (Win32.opengl32, EntryPoint = "glBindTexture", SetLastError = true)]
        private static extern void glBindTexture (uint target, uint texture);
        [DllImport (Win32.opengl32, EntryPoint = "glBitmap", SetLastError = true)]
        private static extern void glBitmap (int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap);
        [DllImport (Win32.opengl32, EntryPoint = "glBlendFunc", SetLastError = true)]
        private static extern void glBlendFunc (uint sfactor, uint dfactor);
        [DllImport (Win32.opengl32, EntryPoint = "glCallList", SetLastError = true)]
        private static extern void glCallList (uint list);
        [DllImport (Win32.opengl32, EntryPoint = "glCallLists", SetLastError = true)]
        private static extern void glCallLists (int n, uint type, IntPtr lists);
        [DllImport (Win32.opengl32, EntryPoint = "glCallLists", SetLastError = true)]
        private static extern void glCallLists (int n, uint type, uint[] lists);
        [DllImport (Win32.opengl32, EntryPoint = "glCallLists", SetLastError = true)]
        private static extern void glCallLists (int n, uint type, byte[] lists);
        [DllImport (Win32.opengl32, EntryPoint = "glClear", SetLastError = true)]
        private static extern void glClear (uint mask);

        [DllImport (Win32.opengl32, EntryPoint = "glClearAccum", SetLastError = true)]
        private static extern void glClearAccum (float red, float green, float blue, float alpha);
        [DllImport (Win32.opengl32, EntryPoint = "glClearColor", SetLastError = true)]
        internal static extern void glClearColor (float red, float green, float blue, float alpha);
        [DllImport (Win32.opengl32, EntryPoint = "glClearDepth", SetLastError = true)]
        private static extern void glClearDepth (double depth);
        [DllImport (Win32.opengl32, EntryPoint = "glClearIndex", SetLastError = true)]
        private static extern void glClearIndex (float c);
        [DllImport (Win32.opengl32, EntryPoint = "glClearStencil", SetLastError = true)]
        private static extern void glClearStencil (int s);
        [DllImport (Win32.opengl32, EntryPoint = "glClipPlane", SetLastError = true)]
        private static extern void glClipPlane (uint plane, double[] equation);

        [DllImport (Win32.opengl32, EntryPoint = "glColor3b", SetLastError = true)]
        private static extern void glColor3b (byte red, byte green, byte blue);
        [DllImport (Win32.opengl32, EntryPoint = "glColor3bv", SetLastError = true)]
        private static extern void glColor3bv (byte[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glColor3d", SetLastError = true)]
        private static extern void glColor3d (double red, double green, double blue);
        [DllImport (Win32.opengl32, EntryPoint = "glColor3dv", SetLastError = true)]
        private static extern void glColor3dv (double[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glColor3f", SetLastError = true)]
        private static extern void glColor3f (float red, float green, float blue);
        [DllImport (Win32.opengl32, EntryPoint = "glColor3fv", SetLastError = true)]
        private static extern void glColor3fv (float[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glColor3i", SetLastError = true)]
        private static extern void glColor3i (int red, int green, int blue);
        [DllImport (Win32.opengl32, EntryPoint = "glColor3iv", SetLastError = true)]
        private static extern void glColor3iv (int[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glColor3s", SetLastError = true)]
        private static extern void glColor3s (short red, short green, short blue);
        [DllImport (Win32.opengl32, EntryPoint = "glColor3sv", SetLastError = true)]
        private static extern void glColor3sv (short[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glColor3ub", SetLastError = true)]
        private static extern void glColor3ub (byte red, byte green, byte blue);
        [DllImport (Win32.opengl32, EntryPoint = "glColor3ubv", SetLastError = true)]
        private static extern void glColor3ubv (byte[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glColor3ui", SetLastError = true)]
        private static extern void glColor3ui (uint red, uint green, uint blue);
        [DllImport (Win32.opengl32, EntryPoint = "glColor3uiv", SetLastError = true)]
        private static extern void glColor3uiv (uint[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glColor3us", SetLastError = true)]
        private static extern void glColor3us (ushort red, ushort green, ushort blue);
        [DllImport (Win32.opengl32, EntryPoint = "glColor3usv", SetLastError = true)]
        private static extern void glColor3usv (ushort[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glColor4b", SetLastError = true)]
        private static extern void glColor4b (byte red, byte green, byte blue, byte alpha);
        [DllImport (Win32.opengl32, EntryPoint = "glColor4bv", SetLastError = true)]
        private static extern void glColor4bv (byte[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glColor4d", SetLastError = true)]
        private static extern void glColor4d (double red, double green, double blue, double alpha);
        [DllImport (Win32.opengl32, EntryPoint = "glColor4dv", SetLastError = true)]
        private static extern void glColor4dv (double[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glColor4f", SetLastError = true)]
        private static extern void glColor4f (float red, float green, float blue, float alpha);
        [DllImport (Win32.opengl32, EntryPoint = "glColor4fv", SetLastError = true)]
        private static extern void glColor4fv (float[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glColor4i", SetLastError = true)]
        private static extern void glColor4i (int red, int green, int blue, int alpha);
        [DllImport (Win32.opengl32, EntryPoint = "glColor4iv", SetLastError = true)]
        private static extern void glColor4iv (int[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glColor4s", SetLastError = true)]
        private static extern void glColor4s (short red, short green, short blue, short alpha);
        [DllImport (Win32.opengl32, EntryPoint = "glColor4sv", SetLastError = true)]
        private static extern void glColor4sv (short[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glColor4ub", SetLastError = true)]
        private static extern void glColor4ub (byte red, byte green, byte blue, byte alpha);
        [DllImport (Win32.opengl32, EntryPoint = "glColor4ubv", SetLastError = true)]
        private static extern void glColor4ubv (byte[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glColor4ui", SetLastError = true)]
        private static extern void glColor4ui (uint red, uint green, uint blue, uint alpha);
        [DllImport (Win32.opengl32, EntryPoint = "glColor4uiv", SetLastError = true)]
        private static extern void glColor4uiv (uint[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glColor4us", SetLastError = true)]
        private static extern void glColor4us (ushort red, ushort green, ushort blue, ushort alpha);
        [DllImport (Win32.opengl32, EntryPoint = "glColor4usv", SetLastError = true)]
        private static extern void glColor4usv (ushort[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glColorMask", SetLastError = true)]
        private static extern void glColorMask (bool redWritable, bool greenWritable, bool blueWritable, bool alphaWritable);
        [DllImport (Win32.opengl32, EntryPoint = "glColorMaterial", SetLastError = true)]
        private static extern void glColorMaterial (uint face, uint mode);
        [DllImport (Win32.opengl32, EntryPoint = "glColorPointer", SetLastError = true)]
        private static extern void glColorPointer (int size, uint type, int stride, IntPtr pointer);
        [DllImport (Win32.opengl32, EntryPoint = "glCopyPixels", SetLastError = true)]
        private static extern void glCopyPixels (int x, int y, int width, int height, uint type);
        [DllImport (Win32.opengl32, EntryPoint = "glCopyTexImage1D", SetLastError = true)]
        private static extern void glCopyTexImage1D (uint target, int level, uint internalFormat, int x, int y, int width, int border);
        [DllImport (Win32.opengl32, EntryPoint = "glCopyTexImage2D", SetLastError = true)]
        private static extern void glCopyTexImage2D (uint target, int level, uint internalFormat, int x, int y, int width, int height, int border);
        [DllImport (Win32.opengl32, EntryPoint = "glCopyTexSubImage1D", SetLastError = true)]
        private static extern void glCopyTexSubImage1D (uint target, int level, int xoffset, int x, int y, int width);
        [DllImport (Win32.opengl32, EntryPoint = "glCopyTexSubImage2D", SetLastError = true)]
        private static extern void glCopyTexSubImage2D (uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        [DllImport (Win32.opengl32, EntryPoint = "glCullFace", SetLastError = true)]
        private static extern void glCullFace (uint mode);
        [DllImport (Win32.opengl32, EntryPoint = "glDeleteLists", SetLastError = true)]
        private static extern void glDeleteLists (uint list, int range);
        [DllImport (Win32.opengl32, EntryPoint = "glDeleteTextures", SetLastError = true)]
        private static extern void glDeleteTextures (int n, uint[] textures);

        private static GLDelegates.void_uint_uintN glDeleteFramebuffers;
        public static void DeleteFramebuffers (uint n, uint[] framebuffers) {
            IntPtr ptr = Win32.wglGetCurrentContext ();
            if (ptr != IntPtr.Zero) {
                if (glDeleteFramebuffers == null) {
                    glDeleteFramebuffers = GetDelegateFor ("glDeleteFramebuffers", GLDelegates.typeof_void_uint_uintN) as GLDelegates.void_uint_uintN;
                }
                glDeleteFramebuffers (n, framebuffers);
            }
        }

        private static GLDelegates.void_uint_uintN glDeleteRenderbuffers;
        public static void DeleteRenderbuffers (uint n, uint[] renderbuffers) {
            IntPtr ptr = Win32.wglGetCurrentContext ();
            if (ptr != IntPtr.Zero) {
                if (glDeleteRenderbuffers == null) {
                    glDeleteRenderbuffers = GetDelegateFor ("glDeleteRenderbuffers", GLDelegates.typeof_void_uint_uintN) as GLDelegates.void_uint_uintN;
                }
                glDeleteRenderbuffers (n, renderbuffers);
            }
        }

        public static void DeleteBuffers (int n, uint[] buffers) {
            IntPtr ptr = Win32.wglGetCurrentContext ();
            if (ptr != IntPtr.Zero) {
                var function = GetDelegateFor ("glDeleteBuffers", GLDelegates.typeof_void_int_uintN) as GLDelegates.void_int_uintN;
                function (n, buffers);
            }
        }

        [DllImport (Win32.opengl32, EntryPoint = "glDepthFunc", SetLastError = true)]
        private static extern void glDepthFunc (uint func);
        [DllImport (Win32.opengl32, EntryPoint = "glDepthMask", SetLastError = true)]
        private static extern void glDepthMask (bool writable);
        [DllImport (Win32.opengl32, EntryPoint = "glDepthRange", SetLastError = true)]
        private static extern void glDepthRange (double zNear, double zFar);
        [DllImport (Win32.opengl32, EntryPoint = "glDisable", SetLastError = true)]
        private static extern void glDisable (uint cap);
        [DllImport (Win32.opengl32, EntryPoint = "glDisableClientState", SetLastError = true)]
        private static extern void glDisableClientState (uint array);
        [DllImport (Win32.opengl32, EntryPoint = "glDrawArrays", SetLastError = true)]
        private static extern void glDrawArrays (uint mode, int first, int count);
        [DllImport (Win32.opengl32, EntryPoint = "glMultiDrawArrays", SetLastError = true)]
        private static extern void glMultiDrawArrays (uint mode, int[] first, int[] count, int drawcount);
        [DllImport (Win32.opengl32, EntryPoint = "glDrawBuffer", SetLastError = true)]
        private static extern void glDrawBuffer (uint mode);
        [DllImport (Win32.opengl32, EntryPoint = "glDrawElements", SetLastError = true)]
        private static extern void glDrawElements (uint mode, int count, uint type, IntPtr indices);
        [DllImport (Win32.opengl32, EntryPoint = "glMultiDrawElements", SetLastError = true)]
        private static extern void glMultiDrawElements (uint mode, int[] count, uint type, IntPtr indices, int drawcount);
        [DllImport (Win32.opengl32, EntryPoint = "glDrawElements", SetLastError = true)]
        private static extern void glDrawElements (uint mode, int count, uint type, uint[] indices);
        [DllImport (Win32.opengl32, EntryPoint = "glDrawElements", SetLastError = true)]
        private static extern void glDrawElements (uint mode, int count, uint type, ushort[] indices);
        [DllImport (Win32.opengl32, EntryPoint = "glDrawElements", SetLastError = true)]
        private static extern void glDrawElements (uint mode, int count, uint type, byte[] indices);
        [DllImport (Win32.opengl32, EntryPoint = "glMultiDrawElements", SetLastError = true)]
        private static extern void glMultiDrawElements (uint mode, int[] count, uint type, uint[] indices, int drawcount);
        [DllImport (Win32.opengl32, EntryPoint = "glMultiDrawElements", SetLastError = true)]
        private static extern void glMultiDrawElements (uint mode, int[] count, uint type, ushort[] indices, int drawcount);
        [DllImport (Win32.opengl32, EntryPoint = "glMultiDrawElements", SetLastError = true)]
        private static extern void glMultiDrawElements (uint mode, int[] count, uint type, byte[] indices, int drawcount);
        [DllImport (Win32.opengl32, EntryPoint = "glDrawPixels", SetLastError = true)]
        private static extern void glDrawPixels (int width, int height, uint format, uint type, float[] pixels);
        [DllImport (Win32.opengl32, EntryPoint = "glDrawPixels", SetLastError = true)]
        private static extern void glDrawPixels (int width, int height, uint format, uint type, uint[] pixels);
        [DllImport (Win32.opengl32, EntryPoint = "glDrawPixels", SetLastError = true)]
        private static extern void glDrawPixels (int width, int height, uint format, uint type, ushort[] pixels);
        [DllImport (Win32.opengl32, EntryPoint = "glDrawPixels", SetLastError = true)]
        private static extern void glDrawPixels (int width, int height, uint format, uint type, byte[] pixels);
        [DllImport (Win32.opengl32, EntryPoint = "glDrawPixels", SetLastError = true)]
        private static extern void glDrawPixels (int width, int height, uint format, uint type, IntPtr pixels);
        [DllImport (Win32.opengl32, EntryPoint = "glEdgeFlag", SetLastError = true)]
        private static extern void glEdgeFlag (byte flag);
        [DllImport (Win32.opengl32, EntryPoint = "glEdgeFlagPointer", SetLastError = true)]
        private static extern void glEdgeFlagPointer (int stride, int[] pointer);
        [DllImport (Win32.opengl32, EntryPoint = "glEdgeFlagv", SetLastError = true)]
        private static extern void glEdgeFlagv (byte[] flag);
        [DllImport (Win32.opengl32, EntryPoint = "glEnable", SetLastError = true)]
        private static extern void glEnable (uint cap);
        [DllImport (Win32.opengl32, EntryPoint = "glEnableClientState", SetLastError = true)]
        private static extern void glEnableClientState (uint array);

        [DllImport (Win32.opengl32, EntryPoint = "glEnd", SetLastError = true)]
        private static extern void glEnd ();
        [DllImport (Win32.opengl32, EntryPoint = "glEndList", SetLastError = true)]
        private static extern void glEndList ();

        [DllImport (Win32.opengl32, EntryPoint = "glEvalCoord1d", SetLastError = true)]
        private static extern void glEvalCoord1d (double u);
        [DllImport (Win32.opengl32, EntryPoint = "glEvalCoord1dv", SetLastError = true)]
        private static extern void glEvalCoord1dv (double[] u);
        [DllImport (Win32.opengl32, EntryPoint = "glEvalCoord1f", SetLastError = true)]
        private static extern void glEvalCoord1f (float u);
        [DllImport (Win32.opengl32, EntryPoint = "glEvalCoord1fv", SetLastError = true)]
        private static extern void glEvalCoord1fv (float[] u);
        [DllImport (Win32.opengl32, EntryPoint = "glEvalCoord2d", SetLastError = true)]
        private static extern void glEvalCoord2d (double u, double v);
        [DllImport (Win32.opengl32, EntryPoint = "glEvalCoord2dv", SetLastError = true)]
        private static extern void glEvalCoord2dv (double[] u);
        [DllImport (Win32.opengl32, EntryPoint = "glEvalCoord2f", SetLastError = true)]
        private static extern void glEvalCoord2f (float u, float v);
        [DllImport (Win32.opengl32, EntryPoint = "glEvalCoord2fv", SetLastError = true)]
        private static extern void glEvalCoord2fv (float[] u);
        [DllImport (Win32.opengl32, EntryPoint = "glEvalMesh1", SetLastError = true)]
        private static extern void glEvalMesh1 (uint mode, int i1, int i2);
        [DllImport (Win32.opengl32, EntryPoint = "glEvalMesh2", SetLastError = true)]
        private static extern void glEvalMesh2 (uint mode, int i1, int i2, int j1, int j2);
        [DllImport (Win32.opengl32, EntryPoint = "glEvalPoint1", SetLastError = true)]
        private static extern void glEvalPoint1 (int i);
        [DllImport (Win32.opengl32, EntryPoint = "glEvalPoint2", SetLastError = true)]
        private static extern void glEvalPoint2 (int i, int j);
        [DllImport (Win32.opengl32, EntryPoint = "glFeedbackBuffer", SetLastError = true)]
        private static extern void glFeedbackBuffer (int size, uint type, float[] buffer);

        [DllImport (Win32.opengl32, EntryPoint = "glFinish", SetLastError = true)]
        private static extern void glFinish ();
        [DllImport (Win32.opengl32, EntryPoint = "glFlush", SetLastError = true)]
        private static extern void glFlush ();
        [DllImport (Win32.opengl32, EntryPoint = "glFogf", SetLastError = true)]
        private static extern void glFogf (uint pname, float param);
        [DllImport (Win32.opengl32, EntryPoint = "glFogfv", SetLastError = true)]
        private static extern void glFogfv (uint pname, float[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glFogi", SetLastError = true)]
        private static extern void glFogi (uint pname, int param);
        [DllImport (Win32.opengl32, EntryPoint = "glFogiv", SetLastError = true)]
        private static extern void glFogiv (uint pname, int[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glFrontFace", SetLastError = true)]
        private static extern void glFrontFace (uint mode);
        [DllImport (Win32.opengl32, EntryPoint = "glFrustum", SetLastError = true)]
        private static extern void glFrustum (double left, double right, double bottom, double top, double zNear, double zFar);
        [DllImport (Win32.opengl32, EntryPoint = "glGenLists", SetLastError = true)]
        private static extern uint glGenLists (int range);
        [DllImport (Win32.opengl32, EntryPoint = "glGenTextures", SetLastError = true)]
        private static extern void glGenTextures (int n, uint[] textures);

        private static GLDelegates.void_int_uintN glGenSamplers;
        public static void GenSamplers (int n, uint[] textures) {
            if (glGenSamplers == null) {
                glGenSamplers = GetDelegateFor ("glGenSamplers", GLDelegates.typeof_void_int_uintN) as GLDelegates.void_int_uintN;
            }
            glGenSamplers (n, textures);
        }

        [DllImport (Win32.opengl32, EntryPoint = "glGetBooleanv", SetLastError = true)]
        private static extern void glGetBooleanv (uint pname, byte[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glGetClipPlane", SetLastError = true)]
        private static extern void glGetClipPlane (uint plane, double[] equation);
        [DllImport (Win32.opengl32, EntryPoint = "glGetDoublev", SetLastError = true)]
        private static extern void glGetDoublev (uint pname, double[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glGetError", SetLastError = true)]
        private static extern uint glGetError ();
        [DllImport (Win32.opengl32, EntryPoint = "glGetFloatv", SetLastError = true)]
        private static extern void glGetFloatv (uint pname, float[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glGetIntegerv", SetLastError = true)]
        private static extern void glGetIntegerv (uint pname, int[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glGetLightfv", SetLastError = true)]
        private static extern void glGetLightfv (uint light, uint pname, float[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glGetLightiv", SetLastError = true)]
        private static extern void glGetLightiv (uint light, uint pname, int[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glGetMapdv", SetLastError = true)]
        private static extern void glGetMapdv (uint target, uint query, double[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glGetMapfv", SetLastError = true)]
        private static extern void glGetMapfv (uint target, uint query, float[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glGetMapiv", SetLastError = true)]
        private static extern void glGetMapiv (uint target, uint query, int[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glGetMaterialfv", SetLastError = true)]
        private static extern void glGetMaterialfv (uint face, uint pname, float[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glGetMaterialiv", SetLastError = true)]
        private static extern void glGetMaterialiv (uint face, uint pname, int[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glGetPixelMapfv", SetLastError = true)]
        private static extern void glGetPixelMapfv (uint map, float[] values);
        [DllImport (Win32.opengl32, EntryPoint = "glGetPixelMapuiv", SetLastError = true)]
        private static extern void glGetPixelMapuiv (uint map, uint[] values);
        [DllImport (Win32.opengl32, EntryPoint = "glGetPixelMapusv", SetLastError = true)]
        private static extern void glGetPixelMapusv (uint map, ushort[] values);
        [DllImport (Win32.opengl32, EntryPoint = "glGetPointerv", SetLastError = true)]
        private static extern void glGetPointerv (uint pname, int[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glGetPolygonStipple", SetLastError = true)]
        private static extern void glGetPolygonStipple (byte[] mask);
        [DllImport (Win32.opengl32, EntryPoint = "glGetString", SetLastError = true)]
        private unsafe static extern sbyte * glGetString (uint name);
        [DllImport (Win32.opengl32, EntryPoint = "glGetTexEnvfv", SetLastError = true)]
        private static extern void glGetTexEnvfv (uint target, uint pname, float[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glGetTexEnviv", SetLastError = true)]
        private static extern void glGetTexEnviv (uint target, uint pname, int[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glGetTexGendv", SetLastError = true)]
        private static extern void glGetTexGendv (uint coord, uint pname, double[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glGetTexGenfv", SetLastError = true)]
        private static extern void glGetTexGenfv (uint coord, uint pname, float[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glGetTexGeniv", SetLastError = true)]
        private static extern void glGetTexGeniv (uint coord, uint pname, int[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glGetTexImage", SetLastError = true)]
        private static extern void glGetTexImage (uint target, int level, uint format, uint type, IntPtr pixels);
        [DllImport (Win32.opengl32, EntryPoint = "glGetTexLevelParameterfv", SetLastError = true)]
        private static extern void glGetTexLevelParameterfv (uint target, int level, uint pname, float[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glGetTexLevelParameteriv", SetLastError = true)]
        private static extern void glGetTexLevelParameteriv (uint target, int level, uint pname, int[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glGetTexParameterfv", SetLastError = true)]
        private static extern void glGetTexParameterfv (uint target, uint pname, float[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glGetTexParameteriv", SetLastError = true)]
        private static extern void glGetTexParameteriv (uint target, uint pname, int[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glHint", SetLastError = true)]
        private static extern void glHint (uint target, uint mode);
        [DllImport (Win32.opengl32, EntryPoint = "glIndexMask", SetLastError = true)]
        private static extern void glIndexMask (uint mask);
        [DllImport (Win32.opengl32, EntryPoint = "glIndexPointer", SetLastError = true)]
        private static extern void glIndexPointer (uint type, int stride, int[] pointer);
        [DllImport (Win32.opengl32, EntryPoint = "glIndexd", SetLastError = true)]
        private static extern void glIndexd (double c);
        [DllImport (Win32.opengl32, EntryPoint = "glIndexdv", SetLastError = true)]
        private static extern void glIndexdv (double[] c);
        [DllImport (Win32.opengl32, EntryPoint = "glIndexf", SetLastError = true)]
        private static extern void glIndexf (float c);
        [DllImport (Win32.opengl32, EntryPoint = "glIndexfv", SetLastError = true)]
        private static extern void glIndexfv (float[] c);
        [DllImport (Win32.opengl32, EntryPoint = "glIndexi", SetLastError = true)]
        private static extern void glIndexi (int c);
        [DllImport (Win32.opengl32, EntryPoint = "glIndexiv", SetLastError = true)]
        private static extern void glIndexiv (int[] c);
        [DllImport (Win32.opengl32, EntryPoint = "glIndexs", SetLastError = true)]
        private static extern void glIndexs (short c);
        [DllImport (Win32.opengl32, EntryPoint = "glIndexsv", SetLastError = true)]
        private static extern void glIndexsv (short[] c);
        [DllImport (Win32.opengl32, EntryPoint = "glIndexub", SetLastError = true)]
        private static extern void glIndexub (byte c);
        [DllImport (Win32.opengl32, EntryPoint = "glIndexubv", SetLastError = true)]
        private static extern void glIndexubv (byte[] c);
        [DllImport (Win32.opengl32, EntryPoint = "glInitNames", SetLastError = true)]
        private static extern void glInitNames ();
        [DllImport (Win32.opengl32, EntryPoint = "glInterleavedArrays", SetLastError = true)]
        private static extern void glInterleavedArrays (uint format, int stride, int[] pointer);
        [DllImport (Win32.opengl32, EntryPoint = "glIsEnabled", SetLastError = true)]
        private static extern byte glIsEnabled (uint cap);
        [DllImport (Win32.opengl32, EntryPoint = "glIsList", SetLastError = true)]
        private static extern byte glIsList (uint list);
        [DllImport (Win32.opengl32, EntryPoint = "glIsTexture", SetLastError = true)]
        private static extern byte glIsTexture (uint texture);
        [DllImport (Win32.opengl32, EntryPoint = "glLightModelf", SetLastError = true)]
        private static extern void glLightModelf (uint pname, float param);
        [DllImport (Win32.opengl32, EntryPoint = "glLightModelfv", SetLastError = true)]
        private static extern void glLightModelfv (uint pname, float[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glLightModeli", SetLastError = true)]
        private static extern void glLightModeli (uint pname, int param);
        [DllImport (Win32.opengl32, EntryPoint = "glLightModeliv", SetLastError = true)]
        private static extern void glLightModeliv (uint pname, int[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glLightf", SetLastError = true)]
        private static extern void glLightf (uint light, uint pname, float param);
        [DllImport (Win32.opengl32, EntryPoint = "glLightfv", SetLastError = true)]
        private static extern void glLightfv (uint light, uint pname, float[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glLighti", SetLastError = true)]
        private static extern void glLighti (uint light, uint pname, int param);
        [DllImport (Win32.opengl32, EntryPoint = "glLightiv", SetLastError = true)]
        private static extern void glLightiv (uint light, uint pname, int[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glLineStipple", SetLastError = true)]
        private static extern void glLineStipple (int factor, ushort pattern);
        [DllImport (Win32.opengl32, EntryPoint = "glLineWidth", SetLastError = true)]
        private static extern void glLineWidth (float width);
        [DllImport (Win32.opengl32, EntryPoint = "glListBase", SetLastError = true)]
        private static extern void glListBase (uint listbase);
        [DllImport (Win32.opengl32, EntryPoint = "glLoadIdentity", SetLastError = true)]
        private static extern void glLoadIdentity ();
        [DllImport (Win32.opengl32, EntryPoint = "glLoadMatrixd", SetLastError = true)]
        private static extern void glLoadMatrixd (double[] m);
        [DllImport (Win32.opengl32, EntryPoint = "glLoadMatrixf", SetLastError = true)]
        private static extern void glLoadMatrixf (float[] m);
        [DllImport (Win32.opengl32, EntryPoint = "glLoadName", SetLastError = true)]
        private static extern void glLoadName (uint name);
        [DllImport (Win32.opengl32, EntryPoint = "glLogicOp", SetLastError = true)]
        private static extern void glLogicOp (uint opcode);
        [DllImport (Win32.opengl32, EntryPoint = "glMap1d", SetLastError = true)]
        private static extern void glMap1d (uint target, double u1, double u2, int stride, int order, IntPtr points);
        [DllImport (Win32.opengl32, EntryPoint = "glMap1f", SetLastError = true)]
        private static extern void glMap1f (uint target, float u1, float u2, int stride, int order, IntPtr points);
        [DllImport (Win32.opengl32, EntryPoint = "glMap2d", SetLastError = true)]
        private static extern void glMap2d (uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, IntPtr points);
        [DllImport (Win32.opengl32, EntryPoint = "glMap2f", SetLastError = true)]
        private static extern void glMap2f (uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, IntPtr points);
        [DllImport (Win32.opengl32, EntryPoint = "glMapGrid1d", SetLastError = true)]
        private static extern void glMapGrid1d (int un, double u1, double u2);
        [DllImport (Win32.opengl32, EntryPoint = "glMapGrid1f", SetLastError = true)]
        private static extern void glMapGrid1f (int un, float u1, float u2);
        [DllImport (Win32.opengl32, EntryPoint = "glMapGrid2d", SetLastError = true)]
        private static extern void glMapGrid2d (int un, double u1, double u2, int vn, double v1, double v2);
        [DllImport (Win32.opengl32, EntryPoint = "glMapGrid2f", SetLastError = true)]
        private static extern void glMapGrid2f (int un, float u1, float u2, int vn, float v1, float v2);
        [DllImport (Win32.opengl32, EntryPoint = "glMaterialf", SetLastError = true)]
        private static extern void glMaterialf (uint face, uint pname, float param);
        [DllImport (Win32.opengl32, EntryPoint = "glMaterialfv", SetLastError = true)]
        private static extern void glMaterialfv (uint face, uint pname, float[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glMateriali", SetLastError = true)]
        private static extern void glMateriali (uint face, uint pname, int param);
        [DllImport (Win32.opengl32, EntryPoint = "glMaterialiv", SetLastError = true)]
        private static extern void glMaterialiv (uint face, uint pname, int[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glMatrixMode", SetLastError = true)]
        private static extern void glMatrixMode (uint mode);
        [DllImport (Win32.opengl32, EntryPoint = "glMultMatrixd", SetLastError = true)]
        private static extern void glMultMatrixd (double[] m);
        [DllImport (Win32.opengl32, EntryPoint = "glMultMatrixf", SetLastError = true)]
        private static extern void glMultMatrixf (float[] m);
        [DllImport (Win32.opengl32, EntryPoint = "glNewList", SetLastError = true)]
        private static extern void glNewList (uint list, uint mode);
        [DllImport (Win32.opengl32, EntryPoint = "glNormal3b", SetLastError = true)]
        private static extern void glNormal3b (byte nx, byte ny, byte nz);
        [DllImport (Win32.opengl32, EntryPoint = "glNormal3bv", SetLastError = true)]
        private static extern void glNormal3bv (byte[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glNormal3d", SetLastError = true)]
        private static extern void glNormal3d (double nx, double ny, double nz);
        [DllImport (Win32.opengl32, EntryPoint = "glNormal3dv", SetLastError = true)]
        private static extern void glNormal3dv (double[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glNormal3f", SetLastError = true)]
        private static extern void glNormal3f (float nx, float ny, float nz);
        [DllImport (Win32.opengl32, EntryPoint = "glNormal3fv", SetLastError = true)]
        private static extern void glNormal3fv (float[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glNormal3i", SetLastError = true)]
        private static extern void glNormal3i (int nx, int ny, int nz);
        [DllImport (Win32.opengl32, EntryPoint = "glNormal3iv", SetLastError = true)]
        private static extern void glNormal3iv (int[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glNormal3s", SetLastError = true)]
        private static extern void glNormal3s (short nx, short ny, short nz);
        [DllImport (Win32.opengl32, EntryPoint = "glNormal3sv", SetLastError = true)]
        private static extern void glNormal3sv (short[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glNormalPointer", SetLastError = true)]
        private static extern void glNormalPointer (uint type, int stride, IntPtr pointer);
        [DllImport (Win32.opengl32, EntryPoint = "glNormalPointer", SetLastError = true)]
        private static extern void glNormalPointer (uint type, int stride, float[] pointer);
        [DllImport (Win32.opengl32, EntryPoint = "glOrtho", SetLastError = true)]
        private static extern void glOrtho (double left, double right, double bottom, double top, double zNear, double zFar);
        [DllImport (Win32.opengl32, EntryPoint = "glPassThrough", SetLastError = true)]
        private static extern void glPassThrough (float token);
        [DllImport (Win32.opengl32, EntryPoint = "glPixelMapfv", SetLastError = true)]
        private static extern void glPixelMapfv (uint map, int mapsize, float[] values);
        [DllImport (Win32.opengl32, EntryPoint = "glPixelMapuiv", SetLastError = true)]
        private static extern void glPixelMapuiv (uint map, int mapsize, uint[] values);
        [DllImport (Win32.opengl32, EntryPoint = "glPixelMapusv", SetLastError = true)]
        private static extern void glPixelMapusv (uint map, int mapsize, ushort[] values);
        [DllImport (Win32.opengl32, EntryPoint = "glPixelStoref", SetLastError = true)]
        private static extern void glPixelStoref (uint pname, float param);
        [DllImport (Win32.opengl32, EntryPoint = "glPixelStorei", SetLastError = true)]
        private static extern void glPixelStorei (uint pname, int param);
        [DllImport (Win32.opengl32, EntryPoint = "glPixelTransferf", SetLastError = true)]
        private static extern void glPixelTransferf (uint pname, float param);
        [DllImport (Win32.opengl32, EntryPoint = "glPixelTransferi", SetLastError = true)]
        private static extern void glPixelTransferi (uint pname, int param);
        [DllImport (Win32.opengl32, EntryPoint = "glPixelZoom", SetLastError = true)]
        private static extern void glPixelZoom (float xfactor, float yfactor);
        [DllImport (Win32.opengl32, EntryPoint = "glPointSize", SetLastError = true)]
        private static extern void glPointSize (float size);
        [DllImport (Win32.opengl32, EntryPoint = "glPolygonMode", SetLastError = true)]
        private static extern void glPolygonMode (uint face, uint mode);
        [DllImport (Win32.opengl32, EntryPoint = "glPolygonOffset", SetLastError = true)]
        private static extern void glPolygonOffset (float factor, float units);
        [DllImport (Win32.opengl32, EntryPoint = "glPolygonStipple", SetLastError = true)]
        private static extern void glPolygonStipple (byte[] mask);
        [DllImport (Win32.opengl32, EntryPoint = "glPopAttrib", SetLastError = true)]
        private static extern void glPopAttrib ();
        [DllImport (Win32.opengl32, EntryPoint = "glPopClientAttrib", SetLastError = true)]
        private static extern void glPopClientAttrib ();
        [DllImport (Win32.opengl32, EntryPoint = "glPopMatrix", SetLastError = true)]
        private static extern void glPopMatrix ();
        [DllImport (Win32.opengl32, EntryPoint = "glPopName", SetLastError = true)]
        private static extern void glPopName ();
        [DllImport (Win32.opengl32, EntryPoint = "glPrioritizeTextures", SetLastError = true)]
        private static extern void glPrioritizeTextures (int n, uint[] textures, float[] priorities);
        [DllImport (Win32.opengl32, EntryPoint = "glPushAttrib", SetLastError = true)]
        private static extern void glPushAttrib (uint mask);
        [DllImport (Win32.opengl32, EntryPoint = "glPushClientAttrib", SetLastError = true)]
        private static extern void glPushClientAttrib (uint mask);
        [DllImport (Win32.opengl32, EntryPoint = "glPushMatrix", SetLastError = true)]
        private static extern void glPushMatrix ();
        [DllImport (Win32.opengl32, EntryPoint = "glPushName", SetLastError = true)]
        private static extern void glPushName (uint name);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos2d", SetLastError = true)]
        private static extern void glRasterPos2d (double x, double y);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos2dv", SetLastError = true)]
        private static extern void glRasterPos2dv (double[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos2f", SetLastError = true)]
        private static extern void glRasterPos2f (float x, float y);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos2fv", SetLastError = true)]
        private static extern void glRasterPos2fv (float[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos2i", SetLastError = true)]
        private static extern void glRasterPos2i (int x, int y);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos2iv", SetLastError = true)]
        private static extern void glRasterPos2iv (int[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos2s", SetLastError = true)]
        private static extern void glRasterPos2s (short x, short y);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos2sv", SetLastError = true)]
        private static extern void glRasterPos2sv (short[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos3d", SetLastError = true)]
        private static extern void glRasterPos3d (double x, double y, double z);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos3dv", SetLastError = true)]
        private static extern void glRasterPos3dv (double[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos3f", SetLastError = true)]
        private static extern void glRasterPos3f (float x, float y, float z);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos3fv", SetLastError = true)]
        private static extern void glRasterPos3fv (float[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos3i", SetLastError = true)]
        private static extern void glRasterPos3i (int x, int y, int z);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos3iv", SetLastError = true)]
        private static extern void glRasterPos3iv (int[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos3s", SetLastError = true)]
        private static extern void glRasterPos3s (short x, short y, short z);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos3sv", SetLastError = true)]
        private static extern void glRasterPos3sv (short[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos4d", SetLastError = true)]
        private static extern void glRasterPos4d (double x, double y, double z, double w);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos4dv", SetLastError = true)]
        private static extern void glRasterPos4dv (double[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos4f", SetLastError = true)]
        private static extern void glRasterPos4f (float x, float y, float z, float w);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos4fv", SetLastError = true)]
        private static extern void glRasterPos4fv (float[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos4i", SetLastError = true)]
        private static extern void glRasterPos4i (int x, int y, int z, int w);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos4iv", SetLastError = true)]
        private static extern void glRasterPos4iv (int[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos4s", SetLastError = true)]
        private static extern void glRasterPos4s (short x, short y, short z, short w);
        [DllImport (Win32.opengl32, EntryPoint = "glRasterPos4sv", SetLastError = true)]
        private static extern void glRasterPos4sv (short[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glReadBuffer", SetLastError = true)]
        private static extern void glReadBuffer (uint mode);
        [DllImport (Win32.opengl32, EntryPoint = "glReadPixels", SetLastError = true)]
        private static extern void glReadPixels (int x, int y, int width, int height, uint format, uint type, byte[] pixels);
        [DllImport (Win32.opengl32, EntryPoint = "glReadPixels", SetLastError = true)]
        private static extern void glReadPixels (int x, int y, int width, int height, uint format, uint type, IntPtr pixels);
        [DllImport (Win32.opengl32, EntryPoint = "glRectd", SetLastError = true)]
        private static extern void glRectd (double x1, double y1, double x2, double y2);
        [DllImport (Win32.opengl32, EntryPoint = "glRectdv", SetLastError = true)]
        private static extern void glRectdv (double[] v1, double[] v2);
        [DllImport (Win32.opengl32, EntryPoint = "glRectf", SetLastError = true)]
        private static extern void glRectf (float x1, float y1, float x2, float y2);
        [DllImport (Win32.opengl32, EntryPoint = "glRectfv", SetLastError = true)]
        private static extern void glRectfv (float[] v1, float[] v2);
        [DllImport (Win32.opengl32, EntryPoint = "glRecti", SetLastError = true)]
        private static extern void glRecti (int x1, int y1, int x2, int y2);
        [DllImport (Win32.opengl32, EntryPoint = "glRectiv", SetLastError = true)]
        private static extern void glRectiv (int[] v1, int[] v2);
        [DllImport (Win32.opengl32, EntryPoint = "glRects", SetLastError = true)]
        private static extern void glRects (short x1, short y1, short x2, short y2);
        [DllImport (Win32.opengl32, EntryPoint = "glRectsv", SetLastError = true)]
        private static extern void glRectsv (short[] v1, short[] v2);
        [DllImport (Win32.opengl32, EntryPoint = "glRenderMode", SetLastError = true)]
        private static extern int glRenderMode (uint mode);

        [DllImport (Win32.opengl32, EntryPoint = "glRotated", SetLastError = true)]
        private static extern void glRotated (double angle, double x, double y, double z);
        [DllImport (Win32.opengl32, EntryPoint = "glRotatef", SetLastError = true)]
        private static extern void glRotatef (float angle, float x, float y, float z);
        [DllImport (Win32.opengl32, EntryPoint = "glScaled", SetLastError = true)]
        private static extern void glScaled (double x, double y, double z);
        [DllImport (Win32.opengl32, EntryPoint = "glScalef", SetLastError = true)]
        private static extern void glScalef (float x, float y, float z);
        [DllImport (Win32.opengl32, EntryPoint = "glScissor", SetLastError = true)]
        private static extern void glScissor (int x, int y, int width, int height);
        [DllImport (Win32.opengl32, EntryPoint = "glSelectBuffer", SetLastError = true)]
        private static extern void glSelectBuffer (int size, uint[] buffer);
        [DllImport (Win32.opengl32, EntryPoint = "glShadeModel", SetLastError = true)]
        private static extern void glShadeModel (uint mode);
        [DllImport (Win32.opengl32, EntryPoint = "glStencilFunc", SetLastError = true)]
        private static extern void glStencilFunc (uint func, int reference, uint mask);
        [DllImport (Win32.opengl32, EntryPoint = "glStencilMask", SetLastError = true)]
        private static extern void glStencilMask (uint mask);
        [DllImport (Win32.opengl32, EntryPoint = "glStencilOp", SetLastError = true)]
        private static extern void glStencilOp (uint fail, uint zfail, uint zpass);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord1d", SetLastError = true)]
        private static extern void glTexCoord1d (double s);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord1dv", SetLastError = true)]
        private static extern void glTexCoord1dv (double[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord1f", SetLastError = true)]
        private static extern void glTexCoord1f (float s);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord1fv", SetLastError = true)]
        private static extern void glTexCoord1fv (float[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord1i", SetLastError = true)]
        private static extern void glTexCoord1i (int s);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord1iv", SetLastError = true)]
        private static extern void glTexCoord1iv (int[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord1s", SetLastError = true)]
        private static extern void glTexCoord1s (short s);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord1sv", SetLastError = true)]
        private static extern void glTexCoord1sv (short[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord2d", SetLastError = true)]
        private static extern void glTexCoord2d (double s, double t);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord2dv", SetLastError = true)]
        private static extern void glTexCoord2dv (double[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord2f", SetLastError = true)]
        private static extern void glTexCoord2f (float s, float t);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord2fv", SetLastError = true)]
        private static extern void glTexCoord2fv (float[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord2i", SetLastError = true)]
        private static extern void glTexCoord2i (int s, int t);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord2iv", SetLastError = true)]
        private static extern void glTexCoord2iv (int[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord2s", SetLastError = true)]
        private static extern void glTexCoord2s (short s, short t);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord2sv", SetLastError = true)]
        private static extern void glTexCoord2sv (short[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord3d", SetLastError = true)]
        private static extern void glTexCoord3d (double s, double t, double r);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord3dv", SetLastError = true)]
        private static extern void glTexCoord3dv (double[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord3f", SetLastError = true)]
        private static extern void glTexCoord3f (float s, float t, float r);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord3fv", SetLastError = true)]
        private static extern void glTexCoord3fv (float[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord3i", SetLastError = true)]
        private static extern void glTexCoord3i (int s, int t, int r);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord3iv", SetLastError = true)]
        private static extern void glTexCoord3iv (int[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord3s", SetLastError = true)]
        private static extern void glTexCoord3s (short s, short t, short r);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord3sv", SetLastError = true)]
        private static extern void glTexCoord3sv (short[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord4d", SetLastError = true)]
        private static extern void glTexCoord4d (double s, double t, double r, double q);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord4dv", SetLastError = true)]
        private static extern void glTexCoord4dv (double[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord4f", SetLastError = true)]
        private static extern void glTexCoord4f (float s, float t, float r, float q);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord4fv", SetLastError = true)]
        private static extern void glTexCoord4fv (float[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord4i", SetLastError = true)]
        private static extern void glTexCoord4i (int s, int t, int r, int q);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord4iv", SetLastError = true)]
        private static extern void glTexCoord4iv (int[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord4s", SetLastError = true)]
        private static extern void glTexCoord4s (short s, short t, short r, short q);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoord4sv", SetLastError = true)]
        private static extern void glTexCoord4sv (short[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoordPointer", SetLastError = true)]
        private static extern void glTexCoordPointer (int size, uint type, int stride, IntPtr pointer);
        [DllImport (Win32.opengl32, EntryPoint = "glTexCoordPointer", SetLastError = true)]
        private static extern void glTexCoordPointer (int size, uint type, int stride, float[] pointer);
        [DllImport (Win32.opengl32, EntryPoint = "glTexEnvf", SetLastError = true)]
        private static extern void glTexEnvf (uint target, uint pname, float param);
        [DllImport (Win32.opengl32, EntryPoint = "glTexEnvfv", SetLastError = true)]
        private static extern void glTexEnvfv (uint target, uint pname, float[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glTexEnvi", SetLastError = true)]
        private static extern void glTexEnvi (uint target, uint pname, int param);
        [DllImport (Win32.opengl32, EntryPoint = "glTexEnviv", SetLastError = true)]
        private static extern void glTexEnviv (uint target, uint pname, int[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glTexGend", SetLastError = true)]
        private static extern void glTexGend (uint coord, uint pname, double param);
        [DllImport (Win32.opengl32, EntryPoint = "glTexGendv", SetLastError = true)]
        private static extern void glTexGendv (uint coord, uint pname, double[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glTexGenf", SetLastError = true)]
        private static extern void glTexGenf (uint coord, uint pname, float param);
        [DllImport (Win32.opengl32, EntryPoint = "glTexGenfv", SetLastError = true)]
        private static extern void glTexGenfv (uint coord, uint pname, float[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glTexGeni", SetLastError = true)]
        private static extern void glTexGeni (uint coord, uint pname, int param);
        [DllImport (Win32.opengl32, EntryPoint = "glTexGeniv", SetLastError = true)]
        private static extern void glTexGeniv (uint coord, uint pname, int[] parameters);

        [DllImport (Win32.opengl32, EntryPoint = "glTexImage1D", SetLastError = true)]
        private static extern void glTexImage1D (uint target, int level, uint internalformat, int width, int border, uint format, uint type, IntPtr pixels);
        [DllImport (Win32.opengl32, EntryPoint = "glTexImage2D", SetLastError = true)]
        private static extern void glTexImage2D (uint target, int level, uint internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels);
        [DllImport (Win32.opengl32, EntryPoint = "glTexParameterf", SetLastError = true)]
        private static extern void glTexParameterf (uint target, uint pname, float param);
        [DllImport (Win32.opengl32, EntryPoint = "glTexParameterfv", SetLastError = true)]
        private static extern void glTexParameterfv (uint target, uint pname, float[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glTexParameteri", SetLastError = true)]
        private static extern void glTexParameteri (uint target, uint pname, int param);

        private static GLDelegates.void_uint_uint_int glSamplerParameteri;
        public static void SamplerParameteri (uint sampler, uint pname, int param) {
            if (glSamplerParameteri == null) {
                glSamplerParameteri = GetDelegateFor ("glSamplerParameteri", GLDelegates.typeof_void_uint_uint_int) as GLDelegates.void_uint_uint_int;
            }
            glSamplerParameteri (sampler, pname, param);
        }

        [DllImport (Win32.opengl32, EntryPoint = "glTexParameteriv", SetLastError = true)]
        private static extern void glTexParameteriv (uint target, uint pname, int[] parameters);
        [DllImport (Win32.opengl32, EntryPoint = "glTexSubImage1D", SetLastError = true)]
        private static extern void glTexSubImage1D (uint target, int level, int xoffset, int width, uint format, uint type, int[] pixels);
        [DllImport (Win32.opengl32, EntryPoint = "glTexSubImage1D", SetLastError = true)]
        private static extern void glTexSubImage1D (uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);
        [DllImport (Win32.opengl32, EntryPoint = "glTexSubImage2D", SetLastError = true)]
        private static extern void glTexSubImage2D (uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, int[] pixels);
        [DllImport (Win32.opengl32, EntryPoint = "glTexSubImage2D", SetLastError = true)]
        private static extern void glTexSubImage2D (uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);

        [DllImport (Win32.opengl32, EntryPoint = "glTranslated", SetLastError = true)]
        private static extern void glTranslated (double x, double y, double z);
        [DllImport (Win32.opengl32, EntryPoint = "glTranslatef", SetLastError = true)]
        private static extern void glTranslatef (float x, float y, float z);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex2d", SetLastError = true)]
        private static extern void glVertex2d (double x, double y);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex2dv", SetLastError = true)]
        private static extern void glVertex2dv (double[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex2f", SetLastError = true)]
        private static extern void glVertex2f (float x, float y);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex2fv", SetLastError = true)]
        private static extern void glVertex2fv (float[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex2i", SetLastError = true)]
        private static extern void glVertex2i (int x, int y);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex2iv", SetLastError = true)]
        private static extern void glVertex2iv (int[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex2s", SetLastError = true)]
        private static extern void glVertex2s (short x, short y);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex2sv", SetLastError = true)]
        private static extern void glVertex2sv (short[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex3d", SetLastError = true)]
        private static extern void glVertex3d (double x, double y, double z);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex3dv", SetLastError = true)]
        private static extern void glVertex3dv (double[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex3f", SetLastError = true)]
        private static extern void glVertex3f (float x, float y, float z);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex3fv", SetLastError = true)]
        private static extern void glVertex3fv (float[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex3i", SetLastError = true)]
        private static extern void glVertex3i (int x, int y, int z);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex3iv", SetLastError = true)]
        private static extern void glVertex3iv (int[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex3s", SetLastError = true)]
        private static extern void glVertex3s (short x, short y, short z);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex3sv", SetLastError = true)]
        private static extern void glVertex3sv (short[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex4d", SetLastError = true)]
        private static extern void glVertex4d (double x, double y, double z, double w);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex4dv", SetLastError = true)]
        private static extern void glVertex4dv (double[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex4f", SetLastError = true)]
        private static extern void glVertex4f (float x, float y, float z, float w);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex4fv", SetLastError = true)]
        private static extern void glVertex4fv (float[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex4i", SetLastError = true)]
        private static extern void glVertex4i (int x, int y, int z, int w);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex4iv", SetLastError = true)]
        private static extern void glVertex4iv (int[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex4s", SetLastError = true)]
        private static extern void glVertex4s (short x, short y, short z, short w);
        [DllImport (Win32.opengl32, EntryPoint = "glVertex4sv", SetLastError = true)]
        private static extern void glVertex4sv (short[] v);
        [DllImport (Win32.opengl32, EntryPoint = "glVertexPointer", SetLastError = true)]
        private static extern void glVertexPointer (int size, uint type, int stride, IntPtr pointer);
        [DllImport (Win32.opengl32, EntryPoint = "glVertexPointer", SetLastError = true)]
        private static extern void glVertexPointer (int size, uint type, int stride, short[] pointer);
        [DllImport (Win32.opengl32, EntryPoint = "glVertexPointer", SetLastError = true)]
        private static extern void glVertexPointer (int size, uint type, int stride, int[] pointer);
        [DllImport (Win32.opengl32, EntryPoint = "glVertexPointer", SetLastError = true)]
        private static extern void glVertexPointer (int size, uint type, int stride, float[] pointer);
        [DllImport (Win32.opengl32, EntryPoint = "glVertexPointer", SetLastError = true)]
        private static extern void glVertexPointer (int size, uint type, int stride, double[] pointer);
        [DllImport (Win32.opengl32, EntryPoint = "glViewport", SetLastError = true)]
        private static extern void glViewport (int x, int y, int width, int height);

        #region Wrappers
        public override void Accum (uint op, float value) { glAccum (op, value); }
        public override void AlphaFunc (uint func, float ref_notkeword) { glAlphaFunc (func, ref_notkeword); }
        public override byte AreTexturesResident (int n, uint[] textures, byte[] residences) { return glAreTexturesResident (n, textures, residences); }
        public override void ArrayElement (int i) { glArrayElement (i); }

        public override void Begin (uint mode) { glBegin (mode); }
        public override void BindTexture (uint target, uint texture) { glBindTexture (target, texture); }
        public override void Bitmap (int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap) { glBitmap (width, height, xorig, yorig, xmove, ymove, bitmap); }
        public override void BlendFunc (uint sfactor, uint dfactor) { glBlendFunc (sfactor, dfactor); }
        public override void CallList (uint list) { glCallList (list); }
        public override void CallLists (int n, uint type, IntPtr lists) { glCallLists (n, type, lists); }
        public override void CallLists (int n, uint type, uint[] lists) { glCallLists (n, type, lists); }
        public override void CallLists (int n, uint type, byte[] lists) { glCallLists (n, type, lists); }
        public override void Clear (uint mask) { glClear (mask); }
        public override void ClearAccum (float red, float green, float blue, float alpha) { glClearAccum (red, green, blue, alpha); }
        public override void ClearColor (float red, float green, float blue, float alpha) { glClearColor (red, green, blue, alpha); }
        public override void ClearDepth (double depth) { glClearDepth (depth); }
        public override void ClearIndex (float c) { glClearIndex (c); }
        public override void ClearStencil (int s) { glClearStencil (s); }
        public override void ClipPlane (uint plane, double[] equation) { glClipPlane (plane, equation); }
        public override void Color3b (byte red, byte green, byte blue) { glColor3b (red, green, blue); }

        public override void Color3bv (byte[] v) { glColor3bv (v); }
        public override void Color3d (double red, double green, double blue) { glColor3d (red, green, blue); }
        public override void Color3dv (double[] v) { glColor3dv (v); }
        public override void Color3f (float red, float green, float blue) { glColor3f (red, green, blue); }
        public override void Color3fv (float[] v) { glColor3fv (v); }
        public override void Color3i (int red, int green, int blue) { glColor3i (red, green, blue); }
        public override void Color3iv (int[] v) { glColor3iv (v); }
        public override void Color3s (short red, short green, short blue) { glColor3s (red, green, blue); }
        public override void Color3sv (short[] v) { glColor3sv (v); }
        public override void Color3ub (byte red, byte green, byte blue) { glColor3ub (red, green, blue); }
        public override void Color3ubv (byte[] v) { glColor3ubv (v); }
        public override void Color3ui (uint red, uint green, uint blue) { glColor3ui (red, green, blue); }
        public override void Color3uiv (uint[] v) { glColor3uiv (v); }
        public override void Color3us (ushort red, ushort green, ushort blue) { glColor3us (red, green, blue); }
        public override void Color3usv (ushort[] v) { glColor3usv (v); }
        public override void Color4b (byte red, byte green, byte blue, byte alpha) { glColor4b (red, green, blue, alpha); }
        public override void Color4bv (byte[] v) { glColor4bv (v); }
        public override void Color4d (double red, double green, double blue, double alpha) { glColor4d (red, green, blue, alpha); }
        public override void Color4dv (double[] v) { glColor4dv (v); }
        public override void Color4f (float red, float green, float blue, float alpha) { glColor4f (red, green, blue, alpha); }
        public override void Color4fv (float[] v) { glColor4fv (v); }
        public override void Color4i (int red, int green, int blue, int alpha) { glColor4i (red, green, blue, alpha); }
        public override void Color4iv (int[] v) { glColor4iv (v); }
        public override void Color4s (short red, short green, short blue, short alpha) { glColor4s (red, green, blue, alpha); }
        public override void Color4sv (short[] v) { glColor4sv (v); }
        public override void Color4ub (byte red, byte green, byte blue, byte alpha) { glColor4ub (red, green, blue, alpha); }
        public override void Color4ubv (byte[] v) { glColor4ubv (v); }
        public override void Color4ui (uint red, uint green, uint blue, uint alpha) { glColor4ui (red, green, blue, alpha); }
        public override void Color4uiv (uint[] v) { glColor4uiv (v); }
        public override void Color4us (ushort red, ushort green, ushort blue, ushort alpha) { glColor4us (red, green, blue, alpha); }
        public override void Color4usv (ushort[] v) { glColor4usv (v); }
        public override void ColorMask (bool redWritable, bool greenWritable, bool blueWritable, bool alphaWritable) { glColorMask (redWritable, greenWritable, blueWritable, alphaWritable); }
        public override void ColorMaterial (uint face, uint mode) { glColorMaterial (face, mode); }
        public override void ColorPointer (int size, uint type, int stride, IntPtr pointer) { glColorPointer (size, type, stride, pointer); }
        public override void CopyPixels (int x, int y, int width, int height, uint type) { glCopyPixels (x, y, width, height, type); }
        public override void CopyTexImage1D (uint target, int level, uint internalFormat, int x, int y, int width, int border) { glCopyTexImage1D (target, level, internalFormat, x, y, width, border); }
        public override void CopyTexImage2D (uint target, int level, uint internalFormat, int x, int y, int width, int height, int border) { glCopyTexImage2D (target, level, internalFormat, x, y, width, height, border); }
        public override void CopyTexSubImage1D (uint target, int level, int xoffset, int x, int y, int width) { glCopyTexSubImage1D (target, level, xoffset, x, y, width); }
        public override void CopyTexSubImage2D (uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height) { glCopyTexSubImage2D (target, level, xoffset, yoffset, x, y, width, height); }
        public override void CullFace (uint mode) { glCullFace (mode); }
        public override void DeleteLists (uint list, int range) { glDeleteLists (list, range); }
        public override void DeleteTextures (int n, uint[] textures) { glDeleteTextures (n, textures); }
        public override void DepthFunc (uint func) { glDepthFunc (func); }
        public override void DepthMask (bool writable) { glDepthMask (writable); }
        public override void DepthRange (double zNear, double zFar) { glDepthRange (zNear, zFar); }
        public override void Disable (uint cap) { glDisable (cap); }
        public override void DisableClientState (uint array) { glDisableClientState (array); }
        public override void DrawArrays (uint mode, int first, int count) { glDrawArrays (mode, first, count); }
        public override void MultiDrawArrays (uint mode, int[] first, int[] count, int drawcount) { glMultiDrawArrays (mode, first, count, drawcount); }
        public override void DrawBuffer (uint mode) { glDrawBuffer (mode); }
        public override void DrawElements (uint mode, int count, uint type, IntPtr indices) { glDrawElements (mode, count, type, indices); }
        public override void DrawElements (uint mode, int count, uint[] indices) { glDrawElements (mode, count, Constants.GL_UNSIGNED_INT, indices); }
        public override void DrawElements (uint mode, int count, ushort[] indices) { glDrawElements (mode, count, Gl.Constants.GL_UNSIGNED_SHORT, indices); }
        public override void DrawElements (uint mode, int count, byte[] indices) { glDrawElements (mode, count, Constants.GL_UNSIGNED_BYTE, indices); }
        public override void DrawPixels (int width, int height, uint format, uint type, float[] pixels) { glDrawPixels (width, height, format, type, pixels); }
        public override void DrawPixels (int width, int height, uint format, uint type, uint[] pixels) { glDrawPixels (width, height, format, type, pixels); }
        public override void DrawPixels (int width, int height, uint format, uint type, ushort[] pixels) { glDrawPixels (width, height, format, type, pixels); }
        public override void DrawPixels (int width, int height, uint format, uint type, byte[] pixels) { glDrawPixels (width, height, format, type, pixels); }
        public override void DrawPixels (int width, int height, uint format, uint type, IntPtr pixels) { glDrawPixels (width, height, format, type, pixels); }
        public override void EdgeFlag (byte flag) { glEdgeFlag (flag); }
        public override void EdgeFlagPointer (int stride, int[] pointer) { glEdgeFlagPointer (stride, pointer); }
        public override void EdgeFlagv (byte[] flag) { glEdgeFlagv (flag); }
        public override void Enable (uint cap) { glEnable (cap); }
        public override void EnableClientState (uint array) { glEnableClientState (array); }

        public override void End () { glEnd (); }
        public override void EndList () { glEndList (); }

        public override void EvalCoord1d (double u) { glEvalCoord1d (u); }
        public override void EvalCoord1dv (double[] u) { glEvalCoord1dv (u); }
        public override void EvalCoord1f (float u) { glEvalCoord1f (u); }
        public override void EvalCoord1fv (float[] u) { glEvalCoord1fv (u); }
        public override void EvalCoord2d (double u, double v) { glEvalCoord2d (u, v); }
        public override void EvalCoord2dv (double[] u) { glEvalCoord2dv (u); }
        public override void EvalCoord2f (float u, float v) { glEvalCoord2f (u, v); }
        public override void EvalCoord2fv (float[] u) { glEvalCoord2fv (u); }
        public override void EvalMesh1 (uint mode, int i1, int i2) { glEvalMesh1 (mode, i1, i2); }
        public override void EvalMesh2 (uint mode, int i1, int i2, int j1, int j2) { glEvalMesh2 (mode, i1, i2, j1, j2); }
        public override void EvalPoint1 (int i) { glEvalPoint1 (i); }
        public override void EvalPoint2 (int i, int j) { glEvalPoint2 (i, j); }
        public override void FeedbackBuffer (int size, uint type, float[] buffer) { glFeedbackBuffer (size, type, buffer); }

        public override void Finish () { glFinish (); }
        public override void Flush () { glFlush (); }
        public override void Fogf (uint pname, float param) { glFogf (pname, param); }
        public override void Fogfv (uint pname, float[] parameters) { glFogfv (pname, parameters); }
        public override void Fogi (uint pname, int param) { glFogi (pname, param); }
        public override void Fogiv (uint pname, int[] parameters) { glFogiv (pname, parameters); }
        public override void FrontFace (uint mode) { glFrontFace (mode); }
        public override void Frustum (double left, double right, double bottom, double top, double zNear, double zFar) { glFrustum (left, right, bottom, top, zNear, zFar); }
        public override uint GenLists (int range) { return glGenLists (range); }
        public override void GenTextures (int n, uint[] textures) { glGenTextures (n, textures); }
        public override void GetBooleanv (uint pname, byte[] parameters) { glGetBooleanv (pname, parameters); }
        public override void GetClipPlane (uint plane, double[] equation) { glGetClipPlane (plane, equation); }
        public override void GetDoublev (uint pname, double[] parameters) { glGetDoublev (pname, parameters); }
        public override uint GetError () { return glGetError (); }
        public override void GetFloatv (uint pname, float[] parameters) { glGetFloatv (pname, parameters); }
        public override void GetIntegerv (uint pname, int[] parameters) { glGetIntegerv (pname, parameters); }
        public override void GetLightfv (uint light, uint pname, float[] parameters) { glGetLightfv (light, pname, parameters); }
        public override void GetLightiv (uint light, uint pname, int[] parameters) { glGetLightiv (light, pname, parameters); }
        public override void GetMapdv (uint target, uint query, double[] v) { glGetMapdv (target, query, v); }
        public override void GetMapfv (uint target, uint query, float[] v) { glGetMapfv (target, query, v); }
        public override void GetMapiv (uint target, uint query, int[] v) { glGetMapiv (target, query, v); }
        public override void GetMaterialfv (uint face, uint pname, float[] parameters) { glGetMaterialfv (face, pname, parameters); }
        public override void GetMaterialiv (uint face, uint pname, int[] parameters) { glGetMaterialiv (face, pname, parameters); }
        public override void GetPixelMapfv (uint map, float[] values) { glGetPixelMapfv (map, values); }
        public override void GetPixelMapuiv (uint map, uint[] values) { glGetPixelMapuiv (map, values); }
        public override void GetPixelMapusv (uint map, ushort[] values) { glGetPixelMapusv (map, values); }
        public override void GetPointerv (uint pname, int[] parameters) { glGetPointerv (pname, parameters); }
        public override void GetPolygonStipple (byte[] mask) { glGetPolygonStipple (mask); }
        public override string GetString (uint name) { unsafe { return new string (glGetString (name)); } }
        public override void GetTexEnvfv (uint target, uint pname, float[] parameters) { glGetTexEnvfv (target, pname, parameters); }
        public override void GetTexEnviv (uint target, uint pname, int[] parameters) { glGetTexEnviv (target, pname, parameters); }
        public override void GetTexGendv (uint coord, uint pname, double[] parameters) { glGetTexGendv (coord, pname, parameters); }
        public override void GetTexGenfv (uint coord, uint pname, float[] parameters) { glGetTexGenfv (coord, pname, parameters); }
        public override void GetTexGeniv (uint coord, uint pname, int[] parameters) { glGetTexGeniv (coord, pname, parameters); }
        public override void GetTexImage (uint target, int level, uint format, uint type, IntPtr pixels) { glGetTexImage (target, level, format, type, pixels); }
        public override void GetTexLevelParameterfv (uint target, int level, uint pname, float[] parameters) { glGetTexLevelParameterfv (target, level, pname, parameters); }
        public override void GetTexLevelParameteriv (uint target, int level, uint pname, int[] parameters) { glGetTexLevelParameteriv (target, level, pname, parameters); }
        public override void GetTexParameterfv (uint target, uint pname, float[] parameters) { glGetTexParameterfv (target, pname, parameters); }
        public override void GetTexParameteriv (uint target, uint pname, int[] parameters) { glGetTexParameteriv (target, pname, parameters); }
        public override void Hint (uint target, uint mode) { glHint (target, mode); }
        public override void IndexMask (uint mask) { glIndexMask (mask); }
        public override void IndexPointer (uint type, int stride, int[] pointer) { glIndexPointer (type, stride, pointer); }
        public override void Indexd (double c) { glIndexd (c); }
        public override void Indexdv (double[] c) { glIndexdv (c); }
        public override void Indexf (float c) { glIndexf (c); }
        public override void Indexfv (float[] c) { glIndexfv (c); }
        public override void Indexi (int c) { glIndexi (c); }
        public override void Indexiv (int[] c) { glIndexiv (c); }
        public override void Indexs (short c) { glIndexs (c); }
        public override void Indexsv (short[] c) { glIndexsv (c); }
        public override void Indexub (byte c) { glIndexub (c); }
        public override void Indexubv (byte[] c) { glIndexubv (c); }
        public override void InitNames () { glInitNames (); }
        public override void InterleavedArrays (uint format, int stride, int[] pointer) { glInterleavedArrays (format, stride, pointer); }
        public override byte IsEnabled (uint cap) { return glIsEnabled (cap); }
        public override byte IsList (uint list) { return glIsList (list); }
        public override byte IsTexture (uint texture) { return glIsTexture (texture); }
        public override void LightModelf (uint pname, float param) { glLightModelf (pname, param); }
        public override void LightModelfv (uint pname, float[] parameters) { glLightModelfv (pname, parameters); }
        public override void LightModeli (uint pname, int param) { glLightModeli (pname, param); }
        public override void LightModeliv (uint pname, int[] parameters) { glLightModeliv (pname, parameters); }
        public override void Lightf (uint light, uint pname, float param) { glLightf (light, pname, param); }
        public override void Lightfv (uint light, uint pname, float[] parameters) { glLightfv (light, pname, parameters); }
        public override void Lighti (uint light, uint pname, int param) { glLighti (light, pname, param); }
        public override void Lightiv (uint light, uint pname, int[] parameters) { glLightiv (light, pname, parameters); }
        public override void LineStipple (int factor, ushort pattern) { glLineStipple (factor, pattern); }
        public override void LineWidth (float width) { glLineWidth (width); }
        public override void ListBase (uint listbase) { glListBase (listbase); }
        public override void LoadIdentity () { glLoadIdentity (); }
        public override void LoadMatrixd (double[] m) { glLoadMatrixd (m); }
        public override void LoadMatrixf (float[] m) { glLoadMatrixf (m); }
        public override void LoadName (uint name) { glLoadName (name); }
        public override void LogicOp (uint opcode) { glLogicOp (opcode); }
        public override void Map1d (uint target, double u1, double u2, int stride, int order, IntPtr points) { glMap1d (target, u1, u2, stride, order, points); }
        public override void Map1f (uint target, float u1, float u2, int stride, int order, IntPtr points) { glMap1f (target, u1, u2, stride, order, points); }
        public override void Map2d (uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, IntPtr points) { glMap2d (target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points); }
        public override void Map2f (uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, IntPtr points) { glMap2f (target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points); }
        public override void MapGrid1d (int un, double u1, double u2) { glMapGrid1d (un, u1, u2); }
        public override void MapGrid1f (int un, float u1, float u2) { glMapGrid1f (un, u1, u2); }
        public override void MapGrid2d (int un, double u1, double u2, int vn, double v1, double v2) { glMapGrid2d (un, u1, u2, vn, v1, v2); }
        public override void MapGrid2f (int un, float u1, float u2, int vn, float v1, float v2) { glMapGrid2f (un, u1, u2, vn, v1, v2); }
        public override void Materialf (uint face, uint pname, float param) { glMaterialf (face, pname, param); }
        public override void Materialfv (uint face, uint pname, float[] parameters) { glMaterialfv (face, pname, parameters); }
        public override void Materiali (uint face, uint pname, int param) { glMateriali (face, pname, param); }
        public override void Materialiv (uint face, uint pname, int[] parameters) { glMaterialiv (face, pname, parameters); }
        public override void MatrixMode (uint mode) { glMatrixMode (mode); }
        public override void MultMatrixd (double[] m) { glMultMatrixd (m); }
        public override void MultMatrixf (float[] m) { glMultMatrixf (m); }
        public override void NewList (uint list, uint mode) { glNewList (list, mode); }
        public override void Normal3b (byte nx, byte ny, byte nz) { glNormal3b (nx, ny, nz); }
        public override void Normal3bv (byte[] v) { glNormal3bv (v); }
        public override void Normal3d (double nx, double ny, double nz) { glNormal3d (nx, ny, nz); }
        public override void Normal3dv (double[] v) { glNormal3dv (v); }
        public override void Normal3f (float nx, float ny, float nz) { glNormal3f (nx, ny, nz); }
        public override void Normal3fv (float[] v) { glNormal3fv (v); }
        public override void Normal3i (int nx, int ny, int nz) { glNormal3i (nx, ny, nz); }
        public override void Normal3iv (int[] v) { glNormal3iv (v); }
        public override void Normal3s (short nx, short ny, short nz) { glNormal3s (nx, ny, nz); }
        public override void Normal3sv (short[] v) { glNormal3sv (v); }
        public override void NormalPointer (uint type, int stride, IntPtr pointer) { glNormalPointer (type, stride, pointer); }
        public override void NormalPointer (uint type, int stride, float[] pointer) { glNormalPointer (type, stride, pointer); }
        public override void Ortho (double left, double right, double bottom, double top, double zNear, double zFar) { glOrtho (left, right, bottom, top, zNear, zFar); }
        public override void PassThrough (float token) { glPassThrough (token); }
        public override void PixelMapfv (uint map, int mapsize, float[] values) { glPixelMapfv (map, mapsize, values); }
        public override void PixelMapuiv (uint map, int mapsize, uint[] values) { glPixelMapuiv (map, mapsize, values); }
        public override void PixelMapusv (uint map, int mapsize, ushort[] values) { glPixelMapusv (map, mapsize, values); }
        public override void PixelStoref (uint pname, float param) { glPixelStoref (pname, param); }
        public override void PixelStorei (uint pname, int param) { glPixelStorei (pname, param); }
        public override void PixelTransferf (uint pname, float param) { glPixelTransferf (pname, param); }
        public override void PixelTransferi (uint pname, int param) { glPixelTransferi (pname, param); }
        public override void PixelZoom (float xfactor, float yfactor) { glPixelZoom (xfactor, yfactor); }
        public override void PointSize (float size) { glPointSize (size); }
        public override void PolygonMode (uint face, uint mode) { glPolygonMode (face, mode); }
        public override void PolygonOffset (float factor, float units) { glPolygonOffset (factor, units); }
        public override void PolygonStipple (byte[] mask) { glPolygonStipple (mask); }
        public override void PopAttrib () { glPopAttrib (); }
        public override void PopClientAttrib () { glPopClientAttrib (); }
        public override void PopMatrix () { glPopMatrix (); }
        public override void PopName () { glPopName (); }
        public override void PrioritizeTextures (int n, uint[] textures, float[] priorities) { glPrioritizeTextures (n, textures, priorities); }
        public override void PushAttrib (uint mask) { glPushAttrib (mask); }
        public override void PushClientAttrib (uint mask) { glPushClientAttrib (mask); }
        public override void PushMatrix () { glPushMatrix (); }
        public override void PushName (uint name) { glPushName (name); }
        public override void RasterPos2d (double x, double y) { glRasterPos2d (x, y); }
        public override void RasterPos2dv (double[] v) { glRasterPos2dv (v); }
        public override void RasterPos2f (float x, float y) { glRasterPos2f (x, y); }
        public override void RasterPos2fv (float[] v) { glRasterPos2fv (v); }
        public override void RasterPos2i (int x, int y) { glRasterPos2i (x, y); }
        public override void RasterPos2iv (int[] v) { glRasterPos2iv (v); }
        public override void RasterPos2s (short x, short y) { glRasterPos2s (x, y); }
        public override void RasterPos2sv (short[] v) { glRasterPos2sv (v); }
        public override void RasterPos3d (double x, double y, double z) { glRasterPos3d (x, y, z); }
        public override void RasterPos3dv (double[] v) { glRasterPos3dv (v); }
        public override void RasterPos3f (float x, float y, float z) { glRasterPos3f (x, y, z); }
        public override void RasterPos3fv (float[] v) { glRasterPos3fv (v); }
        public override void RasterPos3i (int x, int y, int z) { glRasterPos3i (x, y, z); }
        public override void RasterPos3iv (int[] v) { glRasterPos3iv (v); }
        public override void RasterPos3s (short x, short y, short z) { glRasterPos3s (x, y, z); }
        public override void RasterPos3sv (short[] v) { glRasterPos3sv (v); }
        public override void RasterPos4d (double x, double y, double z, double w) { glRasterPos4d (x, y, z, w); }
        public override void RasterPos4dv (double[] v) { glRasterPos4dv (v); }
        public override void RasterPos4f (float x, float y, float z, float w) { glRasterPos4f (x, y, z, w); }
        public override void RasterPos4fv (float[] v) { glRasterPos4fv (v); }
        public override void RasterPos4i (int x, int y, int z, int w) { glRasterPos4i (x, y, z, w); }
        public override void RasterPos4iv (int[] v) { glRasterPos4iv (v); }
        public override void RasterPos4s (short x, short y, short z, short w) { glRasterPos4s (x, y, z, w); }
        public override void RasterPos4sv (short[] v) { glRasterPos4sv (v); }
        public override void ReadBuffer (uint mode) { glReadBuffer (mode); }
        public override void ReadPixels (int x, int y, int width, int height, uint format, uint type, byte[] pixels) { glReadPixels (x, y, width, height, format, type, pixels); }
        public override void ReadPixels (int x, int y, int width, int height, uint format, uint type, IntPtr pixels) { glReadPixels (x, y, width, height, format, type, pixels); }
        public override void Rectd (double x1, double y1, double x2, double y2) { glRectd (x1, y1, x2, y2); }
        public override void Rectdv (double[] v1, double[] v2) { glRectdv (v1, v2); }
        public override void Rectf (float x1, float y1, float x2, float y2) { glRectf (x1, y1, x2, y2); }
        public override void Rectfv (float[] v1, float[] v2) { glRectfv (v1, v2); }
        public override void Recti (int x1, int y1, int x2, int y2) { glRecti (x1, y1, x2, y2); }
        public override void Rectiv (int[] v1, int[] v2) { glRectiv (v1, v2); }
        public override void Rects (short x1, short y1, short x2, short y2) { glRects (x1, y1, x2, y2); }
        public override void Rectsv (short[] v1, short[] v2) { glRectsv (v1, v2); }
        public override int RenderMode (uint mode) { return glRenderMode (mode); }

        public override void Rotated (double angle, double x, double y, double z) { glRotated (angle, x, y, z); }
        public override void Rotatef (float angle, float x, float y, float z) { glRotatef (angle, x, y, z); }
        public override void Scaled (double x, double y, double z) { glScaled (x, y, z); }
        public override void Scalef (float x, float y, float z) { glScalef (x, y, z); }
        public override void Scissor (int x, int y, int width, int height) { glScissor (x, y, width, height); }
        public override void SelectBuffer (int size, uint[] buffer) { glSelectBuffer (size, buffer); }
        public override void ShadeModel (uint mode) { glShadeModel (mode); }
        public override void StencilFunc (uint func, int reference, uint mask) { glStencilFunc (func, reference, mask); }
        public override void StencilMask (uint mask) { glStencilMask (mask); }
        public override void StencilOp (uint fail, uint zfail, uint zpass) { glStencilOp (fail, zfail, zpass); }
        public override void TexCoord1d (double s) { glTexCoord1d (s); }
        public override void TexCoord1dv (double[] v) { glTexCoord1dv (v); }
        public override void TexCoord1f (float s) { glTexCoord1f (s); }
        public override void TexCoord1fv (float[] v) { glTexCoord1fv (v); }
        public override void TexCoord1i (int s) { glTexCoord1i (s); }
        public override void TexCoord1iv (int[] v) { glTexCoord1iv (v); }
        public override void TexCoord1s (short s) { glTexCoord1s (s); }
        public override void TexCoord1sv (short[] v) { glTexCoord1sv (v); }
        public override void TexCoord2d (double s, double t) { glTexCoord2d (s, t); }
        public override void TexCoord2dv (double[] v) { glTexCoord2dv (v); }
        public override void TexCoord2f (float s, float t) { glTexCoord2f (s, t); }
        public override void TexCoord2fv (float[] v) { glTexCoord2fv (v); }
        public override void TexCoord2i (int s, int t) { glTexCoord2i (s, t); }
        public override void TexCoord2iv (int[] v) { glTexCoord2iv (v); }
        public override void TexCoord2s (short s, short t) { glTexCoord2s (s, t); }
        public override void TexCoord2sv (short[] v) { glTexCoord2sv (v); }
        public override void TexCoord3d (double s, double t, double r) { glTexCoord3d (s, t, r); }
        public override void TexCoord3dv (double[] v) { glTexCoord3dv (v); }
        public override void TexCoord3f (float s, float t, float r) { glTexCoord3f (s, t, r); }
        public override void TexCoord3fv (float[] v) { glTexCoord3fv (v); }
        public override void TexCoord3i (int s, int t, int r) { glTexCoord3i (s, t, r); }
        public override void TexCoord3iv (int[] v) { glTexCoord3iv (v); }
        public override void TexCoord3s (short s, short t, short r) { glTexCoord3s (s, t, r); }
        public override void TexCoord3sv (short[] v) { glTexCoord3sv (v); }
        public override void TexCoord4d (double s, double t, double r, double q) { glTexCoord4d (s, t, r, q); }
        public override void TexCoord4dv (double[] v) { glTexCoord4dv (v); }
        public override void TexCoord4f (float s, float t, float r, float q) { glTexCoord4f (s, t, r, q); }
        public override void TexCoord4fv (float[] v) { glTexCoord4fv (v); }
        public override void TexCoord4i (int s, int t, int r, int q) { glTexCoord4i (s, t, r, q); }
        public override void TexCoord4iv (int[] v) { glTexCoord4iv (v); }
        public override void TexCoord4s (short s, short t, short r, short q) { glTexCoord4s (s, t, r, q); }
        public override void TexCoord4sv (short[] v) { glTexCoord4sv (v); }
        public override void TexCoordPointer (int size, uint type, int stride, IntPtr pointer) { glTexCoordPointer (size, type, stride, pointer); }
        public override void TexCoordPointer (int size, uint type, int stride, float[] pointer) { glTexCoordPointer (size, type, stride, pointer); }
        public override void TexEnvf (uint target, uint pname, float param) { glTexEnvf (target, pname, param); }
        public override void TexEnvfv (uint target, uint pname, float[] parameters) { glTexEnvfv (target, pname, parameters); }
        public override void TexEnvi (uint target, uint pname, int param) { glTexEnvi (target, pname, param); }
        public override void TexEnviv (uint target, uint pname, int[] parameters) { glTexEnviv (target, pname, parameters); }
        public override void TexGend (uint coord, uint pname, double param) { glTexGend (coord, pname, param); }
        public override void TexGendv (uint coord, uint pname, double[] parameters) { glTexGendv (coord, pname, parameters); }
        public override void TexGenf (uint coord, uint pname, float param) { glTexGenf (coord, pname, param); }
        public override void TexGenfv (uint coord, uint pname, float[] parameters) { glTexGenfv (coord, pname, parameters); }
        public override void TexGeni (uint coord, uint pname, int param) { glTexGeni (coord, pname, param); }
        public override void TexGeniv (uint coord, uint pname, int[] parameters) { glTexGeniv (coord, pname, parameters); }

        public override void TexImage1D (uint target, int level, uint internalformat, int width, int border, uint format, uint type, IntPtr pixels) { glTexImage1D (target, level, internalformat, width, border, format, type, pixels); }
        public override void TexImage2D (uint target, int level, uint internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels) { glTexImage2D (target, level, internalformat, width, height, border, format, type, pixels); }
        public override void TexParameterf (uint target, uint pname, float param) { glTexParameterf (target, pname, param); }
        public override void TexParameterfv (uint target, uint pname, float[] parameters) { glTexParameterfv (target, pname, parameters); }
        public override void TexParameteri (uint target, uint pname, int param) { glTexParameteri (target, pname, param); }
        public override void TexParameteriv (uint target, uint pname, int[] parameters) { glTexParameteriv (target, pname, parameters); }
        public override void TexSubImage1D (uint target, int level, int xoffset, int width, uint format, uint type, int[] pixels) { glTexSubImage1D (target, level, xoffset, width, format, type, pixels); }
        public override void TexSubImage1D (uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels) { glTexSubImage1D (target, level, xoffset, width, format, type, pixels); }
        public override void TexSubImage2D (uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, int[] pixels) { glTexSubImage2D (target, level, xoffset, yoffset, width, height, format, type, pixels); }
        public override void TexSubImage2D (uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels) { glTexSubImage2D (target, level, xoffset, yoffset, width, height, format, type, pixels); }

        public override void Translated (double x, double y, double z) { glTranslated (x, y, z); }
        public override void Translatef (float x, float y, float z) { glTranslatef (x, y, z); }
        public override void Vertex2d (double x, double y) { glVertex2d (x, y); }
        public override void Vertex2dv (double[] v) { glVertex2dv (v); }
        public override void Vertex2f (float x, float y) { glVertex2f (x, y); }
        public override void Vertex2fv (float[] v) { glVertex2fv (v); }
        public override void Vertex2i (int x, int y) { glVertex2i (x, y); }
        public override void Vertex2iv (int[] v) { glVertex2iv (v); }
        public override void Vertex2s (short x, short y) { glVertex2s (x, y); }
        public override void Vertex2sv (short[] v) { glVertex2sv (v); }
        public override void Vertex3d (double x, double y, double z) { glVertex3d (x, y, z); }
        public override void Vertex3dv (double[] v) { glVertex3dv (v); }
        public override void Vertex3f (float x, float y, float z) { glVertex3f (x, y, z); }
        public override void Vertex3fv (float[] v) { glVertex3fv (v); }
        public override void Vertex3i (int x, int y, int z) { glVertex3i (x, y, z); }
        public override void Vertex3iv (int[] v) { glVertex3iv (v); }
        public override void Vertex3s (short x, short y, short z) { glVertex3s (x, y, z); }
        public override void Vertex3sv (short[] v) { glVertex3sv (v); }
        public override void Vertex4d (double x, double y, double z, double w) { glVertex4d (x, y, z, w); }
        public override void Vertex4dv (double[] v) { glVertex4dv (v); }
        public override void Vertex4f (float x, float y, float z, float w) { glVertex4f (x, y, z, w); }
        public override void Vertex4fv (float[] v) { glVertex4fv (v); }
        public override void Vertex4i (int x, int y, int z, int w) { glVertex4i (x, y, z, w); }
        public override void Vertex4iv (int[] v) { glVertex4iv (v); }
        public override void Vertex4s (short x, short y, short z, short w) { glVertex4s (x, y, z, w); }
        public override void Vertex4sv (short[] v) { glVertex4sv (v); }
        public override void VertexPointer (int size, uint type, int stride, IntPtr pointer) { glVertexPointer (size, type, stride, pointer); }
        public override void VertexPointer (int size, uint type, int stride, short[] pointer) { glVertexPointer (size, type, stride, pointer); }
        public override void VertexPointer (int size, uint type, int stride, int[] pointer) { glVertexPointer (size, type, stride, pointer); }
        public override void VertexPointer (int size, uint type, int stride, float[] pointer) { glVertexPointer (size, type, stride, pointer); }
        public override void VertexPointer (int size, uint type, int stride, double[] pointer) { glVertexPointer (size, type, stride, pointer); }
        public override void Viewport (int x, int y, int width, int height) { glViewport (x, y, width, height); }

        #endregion

        private static readonly Dictionary<string, Delegate> extensionFunctions = new Dictionary<string, Delegate> ();
        public static Delegate GetDelegateFor (string functionName, Type functionDeclaration) {
            Delegate del = null;
            if (!extensionFunctions.TryGetValue (functionName, out del)) {
                IntPtr proc = GetProc (functionName);
                if (proc != IntPtr.Zero) {
                    del = Marshal.GetDelegateForFunctionPointer (proc, functionDeclaration);
                    extensionFunctions.Add (functionName, del);
                }
            }
            return del;
        }

        private static IntPtr GetProc (string name) {
            IntPtr proc = IntPtr.Zero;
            proc = Win32.wglGetProcAddress (name);
            long pointer = proc.ToInt64 ();
            if (-1 <= pointer && pointer <= 3) {
                proc = Win32.GetProcAddress (name);
                pointer = proc.ToInt64 ();
                if (-1 <= pointer && pointer <= 3) {
                    proc = IntPtr.Zero;
                }
            }
            return proc;
        }
    }
}
#endif