#if graphics && gl
using System;

namespace Anura.Graphics.Gl {

    internal enum BlendDestFactor : uint {
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

    internal enum BlendSrcFactor : uint {
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

    internal enum BlendEquationMode : uint {
        Add = Constants.GL_FUNC_ADD,
        Subtract = Constants.GL_FUNC_SUBTRACT,
        ReverseSubtract = Constants.GL_FUNC_REVERSE_SUBTRACT,
        Min = Constants.GL_MIN,
        Max = Constants.GL_MAX,
    }

    internal enum BufferTarget : uint {
        ArrayBuffer = Constants.GL_ARRAY_BUFFER,
        ElementArrayBuffer = Constants.GL_ELEMENT_ARRAY_BUFFER,
        UniformBuffer = Constants.GL_UNIFORM_BUFFER,
        TransformFeedbackBuffer = Constants.GL_TRANSFORM_FEEDBACK_BUFFER,
        PixelUnpackBuffer = Constants.GL_PIXEL_UNPACK_BUFFER,
        PixelPackBuffer = Constants.GL_PIXEL_PACK_BUFFER,
        AtomicCounterBuffer = Constants.GL_ATOMIC_COUNTER_BUFFER,
        TextureBuffer = Constants.GL_TEXTURE_BUFFER,
        ShaderStorageBuffer = Constants.GL_SHADER_STORAGE_BUFFER,
    }

    /// <summary>
    /// * Static: 只需要一次指定缓冲区对象中的数据,但使用次数很多.
    /// * Dynamic: 数据不仅需要时常更新,使用次数也很多.
    /// * Stream: 缓冲区的对象需要时常更新,但使用次数很少.
    /// * Draw: 数据作为顶点数据,用于渲染.
    /// * Read: 数据从一个OpenGL缓冲区(桢缓冲区之类的)读取,并在程序中与渲染并不直接相关的各种计算过程中使用.
    /// * Copy: 数据从一个OpenGL缓冲区读取,然后作为顶点数据,用于渲染.
    /// </summary>
    internal enum BufferUsage : uint {
        StreamDraw = Constants.GL_STREAM_DRAW, 
        StreamRead = Constants.GL_STREAM_READ, 
        StreamCopy = Constants.GL_STREAM_COPY, 
        StaticDraw = Constants.GL_STATIC_DRAW, 
        StaticRead = Constants.GL_STATIC_READ, 
        StaticCopy = Constants.GL_STATIC_COPY, 
        DynamicDraw = Constants.GL_DYNAMIC_DRAW, 
        DynamicRead = Constants.GL_DYNAMIC_READ, 
        DynamicCopy = Constants.GL_DYNAMIC_COPY, 
    }

    internal enum CubemapFace : uint {
        PositiveX = Constants.GL_TEXTURE_CUBE_MAP_POSITIVE_X,
        NegtiveX = Constants.GL_TEXTURE_CUBE_MAP_NEGATIVE_X,
        PositiveY = Constants.GL_TEXTURE_CUBE_MAP_POSITIVE_Y,
        NegtiveY = Constants.GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,
        PositiveZ = Constants.GL_TEXTURE_CUBE_MAP_POSITIVE_Z,
        NegtiveZ = Constants.GL_TEXTURE_CUBE_MAP_NEGATIVE_Z,
    }

    internal enum DrawMode : uint {
        Points = Constants.GL_POINTS,
        Lines = Constants.GL_LINES,
        LineLoop = Constants.GL_LINE_LOOP,
        LineStrip = Constants.GL_LINE_STRIP,
        Triangles = Constants.GL_TRIANGLES,
        TriangleStrip = Constants.GL_TRIANGLE_STRIP,
        TriangleFan = Constants.GL_TRIANGLE_FAN,
        Quads = Constants.GL_QUADS,
        QuadStrip = Constants.GL_QUAD_STRIP,
        Polygon = Constants.GL_POLYGON,
        LinesAdjacency = Constants.GL_LINES_ADJACENCY,
        LineStripAdjacency = Constants.GL_LINE_STRIP_ADJACENCY,
        TrianglesAdjacency = Constants.GL_TRIANGLES_ADJACENCY,
        TriangleStripAdjacency = Constants.GL_TRIANGLE_STRIP_ADJACENCY,
        Patches = Constants.GL_PATCHES,
    }

