#if graphics && gl
using System;

namespace Anura.Graphics.Gl
{
    public enum BlendDestFactor : uint
    {
        Zero = Constants.GL_ZERO,
        One = Constants.GL_ONE,
        SrcColor = Constants.GL_SRC_COLOR,
        OneMinusSrcColor = Constants.GL_ONE_MINUS_SRC_COLOR,
        DstColor = Constants.GL_DST_COLOR,
        OneMinusDstColor = Constants.GL_ONE_MINUS_DST_COLOR,
        SrcAlpha = Constants.GL_SRC_ALPHA,
        OneMinusSrcAlpha = Constants.GL_ONE_MINUS_SRC_ALPHA,
        DstAlpha = Constants.GL_DST_ALPHA,
        OneMinusDstAlpha = Constants.GL_ONE_MINUS_DST_ALPHA,
        ConstantColor = Constants.GL_CONSTANT_COLOR,
        OneMinusConstantColor = Constants.GL_ONE_MINUS_CONSTANT_COLOR,
        ConstantAlpha = Constants.GL_CONSTANT_ALPHA,
        OneMinusConstantAlpha = Constants.GL_ONE_MINUS_CONSTANT_ALPHA,
    }

    public enum BlendSrcFactor : uint
    {
        One = Constants.GL_ONE,
        Zero = Constants.GL_ZERO,
        SrcColor = Constants.GL_SRC_COLOR,
        OneMinusSrcColor = Constants.GL_ONE_MINUS_SRC_COLOR,
        DstColor = Constants.GL_DST_COLOR,
        OneMinusDstColor = Constants.GL_ONE_MINUS_DST_COLOR,
        SrcAlpha = Constants.GL_SRC_ALPHA,
        OneMinusSrcAlpha = Constants.GL_ONE_MINUS_SRC_ALPHA,
        DstAlpha = Constants.GL_DST_ALPHA,
        OneMinusDstAlpha = Constants.GL_ONE_MINUS_DST_ALPHA,
        ConstantColor = Constants.GL_CONSTANT_COLOR,
        OneMinusConstantColor = Constants.GL_ONE_MINUS_CONSTANT_COLOR,
        ConstantAlpha = Constants.GL_CONSTANT_ALPHA,
        OneMinusConstantAlpha = Constants.GL_ONE_MINUS_CONSTANT_ALPHA,
        SrcAlphaSaturate = Constants.GL_SRC_ALPHA_SATURATE,
    }

    public enum BlendEquationMode : uint
    {
        Add = Constants.GL_FUNC_ADD,
        Subtract = Constants.GL_FUNC_SUBTRACT,
        ReverseSubtract = Constants.GL_FUNC_REVERSE_SUBTRACT,
        Min = Constants.GL_MIN,
        Max = Constants.GL_MAX,
    }
}
#endif