    internal enum ErrorCode : uint {
        // 自上次调用glGetError以来没有错误。
        NoError = Constants.GL_NO_ERROR,
        // 枚举参数不合法。
        InvalidEnum = Constants.GL_INVALID_ENUM,
        // 值参数不合法。
        InvalidValue = Constants.GL_INVALID_VALUE,
        // 一个指令的状态对指令的参数不合法。
        InvalidOperation = Constants.GL_INVALID_OPERATION,
        // 压栈操作造成栈上溢(Overflow)。
        StackOverflow = Constants.GL_STACK_OVERFLOW,
        // 弹栈操作时栈在最低点（译注：即栈下溢(Underflow)）。
        StackUnderflow = Constants.GL_STACK_UNDERFLOW,
        // 内存调用操作无法调用（足够的）内存。
        OutOfMemory = Constants.GL_OUT_OF_MEMORY,
        // 读取或写入一个不完整的帧缓冲。
        InvalidFramebufferOperation = Constants.GL_INVALID_FRAMEBUFFER_OPERATION,
    }

    internal enum FrontFaceMode : uint {
        // 窗口坐标上投影多边形的顶点顺序为逆时针方向的表面为正面。
        CCW = Constants.GL_CCW,
        // 顶点顺序为顺时针方向的表面为正面。
        CW = Constants.GL_CW,
    }

    internal enum GetTarget : uint {
        CurrentColor = Constants.GL_CURRENT_COLOR,
        CurrentIndex = Constants.GL_CURRENT_INDEX,
        CurrentNormal = Constants.GL_CURRENT_NORMAL,
        CurrentTextureCoords = Constants.GL_CURRENT_TEXTURE_COORDS,
        CurrentRasterColor = Constants.GL_CURRENT_RASTER_COLOR,
        CurrentRasterIndex = Constants.GL_CURRENT_RASTER_INDEX,
        CurrentRasterTextureCoords = Constants.GL_CURRENT_RASTER_TEXTURE_COORDS,
        CurrentRasterPosition = Constants.GL_CURRENT_RASTER_POSITION,
        CurrentRasterPositionValid = Constants.GL_CURRENT_RASTER_POSITION_VALID,
        CurrentRasterDistance = Constants.GL_CURRENT_RASTER_DISTANCE,
        PointSmooth = Constants.GL_POINT_SMOOTH,
        PointSize = Constants.GL_POINT_SIZE,
        PointSizeRange = Constants.GL_POINT_SIZE_RANGE,
        PointSizeGranularity = Constants.GL_POINT_SIZE_GRANULARITY,
        LineSmooth = Constants.GL_LINE_SMOOTH,
        LineWidth = Constants.GL_LINE_WIDTH,
        LineWidthRange = Constants.GL_LINE_WIDTH_RANGE,
        LineWidthGranularity = Constants.GL_LINE_WIDTH_GRANULARITY,
        LineStipple = Constants.GL_LINE_STIPPLE,
        LineStipplePattern = Constants.GL_LINE_STIPPLE_PATTERN,
        LineStippleRepeat = Constants.GL_LINE_STIPPLE_REPEAT,
        ListMode = Constants.GL_LIST_MODE,
        MaxListNesting = Constants.GL_MAX_LIST_NESTING,
        ListBase = Constants.GL_LIST_BASE,
        ListIndex = Constants.GL_LIST_INDEX,
        PolygonMode = Constants.GL_POLYGON_MODE,
        PolygonSmooth = Constants.GL_POLYGON_SMOOTH,
        PolygonStipple = Constants.GL_POLYGON_STIPPLE,
        EdgeFlag = Constants.GL_EDGE_FLAG,
        CullFace = Constants.GL_CULL_FACE,
        CullFaceMode = Constants.GL_CULL_FACE_MODE,
        FrontFace = Constants.GL_FRONT_FACE,
        Lighting = Constants.GL_LIGHTING,
        LightModelLocalViewer = Constants.GL_LIGHT_MODEL_LOCAL_VIEWER,
        LightModelTwoSide = Constants.GL_LIGHT_MODEL_TWO_SIDE,
        LightModelAmbient = Constants.GL_LIGHT_MODEL_AMBIENT,
        ShadeModel = Constants.GL_SHADE_MODEL,
        ColorMaterialFace = Constants.GL_COLOR_MATERIAL_FACE,
        ColorMaterialParameter = Constants.GL_COLOR_MATERIAL_PARAMETER,
        ColorMaterial = Constants.GL_COLOR_MATERIAL,
        Fog = Constants.GL_FOG,
        FogIndex = Constants.GL_FOG_INDEX,
        FogDensity = Constants.GL_FOG_DENSITY,
        FogStart = Constants.GL_FOG_START,
        FogEnd = Constants.GL_FOG_END,
        FogMode = Constants.GL_FOG_MODE,
        FogColor = Constants.GL_FOG_COLOR,
        DepthRange = Constants.GL_DEPTH_RANGE,
        DepthTest = Constants.GL_DEPTH_TEST,
        DepthWritemask = Constants.GL_DEPTH_WRITEMASK,
        DepthClearValue = Constants.GL_DEPTH_CLEAR_VALUE,
        DepthFunc = Constants.GL_DEPTH_FUNC,
        AccumClearValue = Constants.GL_ACCUM_CLEAR_VALUE,
        StencilTest = Constants.GL_STENCIL_TEST,
        StencilClearValue = Constants.GL_STENCIL_CLEAR_VALUE,
        StencilFunc = Constants.GL_STENCIL_FUNC,
        StencilValueMask = Constants.GL_STENCIL_VALUE_MASK,
        StencilFail = Constants.GL_STENCIL_FAIL,
        StencilPassDepthFail = Constants.GL_STENCIL_PASS_DEPTH_FAIL,
        StencilPassDepthPass = Constants.GL_STENCIL_PASS_DEPTH_PASS,
        StencilRef = Constants.GL_STENCIL_REF,
        StencilWritemask = Constants.GL_STENCIL_WRITEMASK,
        StencilBackWritemask = Constants.GL_STENCIL_BACK_WRITEMASK,
        MatrixMode = Constants.GL_MATRIX_MODE,
        Normalize = Constants.GL_NORMALIZE,
        Viewport = Constants.GL_VIEWPORT,
        ModelviewStackDepth = Constants.GL_MODELVIEW_STACK_DEPTH,
        ProjectionStackDepth = Constants.GL_PROJECTION_STACK_DEPTH,
        TextureStackDepth = Constants.GL_TEXTURE_STACK_DEPTH,
        ModelviewMatix = Constants.GL_MODELVIEW_MATRIX,
        ProjectionMatrix = Constants.GL_PROJECTION_MATRIX,
        TextureMatrix = Constants.GL_TEXTURE_MATRIX,
        AttribStackDepth = Constants.GL_ATTRIB_STACK_DEPTH,
        ClientAttribStackDepth = Constants.GL_CLIENT_ATTRIB_STACK_DEPTH,
        AlphaTest = Constants.GL_ALPHA_TEST,
        AlphaTestFunc = Constants.GL_ALPHA_TEST_FUNC,
        AlphaTestRef = Constants.GL_ALPHA_TEST_REF,
        Dither = Constants.GL_DITHER,
        BlendDst = Constants.GL_BLEND_DST,
        BlendSrc = Constants.GL_BLEND_SRC,
        Blend = Constants.GL_BLEND,
        LogicOpMode = Constants.GL_LOGIC_OP_MODE,
        IndexLogicOp = Constants.GL_INDEX_LOGIC_OP,
        ColorLogicOp = Constants.GL_COLOR_LOGIC_OP,
        AuxBuffers = Constants.GL_AUX_BUFFERS,
        DrawBuffer = Constants.GL_DRAW_BUFFER,
        ReadBuffer = Constants.GL_READ_BUFFER,
        ScissorBox = Constants.GL_SCISSOR_BOX,
        ScissorTest = Constants.GL_SCISSOR_TEST,
        IndexClearValue = Constants.GL_INDEX_CLEAR_VALUE,
        IndexWritemask = Constants.GL_INDEX_WRITEMASK,
        ColorClearValue = Constants.GL_COLOR_CLEAR_VALUE,
        ColorWritemask = Constants.GL_COLOR_WRITEMASK,
        IndexMode = Constants.GL_INDEX_MODE,
        RgbaMode = Constants.GL_RGBA_MODE,
        DoubleBuffer = Constants.GL_DOUBLEBUFFER,
        Stereo = Constants.GL_STEREO,
        RenderMode = Constants.GL_RENDER_MODE,
        PerspectiveCorrectionHint = Constants.GL_PERSPECTIVE_CORRECTION_HINT,
        PointSmoothHint = Constants.GL_POINT_SMOOTH_HINT,
        LineSmoothHint = Constants.GL_LINE_SMOOTH_HINT,
        PolygonSmoothHint = Constants.GL_POLYGON_SMOOTH_HINT,
        FogHint = Constants.GL_FOG_HINT,
        TextureGenS = Constants.GL_TEXTURE_GEN_S,
        TextureGenT = Constants.GL_TEXTURE_GEN_T,
        TextureGenR = Constants.GL_TEXTURE_GEN_R,
        TextureGenQ = Constants.GL_TEXTURE_GEN_Q,
        PixelMapItoI = Constants.GL_PIXEL_MAP_I_TO_I,
        PixelMapStoS = Constants.GL_PIXEL_MAP_S_TO_S,
        PixelMapItoR = Constants.GL_PIXEL_MAP_I_TO_R,
        PixelMapItoG = Constants.GL_PIXEL_MAP_I_TO_G,
        PixelMapItoB = Constants.GL_PIXEL_MAP_I_TO_B,
        PixelMapItoA = Constants.GL_PIXEL_MAP_I_TO_A,
        PixelMapRtoR = Constants.GL_PIXEL_MAP_R_TO_R,
        PixelMapGtoG = Constants.GL_PIXEL_MAP_G_TO_G,
        PixelMapBtoB = Constants.GL_PIXEL_MAP_B_TO_B,
        PixelMapAtoA = Constants.GL_PIXEL_MAP_A_TO_A,
        PixelMapItoISize = Constants.GL_PIXEL_MAP_I_TO_I_SIZE,
        PixelMapStoSSize = Constants.GL_PIXEL_MAP_S_TO_S_SIZE,
        PixelMapItoRSize = Constants.GL_PIXEL_MAP_I_TO_R_SIZE,
        PixelMapItoGSize = Constants.GL_PIXEL_MAP_I_TO_G_SIZE,
        PixelMapItoBSize = Constants.GL_PIXEL_MAP_I_TO_B_SIZE,
        PixelMapItoASize = Constants.GL_PIXEL_MAP_I_TO_A_SIZE,
        PixelMapRtoRSize = Constants.GL_PIXEL_MAP_R_TO_R_SIZE,
        PixelMapGtoGSize = Constants.GL_PIXEL_MAP_G_TO_G_SIZE,
        PixelMapBtoBSize = Constants.GL_PIXEL_MAP_B_TO_B_SIZE,
        PixelMapAtoASize = Constants.GL_PIXEL_MAP_A_TO_A_SIZE,
        UnpackSwapBytes = Constants.GL_UNPACK_SWAP_BYTES,
        LsbFirst = Constants.GL_UNPACK_LSB_FIRST,
        UnpackRowLength = Constants.GL_UNPACK_ROW_LENGTH,
        UnpackSkipRows = Constants.GL_UNPACK_SKIP_ROWS,
        UnpackSkipPixels = Constants.GL_UNPACK_SKIP_PIXELS,
        UnpackAlignment = Constants.GL_UNPACK_ALIGNMENT,
        PackSwapBytes = Constants.GL_PACK_SWAP_BYTES,
        PackLsbFirst = Constants.GL_PACK_LSB_FIRST,
        PackRowLength = Constants.GL_PACK_ROW_LENGTH,
        PackSkipRows = Constants.GL_PACK_SKIP_ROWS,
        PackSkipPixels = Constants.GL_PACK_SKIP_PIXELS,
        PackAlignment = Constants.GL_PACK_ALIGNMENT,
        MapColor = Constants.GL_MAP_COLOR,
        MapStencil = Constants.GL_MAP_STENCIL,
        IndexShift = Constants.GL_INDEX_SHIFT,
        IndexOffset = Constants.GL_INDEX_OFFSET,
        RedScale = Constants.GL_RED_SCALE,
        RedBias = Constants.GL_RED_BIAS,
        ZoomX = Constants.GL_ZOOM_X,
        ZoomY = Constants.GL_ZOOM_Y,
        GreenScale = Constants.GL_GREEN_SCALE,
        GreenBias = Constants.GL_GREEN_BIAS,
        BlueScale = Constants.GL_BLUE_SCALE,
        BlueBias = Constants.GL_BLUE_BIAS,
        AlphaScale = Constants.GL_ALPHA_SCALE,
        AlphaBias = Constants.GL_ALPHA_BIAS,
        DepthScale = Constants.GL_DEPTH_SCALE,
        DepthBias = Constants.GL_DEPTH_BIAS,
        MapEvalOrder = Constants.GL_MAX_EVAL_ORDER,
        MaxLights = Constants.GL_MAX_LIGHTS,
        MaxClipPlanes = Constants.GL_MAX_CLIP_PLANES,
        MaxTextureSize = Constants.GL_MAX_TEXTURE_SIZE,
        MapPixelMapTable = Constants.GL_MAX_PIXEL_MAP_TABLE,
        MaxAttribStackDepth = Constants.GL_MAX_ATTRIB_STACK_DEPTH,
        MaxModelviewStackDepth = Constants.GL_MAX_MODELVIEW_STACK_DEPTH,
        MaxNameStackDepth = Constants.GL_MAX_NAME_STACK_DEPTH,
        MaxProjectionStackDepth = Constants.GL_MAX_PROJECTION_STACK_DEPTH,
        MaxTextureStackDepth = Constants.GL_MAX_TEXTURE_STACK_DEPTH,
        MaxViewportDims = Constants.GL_MAX_VIEWPORT_DIMS,
        MaxClientAttribStackDepth = Constants.GL_MAX_CLIENT_ATTRIB_STACK_DEPTH,
        SubpixelBits = Constants.GL_SUBPIXEL_BITS,
        IndexBits = Constants.GL_INDEX_BITS,
        RedBits = Constants.GL_RED_BITS,
        GreenBits = Constants.GL_GREEN_BITS,
        BlueBits = Constants.GL_BLUE_BITS,
        AlphaBits = Constants.GL_ALPHA_BITS,
        DepthBits = Constants.GL_DEPTH_BITS,
        StencilBits = Constants.GL_STENCIL_BITS,
        AccumRedBits = Constants.GL_ACCUM_RED_BITS,
        AccumGreenBits = Constants.GL_ACCUM_GREEN_BITS,
        AccumBlueBits = Constants.GL_ACCUM_BLUE_BITS,
        AccumAlphaBits = Constants.GL_ACCUM_ALPHA_BITS,
        NameStackDepth = Constants.GL_NAME_STACK_DEPTH,
        AutoNormal = Constants.GL_AUTO_NORMAL,
        Map1Color4 = Constants.GL_MAP1_COLOR_4,
        Map1Index = Constants.GL_MAP1_INDEX,
        Map1Normal = Constants.GL_MAP1_NORMAL,
        Map1TextureCoord1 = Constants.GL_MAP1_TEXTURE_COORD_1,
        Map1TextureCoord2 = Constants.GL_MAP1_TEXTURE_COORD_2,
        Map1TextureCoord3 = Constants.GL_MAP1_TEXTURE_COORD_3,
        Map1TextureCoord4 = Constants.GL_MAP1_TEXTURE_COORD_4,
        Map1Vertex3 = Constants.GL_MAP1_VERTEX_3,
        Map1Vertex4 = Constants.GL_MAP1_VERTEX_4,
        Map2Color4 = Constants.GL_MAP2_COLOR_4,
        Map2Index = Constants.GL_MAP2_INDEX,
        Map2Normal = Constants.GL_MAP2_NORMAL,
        Map2TextureCoord1 = Constants.GL_MAP2_TEXTURE_COORD_1,
        Map2TextureCoord2 = Constants.GL_MAP2_TEXTURE_COORD_2,
        Map2TextureCoord3 = Constants.GL_MAP2_TEXTURE_COORD_3,
        Map2TextureCoord4 = Constants.GL_MAP2_TEXTURE_COORD_4,
        Map2Vertex3 = Constants.GL_MAP2_VERTEX_3,
        Map2Vertex4 = Constants.GL_MAP2_VERTEX_4,
        Map1GridDomain = Constants.GL_MAP1_GRID_DOMAIN,
        Map1GridSegments = Constants.GL_MAP1_GRID_SEGMENTS,
        Map2GridDomain = Constants.GL_MAP2_GRID_DOMAIN,
        Map2GridSegments = Constants.GL_MAP2_GRID_SEGMENTS,
        Texture1D = Constants.GL_TEXTURE_1D,
        Texture2D = Constants.GL_TEXTURE_2D,
        FeedbackBufferPointer = Constants.GL_FEEDBACK_BUFFER_POINTER,
        FeedbackBufferSize = Constants.GL_FEEDBACK_BUFFER_SIZE,
        FeedbackBufferType = Constants.GL_FEEDBACK_BUFFER_TYPE,
        SelectionBufferPointer = Constants.GL_SELECTION_BUFFER_POINTER,
        SelectionBufferSize = Constants.GL_SELECTION_BUFFER_SIZE,
        UniformBufferOffsetAlignment = Constants.GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT,
    }

    internal enum MapBufferAccess : uint {
        ReadOnly = Constants.GL_READ_ONLY,
        WriteOnly = Constants.GL_WRITE_ONLY,
        ReadWrite = Constants.GL_READ_WRITE,
    }

    [Flags]
    internal enum MapBufferRangeAccess : uint {
        MapReadBit = Constants.GL_MAP_READ_BIT,
        MapWriteBit = Constants.GL_MAP_WRITE_BIT,
        MapInvalidateRangeBit = Constants.GL_MAP_INVALIDATE_RANGE_BIT,
        MapInvalidateBufferBit = Constants.GL_MAP_INVALIDATE_BUFFER_BIT,
        MapFlushExplicitBit = Constants.GL_MAP_FLUSH_EXPLICIT_BIT,
        MapUnsynchronizedBit = Constants.GL_MAP_UNSYNCHRONIZED_BIT
    }

    internal enum PolygonOffset : uint {
        Factor = Constants.GL_POLYGON_OFFSET_FACTOR, 
        Units = Constants.GL_POLYGON_OFFSET_UNITS, 
        Point = Constants.GL_POLYGON_OFFSET_POINT, 
        Line = Constants.GL_POLYGON_OFFSET_LINE, 
        Fill = Constants.GL_POLYGON_OFFSET_FILL, 
    }
    internal enum PolygonModeFaces : uint {
        // 表示显示模式将适用于物体的前向面（也就是物体能看到的面）
        Front = Constants.GL_FRONT,
        // 表示显示模式将适用于物体的后向面（也就是物体上不能看到的面）
        Back = Constants.GL_BACK,
        // 表示显示模式将适用于物体的所有面
        FrontAndBack = Constants.GL_FRONT_AND_BACK,
    }

    internal enum PolygonMode : uint {
        Point = Constants.GL_POINT,
        Line = Constants.GL_LINE,
        Fill = Constants.GL_FILL
    }

    internal enum QueryTarget : uint {
        SamplesPassed = Constants.GL_SAMPLES_PASSED,
        AnySamplesPassed = Constants.GL_ANY_SAMPLES_PASSED,
        AnySamplesPassedConservative = Constants.GL_ANY_SAMPLES_PASSED_CONSERVATIVE,
        PrimitivesGenerated = Constants.GL_PRIMITIVES_GENERATED,
        TransformFeedbackPrimitivesWritten = Constants.GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN,
        TimeElapsed = Constants.GL_TIME_ELAPSED,
    }

    internal enum ConditionalRenderMode : uint {
        QueryWait = Constants.GL_QUERY_WAIT,
        QueryNoWait = Constants.GL_QUERY_NO_WAIT,
        QueryByRegionWait = Constants.GL_QUERY_BY_REGION_WAIT,
        QueryByRegionNoWait = Constants.GL_QUERY_BY_REGION_NO_WAIT,
    }

    internal enum ShaderType : uint {
        VertexShader = Constants.GL_VERTEX_SHADER,
        GeometryShader = Constants.GL_GEOMETRY_SHADER,
        TessControlShader = Constants.GL_TESS_CONTROL_SHADER,
        TessEvaluationShader = Constants.GL_TESS_EVALUATION_SHADER,
        FragmentShader = Constants.GL_FRAGMENT_SHADER,
        ComputeShader = Constants.GL_COMPUTE_SHADER,
    }

    internal enum EStencilFunc : uint {
        Always = Constants.GL_ALWAYS,
        Never = Constants.GL_NEVER,
        Less = Constants.GL_LESS,
        LEqual = Constants.GL_LEQUAL,
        Greater = Constants.GL_GREATER,
        GEqual = Constants.GL_GEQUAL,
        Equal = Constants.GL_EQUAL,
        NotEqual = Constants.GL_NOTEQUAL,
    }

    internal enum EStencilOp : uint {
        Keep = Constants.GL_KEEP,
        Zero = Constants.GL_ZERO,
        Replace = Constants.GL_REPLACE,
        Incr = Constants.GL_INCR,
        IncrWrap = Constants.GL_INCR_WRAP,
        Decr = Constants.GL_DECR,
        DecrWrap = Constants.GL_DECR_WRAP,
        Invert = Constants.GL_INVERT
    }

    internal enum TextureTarget : uint {
        Texture1D = Constants.GL_TEXTURE_1D,
        Texture2D = Constants.GL_TEXTURE_2D,
        Texture2DMultisample = Constants.GL_TEXTURE_2D_MULTISAMPLE,
        Texture2DArray = Constants.GL_TEXTURE_2D_ARRAY,
        Texture3D = Constants.GL_TEXTURE_3D,
        Texture2DMultisampleArray = Constants.GL_TEXTURE_2D_MULTISAMPLE_ARRAY,
        TextureCubeMap = Constants.GL_TEXTURE_CUBE_MAP,
        TextureBuffer = Constants.GL_TEXTURE_BUFFER,
        TextureRectangle = Constants.GL_TEXTURE_RECTANGLE,
    }
}
#endif