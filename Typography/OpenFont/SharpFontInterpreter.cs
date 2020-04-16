using System;
using System.Numerics;

namespace Anura.Typography.OpenFont {
    internal class SharpFontInterpreter {
        private struct InstructionStream {
            private byte[] instructions;

            private int ip;

            public bool IsValid => instructions != null;

            public bool Done => ip >= instructions.Length;

            public InstructionStream (byte[] instructions) {
                this.instructions = instructions;
                ip = 0;
            }

            public int NextByte () {
                if (Done) {
                    throw new InvalidFontException ();
                }
                return instructions[ip++];
            }

            public OpCode NextOpCode () {
                return (OpCode) NextByte ();
            }

            public int NextWord () {
                return (short) (ushort) ((NextByte () << 8) | NextByte ());
            }

            public void Jump (int offset) {
                ip += offset;
            }
        }

        private struct GraphicsState {
            public Vector2 Freedom;

            public Vector2 DualProjection;

            public Vector2 Projection;

            public InstructionControlFlags InstructionControl;

            public RoundMode RoundState;

            public float MinDistance;

            public float ControlValueCutIn;

            public float SingleWidthCutIn;

            public float SingleWidthValue;

            public int DeltaBase;

            public int DeltaShift;

            public int Loop;

            public int Rp0;

            public int Rp1;

            public int Rp2;

            public bool AutoFlip;

            public void Reset () {
                Freedom = Vector2.UnitX;
                Projection = Vector2.UnitX;
                DualProjection = Vector2.UnitX;
                InstructionControl = InstructionControlFlags.None;
                RoundState = RoundMode.ToGrid;
                MinDistance = 1f;
                ControlValueCutIn = 1.0625f;
                SingleWidthCutIn = 0f;
                SingleWidthValue = 0f;
                DeltaBase = 9;
                DeltaShift = 3;
                Loop = 1;
                Rp0 = (Rp1 = (Rp2 = 0));
                AutoFlip = true;
            }
        }

        private class ExecutionStack {
            private int[] _s;

            private int _count;

            public ExecutionStack (int maxStack) {
                _s = new int[maxStack];
            }

            public int Peek () {
                return Peek (0);
            }

            public bool PopBool () {
                return Pop () != 0;
            }

            public float PopFloat () {
                return F26Dot6ToFloat (Pop ());
            }

            public void Push (bool value) {
                Push (value ? 1 : 0);
            }

            public void Push (float value) {
                Push (FloatToF26Dot6 (value));
            }

            public void Clear () {
                _count = 0;
            }

            public void Depth () {
                Push (_count);
            }

            public void Duplicate () {
                Push (Peek ());
            }

            public void Copy () {
                Copy (Pop () - 1);
            }

            public void Copy (int index) {
                Push (Peek (index));
            }

            public void Move () {
                Move (Pop () - 1);
            }

            public void Roll () {
                Move (2);
            }

            public void Move (int index) {
                int num = Peek (index);
                for (int i = _count - index - 1; i < _count - 1; i++) {
                    _s[i] = _s[i + 1];
                }
                _s[_count - 1] = num;
            }

            public void Swap () {
                if (_count < 2) {
                    throw new InvalidFontException ();
                }
                int num = _s[_count - 1];
                _s[_count - 1] = _s[_count - 2];
                _s[_count - 2] = num;
            }

            public void Push (int value) {
                if (_count == _s.Length) {
                    throw new InvalidFontException ();
                }
                _s[_count++] = value;
            }

            public int Pop () {
                if (_count == 0) {
                    throw new InvalidFontException ();
                }
                return _s[--_count];
            }

            public int Peek (int index) {
                if (index < 0 || index >= _count) {
                    throw new InvalidFontException ();
                }
                return _s[_count - index - 1];
            }
        }

        private struct Zone {
            public GlyphPointF[] Current;

            public GlyphPointF[] Original;

            public TouchState[] TouchState;

            public bool IsTwilight;

            public Zone (GlyphPointF[] points, bool isTwilight) {
                IsTwilight = isTwilight;
                Current = points;
                Original = (GlyphPointF[]) points.Clone ();
                TouchState = new TouchState[points.Length];
            }

            public Vector2 GetCurrent (int index) {
                return Current[index].P;
            }

            public Vector2 GetOriginal (int index) {
                return Original[index].P;
            }
        }

        private enum RoundMode {
            ToHalfGrid,
            ToGrid,
            ToDoubleGrid,
            DownToGrid,
            UpToGrid,
            Off,
            Super,
            Super45
        }

        [Flags]
        private enum InstructionControlFlags {
            None = 0x0,
            InhibitGridFitting = 0x1,
            UseDefaultGraphicsState = 0x2
        }

        [Flags]
        private enum TouchState {
            None = 0x0,
            X = 0x1,
            Y = 0x2,
            Both = 0x3
        }

        private enum OpCode : byte {
            SVTCA0 = 0,
            SVTCA1 = 1,
            SPVTCA0 = 2,
            SPVTCA1 = 3,
            SFVTCA0 = 4,
            SFVTCA1 = 5,
            SPVTL0 = 6,
            SPVTL1 = 7,
            SFVTL0 = 8,
            SFVTL1 = 9,
            SPVFS = 10,
            SFVFS = 11,
            GPV = 12,
            GFV = 13,
            SFVTPV = 14,
            ISECT = 0xF,
            SRP0 = 0x10,
            SRP1 = 17,
            SRP2 = 18,
            SZP0 = 19,
            SZP1 = 20,
            SZP2 = 21,
            SZPS = 22,
            SLOOP = 23,
            RTG = 24,
            RTHG = 25,
            SMD = 26,
            ELSE = 27,
            JMPR = 28,
            SCVTCI = 29,
            SSWCI = 30,
            SSW = 0x1F,
            DUP = 0x20,
            POP = 33,
            CLEAR = 34,
            SWAP = 35,
            DEPTH = 36,
            CINDEX = 37,
            MINDEX = 38,
            ALIGNPTS = 39,
            UTP = 41,
            LOOPCALL = 42,
            CALL = 43,
            FDEF = 44,
            ENDF = 45,
            MDAP0 = 46,
            MDAP1 = 47,
            IUP0 = 48,
            IUP1 = 49,
            SHP0 = 50,
            SHP1 = 51,
            SHC0 = 52,
            SHC1 = 53,
            SHZ0 = 54,
            SHZ1 = 55,
            SHPIX = 56,
            IP = 57,
            MSIRP0 = 58,
            MSIRP1 = 59,
            ALIGNRP = 60,
            RTDG = 61,
            MIAP0 = 62,
            MIAP1 = 0x3F,
            NPUSHB = 0x40,
            NPUSHW = 65,
            WS = 66,
            RS = 67,
            WCVTP = 68,
            RCVT = 69,
            GC0 = 70,
            GC1 = 71,
            SCFS = 72,
            MD0 = 73,
            MD1 = 74,
            MPPEM = 75,
            MPS = 76,
            FLIPON = 77,
            FLIPOFF = 78,
            DEBUG = 79,
            LT = 80,
            LTEQ = 81,
            GT = 82,
            GTEQ = 83,
            EQ = 84,
            NEQ = 85,
            ODD = 86,
            EVEN = 87,
            IF = 88,
            EIF = 89,
            AND = 90,
            OR = 91,
            NOT = 92,
            DELTAP1 = 93,
            SDB = 94,
            SDS = 95,
            ADD = 96,
            SUB = 97,
            DIV = 98,
            MUL = 99,
            ABS = 100,
            NEG = 101,
            FLOOR = 102,
            CEILING = 103,
            ROUND0 = 104,
            ROUND1 = 105,
            ROUND2 = 106,
            ROUND3 = 107,
            NROUND0 = 108,
            NROUND1 = 109,
            NROUND2 = 110,
            NROUND3 = 111,
            WCVTF = 112,
            DELTAP2 = 113,
            DELTAP3 = 114,
            DELTAC1 = 115,
            DELTAC2 = 116,
            DELTAC3 = 117,
            SROUND = 118,
            S45ROUND = 119,
            JROT = 120,
            JROF = 121,
            ROFF = 122,
            RUTG = 124,
            RDTG = 125,
            SANGW = 126,
            AA = 0x7F,
            FLIPPT = 0x80,
            FLIPRGON = 129,
            FLIPRGOFF = 130,
            SCANCTRL = 133,
            SDPVTL0 = 134,
            SDPVTL1 = 135,
            GETINFO = 136,
            IDEF = 137,
            ROLL = 138,
            MAX = 139,
            MIN = 140,
            SCANTYPE = 141,
            INSTCTRL = 142,
            PUSHB1 = 176,
            PUSHB2 = 177,
            PUSHB3 = 178,
            PUSHB4 = 179,
            PUSHB5 = 180,
            PUSHB6 = 181,
            PUSHB7 = 182,
            PUSHB8 = 183,
            PUSHW1 = 184,
            PUSHW2 = 185,
            PUSHW3 = 186,
            PUSHW4 = 187,
            PUSHW5 = 188,
            PUSHW6 = 189,
            PUSHW7 = 190,
            PUSHW8 = 191,
            MDRP = 192,
            MIRP = 224
        }

        private GraphicsState _state;

        private GraphicsState _cvtState;

        private ExecutionStack _stack;

        private InstructionStream[] _functions;

        private InstructionStream[] _instructionDefs;

        private float[] _controlValueTable;

        private int[] _storage;

        private ushort[] _contours;

        private float _scale;

        private int _ppem;

        private int _callStackSize;

        private float _fdotp;

        private float _roundThreshold;

        private float _roundPhase;

        private float roundPeriod;

        private Zone _zp0;

        private Zone _zp1;

        private Zone _zp2;

        private Zone _points;

        private Zone _twilight;

        private static readonly float Sqrt2Over2 = (float) (Math.Sqrt (2.0) / 2.0);

        private const int MaxCallStack = 128;

        private const float Epsilon = 1E-06f;

        public SharpFontInterpreter (int maxStack, int maxStorage, int maxFunctions, int maxInstructionDefs, int maxTwilightPoints) {
            _stack = new ExecutionStack (maxStack);
            _storage = new int[maxStorage];
            _functions = new InstructionStream[maxFunctions];
            _instructionDefs = new InstructionStream[(maxInstructionDefs > 0) ? 256 : 0];
            _state = default (GraphicsState);
            _cvtState = default (GraphicsState);
            _twilight = new Zone (new GlyphPointF[maxTwilightPoints], true);
        }

        public void InitializeFunctionDefs (byte[] instructions) {
            Execute (new InstructionStream (instructions), false, true);
        }

        public void SetControlValueTable (int[] cvt, float scale, float ppem, byte[] cvProgram) {
            if (_scale == scale || cvt == null) {
                return;
            }
            if (_controlValueTable == null) {
                _controlValueTable = new float[cvt.Length];
            }
            for (int num = cvt.Length - 1; num >= 0; num--) {
                _controlValueTable[num] = (float) cvt[num] * scale;
            }
            _scale = scale;
            _ppem = (int) Math.Round (ppem);
            _zp0 = (_zp1 = (_zp2 = _points));
            _state.Reset ();
            _stack.Clear ();
            if (cvProgram != null) {
                Execute (new InstructionStream (cvProgram), false, false);
                if ((_state.InstructionControl & InstructionControlFlags.UseDefaultGraphicsState) != 0) {
                    _cvtState.Reset ();
                    return;
                }
                _cvtState = _state;
                _cvtState.Freedom = Vector2.UnitX;
                _cvtState.Projection = Vector2.UnitX;
                _cvtState.DualProjection = Vector2.UnitX;
                _cvtState.RoundState = RoundMode.ToGrid;
                _cvtState.Loop = 1;
            }
        }

        public void HintGlyph (GlyphPointF[] glyphPoints, ushort[] contours, byte[] instructions) {
            if (instructions != null && instructions.Length != 0 && (_state.InstructionControl & InstructionControlFlags.InhibitGridFitting) == InstructionControlFlags.None) {
                _contours = contours;
                _zp0 = (_zp1 = (_zp2 = (_points = new Zone (glyphPoints, false))));
                _state = _cvtState;
                _callStackSize = 0;
                _stack.Clear ();
                OnVectorsUpdated ();
                switch (_state.RoundState) {
                    case RoundMode.Super:
                        SetSuperRound (1f);
                        break;
                    case RoundMode.Super45:
                        SetSuperRound (Sqrt2Over2);
                        break;
                }
                Execute (new InstructionStream (instructions), false, false);
            }
        }

        private unsafe void Execute (InstructionStream stream, bool inFunction, bool allowFunctionDefs) {
            while (!stream.Done) {
                OpCode opCode = stream.NextOpCode ();
                switch (opCode) {
                    case OpCode.NPUSHB:
                    case OpCode.PUSHB1:
                    case OpCode.PUSHB2:
                    case OpCode.PUSHB3:
                    case OpCode.PUSHB4:
                    case OpCode.PUSHB5:
                    case OpCode.PUSHB6:
                    case OpCode.PUSHB7:
                    case OpCode.PUSHB8:
                        for (int num25 = ((opCode == OpCode.NPUSHB) ? stream.NextByte () : ((int) (opCode - 176 + 1))) - 1; num25 >= 0; num25--) {
                            _stack.Push (stream.NextByte ());
                        }
                        break;
                    case OpCode.NPUSHW:
                    case OpCode.PUSHW1:
                    case OpCode.PUSHW2:
                    case OpCode.PUSHW3:
                    case OpCode.PUSHW4:
                    case OpCode.PUSHW5:
                    case OpCode.PUSHW6:
                    case OpCode.PUSHW7:
                    case OpCode.PUSHW8:
                        for (int num13 = ((opCode == OpCode.NPUSHW) ? stream.NextByte () : ((int) (opCode - 184 + 1))) - 1; num13 >= 0; num13--) {
                            _stack.Push (stream.NextWord ());
                        }
                        break;
                    case OpCode.RS:
                        {
                            int num29 = CheckIndex (_stack.Pop (), _storage.Length);
                            _stack.Push (_storage[num29]);
                            break;
                        }
                    case OpCode.WS:
                        {
                            int num11 = _stack.Pop ();
                            int num12 = CheckIndex (_stack.Pop (), _storage.Length);
                            _storage[num12] = num11;
                            break;
                        }
                    case OpCode.WCVTP:
                        {
                            float num2 = _stack.PopFloat ();
                            int num3 = CheckIndex (_stack.Pop (), _controlValueTable.Length);
                            _controlValueTable[num3] = num2;
                            break;
                        }
                    case OpCode.WCVTF:
                        {
                            int num4 = _stack.Pop ();
                            int num5 = CheckIndex (_stack.Pop (), _controlValueTable.Length);
                            _controlValueTable[num5] = (float) num4 * _scale;
                            break;
                        }
                    case OpCode.RCVT:
                        _stack.Push (ReadCvt ());
                        break;
                    case OpCode.SVTCA0:
                    case OpCode.SVTCA1:
                        {
                            byte b = (byte) (opCode - 0);
                            SetFreedomVectorToAxis (b);
                            SetProjectionVectorToAxis (b);
                            break;
                        }
                    case OpCode.SFVTPV:
                        _state.Freedom = _state.Projection;
                        OnVectorsUpdated ();
                        break;
                    case OpCode.SPVTCA0:
                    case OpCode.SPVTCA1:
                        SetProjectionVectorToAxis ((int) (opCode - 2));
                        break;
                    case OpCode.SFVTCA0:
                    case OpCode.SFVTCA1:
                        SetFreedomVectorToAxis ((int) (opCode - 4));
                        break;
                    case OpCode.SPVTL0:
                    case OpCode.SPVTL1:
                    case OpCode.SFVTL0:
                    case OpCode.SFVTL1:
                        SetVectorToLine ((int) (opCode - 6), false);
                        break;
                    case OpCode.SDPVTL0:
                    case OpCode.SDPVTL1:
                        SetVectorToLine ((int) (opCode - 134), true);
                        break;
                    case OpCode.SPVFS:
                    case OpCode.SFVFS:
                        {
                            int value = _stack.Pop ();
                            Vector2 vector3 = Vector2.Normalize (new Vector2 (F2Dot14ToFloat (_stack.Pop ()), F2Dot14ToFloat (value)));
                            if (opCode == OpCode.SFVFS) {
                                _state.Freedom = vector3;
                            } else {
                                _state.Projection = vector3;
                                _state.DualProjection = vector3;
                            }
                            OnVectorsUpdated ();
                            break;
                        }
                    case OpCode.GPV:
                    case OpCode.GFV:
                        {
                            Vector2 vector = (opCode == OpCode.GPV) ? _state.Projection : _state.Freedom;
                            _stack.Push (FloatToF2Dot14 (vector.X));
                            _stack.Push (FloatToF2Dot14 (vector.Y));
                            break;
                        }
                    case OpCode.SRP0:
                        _state.Rp0 = _stack.Pop ();
                        break;
                    case OpCode.SRP1:
                        _state.Rp1 = _stack.Pop ();
                        break;
                    case OpCode.SRP2:
                        _state.Rp2 = _stack.Pop ();
                        break;
                    case OpCode.SZP0:
                        _zp0 = GetZoneFromStack ();
                        break;
                    case OpCode.SZP1:
                        _zp1 = GetZoneFromStack ();
                        break;
                    case OpCode.SZP2:
                        _zp2 = GetZoneFromStack ();
                        break;
                    case OpCode.SZPS:
                        _zp0 = (_zp1 = (_zp2 = GetZoneFromStack ()));
                        break;
                    case OpCode.RTHG:
                        _state.RoundState = RoundMode.ToHalfGrid;
                        break;
                    case OpCode.RTG:
                        _state.RoundState = RoundMode.ToGrid;
                        break;
                    case OpCode.RTDG:
                        _state.RoundState = RoundMode.ToDoubleGrid;
                        break;
                    case OpCode.RDTG:
                        _state.RoundState = RoundMode.DownToGrid;
                        break;
                    case OpCode.RUTG:
                        _state.RoundState = RoundMode.UpToGrid;
                        break;
                    case OpCode.ROFF:
                        _state.RoundState = RoundMode.Off;
                        break;
                    case OpCode.SROUND:
                        _state.RoundState = RoundMode.Super;
                        SetSuperRound (1f);
                        break;
                    case OpCode.S45ROUND:
                        _state.RoundState = RoundMode.Super45;
                        SetSuperRound (Sqrt2Over2);
                        break;
                    case OpCode.INSTCTRL:
                        {
                            int num71 = _stack.Pop ();
                            if (num71 >= 1 && num71 <= 2) {
                                int num72 = 1 << num71 - 1;
                                if (_stack.Pop () == 0) {
                                    _state.InstructionControl = (InstructionControlFlags) ((int) _state.InstructionControl & ~num72);
                                } else {
                                    _state.InstructionControl = (InstructionControlFlags) ((int) _state.InstructionControl | num72);
                                }
                            }
                            break;
                        }
                    case OpCode.SCANCTRL:
                        _stack.Pop ();
                        break;
                    case OpCode.SCANTYPE:
                        _stack.Pop ();
                        break;
                    case OpCode.SANGW:
                        _stack.Pop ();
                        break;
                    case OpCode.SLOOP:
                        _state.Loop = _stack.Pop ();
                        break;
                    case OpCode.SMD:
                        _state.MinDistance = _stack.PopFloat ();
                        break;
                    case OpCode.SCVTCI:
                        _state.ControlValueCutIn = _stack.PopFloat ();
                        break;
                    case OpCode.SSWCI:
                        _state.SingleWidthCutIn = _stack.PopFloat ();
                        break;
                    case OpCode.SSW:
                        _state.SingleWidthValue = (float) _stack.Pop () * _scale;
                        break;
                    case OpCode.FLIPON:
                        _state.AutoFlip = true;
                        break;
                    case OpCode.FLIPOFF:
                        _state.AutoFlip = false;
                        break;
                    case OpCode.SDB:
                        _state.DeltaBase = _stack.Pop ();
                        break;
                    case OpCode.SDS:
                        _state.DeltaShift = _stack.Pop ();
                        break;
                    case OpCode.GC0:
                        _stack.Push (Project (_zp2.GetCurrent (_stack.Pop ())));
                        break;
                    case OpCode.GC1:
                        _stack.Push (DualProject (_zp2.GetOriginal (_stack.Pop ())));
                        break;
                    case OpCode.SCFS:
                        {
                            float num30 = _stack.PopFloat ();
                            int num31 = _stack.Pop ();
                            Vector2 current3 = _zp2.GetCurrent (num31);
                            MovePoint (_zp2, num31, num30 - Project (current3));
                            if (_zp2.IsTwilight) {
                                _zp2.Original[num31].P = _zp2.Current[num31].P;
                            }
                            break;
                        }
                    case OpCode.MD0:
                        {
                            Vector2 original = _zp1.GetOriginal (_stack.Pop ());
                            Vector2 original2 = _zp0.GetOriginal (_stack.Pop ());
                            _stack.Push (DualProject (original2 - original));
                            break;
                        }
                    case OpCode.MD1:
                        {
                            Vector2 current = _zp1.GetCurrent (_stack.Pop ());
                            Vector2 current2 = _zp0.GetCurrent (_stack.Pop ());
                            _stack.Push (Project (current2 - current));
                            break;
                        }
                    case OpCode.MPPEM:
                    case OpCode.MPS:
                        _stack.Push (_ppem);
                        break;
                    case OpCode.AA:
                        _stack.Pop ();
                        break;
                    case OpCode.FLIPPT:
                        for (int num27 = 0; num27 < _state.Loop; num27++) {
                            int num28 = _stack.Pop ();
                            _points.Current[num28].onCurve = !_points.Current[num28].onCurve;
                        }
                        _state.Loop = 1;
                        break;
                    case OpCode.FLIPRGON:
                        {
                            int num26 = _stack.Pop ();
                            for (int n = _stack.Pop (); n <= num26; n++) {
                                _points.Current[n].onCurve = true;
                            }
                            break;
                        }
                    case OpCode.FLIPRGOFF:
                        {
                            int num23 = _stack.Pop ();
                            for (int l = _stack.Pop (); l <= num23; l++) {
                                _points.Current[l].onCurve = false;
                            }
                            break;
                        }
                    case OpCode.SHP0:
                    case OpCode.SHP1:
                        {
                            Zone zone2;
                            int point2;
                            Vector2 displacement = ComputeDisplacement ((int) opCode, out zone2, out point2);
                            ShiftPoints (displacement);
                            break;
                        }
                    case OpCode.SHPIX:
                        ShiftPoints (_stack.PopFloat () * _state.Freedom);
                        break;
                    case OpCode.SHC0:
                    case OpCode.SHC1:
                        {
                            Zone zone;
                            int point;
                            Vector2 vector2 = ComputeDisplacement ((int) opCode, out zone, out point);
                            TouchState touchState = GetTouchState ();
                            int num6 = _stack.Pop ();
                            int num7 = (num6 != 0) ? (_contours[num6 - 1] + 1) : 0;
                            int num8 = _zp2.IsTwilight ? _zp2.Current.Length : (_contours[num6] + 1);
                            for (int i = num7; i < num8; i++) {
                                if (zone.Current != _zp2.Current || point != i) {
                                    _zp2.Current[i].P += vector2;
                                    _zp2.TouchState[i] |= touchState;
                                }
                            }
                            break;
                        }
                    case OpCode.SHZ0:
                    case OpCode.SHZ1:
                        {
                            Zone zone3;
                            int point3;
                            Vector2 vector6 = ComputeDisplacement ((int) opCode, out zone3, out point3);
                            int num86 = 0;
                            if (_zp2.IsTwilight) {
                                num86 = _zp2.Current.Length;
                            } else if (_contours.Length != 0) {
                                num86 = _contours[_contours.Length - 1] + 1;
                            }
                            for (int num87 = 0; num87 < num86; num87++) {
                                if (zone3.Current != _zp2.Current || point3 != num87) {
                                    _zp2.Current[num87].P += vector6;
                                }
                            }
                            break;
                        }
                    case OpCode.MIAP0:
                    case OpCode.MIAP1:
                        {
                            float num83 = ReadCvt ();
                            int num84 = _stack.Pop ();
                            if (_zp0.IsTwilight) {
                                Vector2 p = _state.Freedom * num83;
                                _zp0.Original[num84].P = p;
                                _zp0.Current[num84].P = p;
                            }
                            Vector2 current13 = _zp0.GetCurrent (num84);
                            float num85 = Project (current13);
                            if (opCode == OpCode.MIAP1) {
                                if (Math.Abs (num83 - num85) > _state.ControlValueCutIn) {
                                    num83 = num85;
                                }
                                num83 = Round (num83);
                            }
                            MovePoint (_zp0, num84, num83 - num85);
                            _state.Rp0 = num84;
                            _state.Rp1 = num84;
                            break;
                        }
                    case OpCode.MDAP0:
                    case OpCode.MDAP1:
                        {
                            int num82 = _stack.Pop ();
                            Vector2 current12 = _zp0.GetCurrent (num82);
                            float distance = 0f;
                            if (opCode == OpCode.MDAP1) {
                                distance = Project (current12);
                                distance = Round (distance) - distance;
                            }
                            MovePoint (_zp0, num82, distance);
                            _state.Rp0 = num82;
                            _state.Rp1 = num82;
                            break;
                        }
                    case OpCode.MSIRP0:
                    case OpCode.MSIRP1:
                        {
                            float num79 = _stack.PopFloat ();
                            int num80 = _stack.Pop ();
                            if (_zp1.IsTwilight) {
                                _zp1.Original[num80].P = _zp0.Original[_state.Rp0].P + num79 * _state.Freedom / _fdotp;
                                _zp1.Current[num80].P = _zp1.Original[num80].P;
                            }
                            float num81 = Project (_zp1.GetCurrent (num80) - _zp0.GetCurrent (_state.Rp0));
                            MovePoint (_zp1, num80, num79 - num81);
                            _state.Rp1 = _state.Rp0;
                            _state.Rp2 = num80;
                            if (opCode == OpCode.MSIRP1) {
                                _state.Rp0 = num80;
                            }
                            break;
                        }
                    case OpCode.IP:
                        {
                            Vector2 original3 = _zp0.GetOriginal (_state.Rp1);
                            Vector2 current10 = _zp0.GetCurrent (_state.Rp1);
                            float num73 = DualProject (_zp1.GetOriginal (_state.Rp2) - original3);
                            float num74 = Project (_zp1.GetCurrent (_state.Rp2) - current10);
                            for (int num75 = 0; num75 < _state.Loop; num75++) {
                                int index5 = _stack.Pop ();
                                Vector2 current11 = _zp2.GetCurrent (index5);
                                float num76 = Project (current11 - current10);
                                float num77 = DualProject (_zp2.GetOriginal (index5) - original3);
                                float num78 = 0f;
                                if (num77 != 0f) {
                                    num78 = ((num73 != 0f) ? (num77 * num74 / num73) : num77);
                                }
                                MovePoint (_zp2, index5, num78 - num76);
                            }
                            _state.Loop = 1;
                            break;
                        }
                    case OpCode.ALIGNRP:
                        for (int num70 = 0; num70 < _state.Loop; num70++) {
                            int index4 = _stack.Pop ();
                            Vector2 current8 = _zp1.GetCurrent (index4);
                            Vector2 current9 = _zp0.GetCurrent (_state.Rp0);
                            MovePoint (_zp1, index4, 0f - Project (current8 - current9));
                        }
                        _state.Loop = 1;
                        break;
                    case OpCode.ALIGNPTS:
                        {
                            int index2 = _stack.Pop ();
                            int index3 = _stack.Pop ();
                            float num69 = Project (_zp0.GetCurrent (index3) - _zp1.GetCurrent (index2)) / 2f;
                            MovePoint (_zp1, index2, num69);
                            MovePoint (_zp0, index3, 0f - num69);
                            break;
                        }
                    case OpCode.UTP:
                        _zp0.TouchState[_stack.Pop ()] &= ~GetTouchState ();
                        break;
                    case OpCode.IUP0:
                    case OpCode.IUP1:
                        if (_contours.Length != 0) {
                            fixed (GlyphPointF * ptr = _points.Current) {
                                fixed (GlyphPointF * ptr3 = _points.Original) {
                                    TouchState touchState2;
                                    byte * ptr2;
                                    byte * ptr4;
                                    if (opCode == OpCode.IUP0) {
                                        touchState2 = TouchState.Y;
                                        ptr2 = (byte * ) ( & ptr -> P.Y);
                                        ptr4 = (byte * ) ( & ptr3 -> P.Y);
                                    } else {
                                        touchState2 = TouchState.X;
                                        ptr2 = (byte * ) ( & ptr -> P.X);
                                        ptr4 = (byte * ) ( & ptr3 -> P.X);
                                    }
                                    int num60 = 0;
                                    for (int num61 = 0; num61 < _contours.Length; num61++) {
                                        ushort num62 = _contours[num61];
                                        int num63 = num60;
                                        int num64 = -1;
                                        int num65 = -1;
                                        for (; num60 <= num62; num60++) {
                                            if ((_points.TouchState[num60] & touchState2) != 0) {
                                                if (num64 < 0) {
                                                    num64 = num60;
                                                    num65 = num60;
                                                } else {
                                                    InterpolatePoints (ptr2, ptr4, num65 + 1, num60 - 1, num65, num60);
                                                    num65 = num60;
                                                }
                                            }
                                        }
                                        if (num64 >= 0) {
                                            if (num65 == num64) {
                                                float num66 = * GetPoint (ptr2, num65) - * GetPoint (ptr4, num65);
                                                if (num66 != 0f) {
                                                    for (int num67 = num63; num67 < num65; num67++) {
                                                        * GetPoint (ptr2, num67) += num66;
                                                    }
                                                    for (int num68 = num65 + 1; num68 <= num62; num68++) {
                                                        * GetPoint (ptr2, num68) += num66;
                                                    }
                                                }
                                            } else {
                                                InterpolatePoints (ptr2, ptr4, num65 + 1, num62, num65, num64);
                                                if (num64 > 0) {
                                                    InterpolatePoints (ptr2, ptr4, num63, num64 - 1, num65, num64);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case OpCode.ISECT:
                        {
                            Vector2 current4 = _zp0.GetCurrent (_stack.Pop ());
                            Vector2 current5 = _zp0.GetCurrent (_stack.Pop ());
                            Vector2 current6 = _zp1.GetCurrent (_stack.Pop ());
                            Vector2 current7 = _zp1.GetCurrent (_stack.Pop ());
                            int num56 = _stack.Pop ();
                            Vector2 vector4 = current7 - current6;
                            Vector2 vector5 = current5 - current4;
                            float num57 = vector4.X * vector5.Y - vector4.Y * vector5.X;
                            if (Math.Abs (num57) <= 1E-06f) {
                                _zp2.Current[num56].P = (current7 + current6 + current5 + current4) / 4f;
                            } else {
                                float num58 = current7.X * current6.Y - current7.Y * current6.X;
                                float num59 = current5.X * current4.Y - current5.Y * current4.X;
                                Vector2 value2 = new Vector2 (num58 * vector5.X - vector4.X * num59, num58 * vector5.Y - vector4.Y * num59);
                                _zp2.Current[num56].P = value2 / num57;
                            }
                            _zp2.TouchState[num56] = TouchState.Both;
                            break;
                        }
                    case OpCode.DUP:
                        _stack.Duplicate ();
                        break;
                    case OpCode.POP:
                        _stack.Pop ();
                        break;
                    case OpCode.CLEAR:
                        _stack.Clear ();
                        break;
                    case OpCode.SWAP:
                        _stack.Swap ();
                        break;
                    case OpCode.DEPTH:
                        _stack.Depth ();
                        break;
                    case OpCode.CINDEX:
                        _stack.Copy ();
                        break;
                    case OpCode.MINDEX:
                        _stack.Move ();
                        break;
                    case OpCode.ROLL:
                        _stack.Roll ();
                        break;
                    case OpCode.IF:
                        {
                            if (_stack.PopBool ()) {
                                break;
                            }
                            int num55 = 1;
                            while (num55 > 0) {
                                switch (SkipNext (ref stream)) {
                                    case OpCode.IF:
                                        num55++;
                                        break;
                                    case OpCode.EIF:
                                        num55--;
                                        break;
                                    case OpCode.ELSE:
                                        if (num55 == 1) {
                                            num55 = 0;
                                        }
                                        break;
                                }
                            }
                            break;
                        }
                    case OpCode.ELSE:
                        {
                            int num54 = 1;
                            while (num54 > 0) {
                                switch (SkipNext (ref stream)) {
                                    case OpCode.IF:
                                        num54++;
                                        break;
                                    case OpCode.EIF:
                                        num54--;
                                        break;
                                }
                            }
                            break;
                        }
                    case OpCode.JROT:
                    case OpCode.JROF:
                        if (_stack.PopBool () == (opCode == OpCode.JROT)) {
                            stream.Jump (_stack.Pop () - 1);
                        } else {
                            _stack.Pop ();
                        }
                        break;
                    case OpCode.JMPR:
                        stream.Jump (_stack.Pop () - 1);
                        break;
                    case OpCode.LT:
                        {
                            int num52 = _stack.Pop ();
                            int num53 = _stack.Pop ();
                            _stack.Push (num53 < num52);
                            break;
                        }
                    case OpCode.LTEQ:
                        {
                            int num50 = _stack.Pop ();
                            int num51 = _stack.Pop ();
                            _stack.Push (num51 <= num50);
                            break;
                        }
                    case OpCode.GT:
                        {
                            int num48 = _stack.Pop ();
                            int num49 = _stack.Pop ();
                            _stack.Push (num49 > num48);
                            break;
                        }
                    case OpCode.GTEQ:
                        {
                            int num46 = _stack.Pop ();
                            int num47 = _stack.Pop ();
                            _stack.Push (num47 >= num46);
                            break;
                        }
                    case OpCode.EQ:
                        {
                            int num44 = _stack.Pop ();
                            int num45 = _stack.Pop ();
                            _stack.Push (num45 == num44);
                            break;
                        }
                    case OpCode.NEQ:
                        {
                            int num42 = _stack.Pop ();
                            int num43 = _stack.Pop ();
                            _stack.Push (num43 != num42);
                            break;
                        }
                    case OpCode.AND:
                        {
                            bool flag3 = _stack.PopBool ();
                            bool flag4 = _stack.PopBool ();
                            _stack.Push (flag4 && flag3);
                            break;
                        }
                    case OpCode.OR:
                        {
                            bool flag = _stack.PopBool ();
                            bool flag2 = _stack.PopBool ();
                            _stack.Push (flag2 | flag);
                            break;
                        }
                    case OpCode.NOT:
                        _stack.Push (!_stack.PopBool ());
                        break;
                    case OpCode.ODD:
                        {
                            int num41 = (int) Round (_stack.PopFloat ());
                            _stack.Push (num41 % 2 != 0);
                            break;
                        }
                    case OpCode.EVEN:
                        {
                            int num40 = (int) Round (_stack.PopFloat ());
                            _stack.Push (num40 % 2 == 0);
                            break;
                        }
                    case OpCode.ADD:
                        {
                            int num38 = _stack.Pop ();
                            int num39 = _stack.Pop ();
                            _stack.Push (num39 + num38);
                            break;
                        }
                    case OpCode.SUB:
                        {
                            int num36 = _stack.Pop ();
                            int num37 = _stack.Pop ();
                            _stack.Push (num37 - num36);
                            break;
                        }
                    case OpCode.DIV:
                        {
                            int num34 = _stack.Pop ();
                            if (num34 == 0) {
                                throw new InvalidFontException ("Division by zero.");
                            }
                            long num35 = ((long) _stack.Pop () << 6) / num34;
                            _stack.Push ((int) num35);
                            break;
                        }
                    case OpCode.MUL:
                        {
                            int num32 = _stack.Pop ();
                            long num33 = (long) _stack.Pop () * (long) num32 >> 6;
                            _stack.Push ((int) num33);
                            break;
                        }
                    case OpCode.ABS:
                        _stack.Push (Math.Abs (_stack.Pop ()));
                        break;
                    case OpCode.NEG:
                        _stack.Push (-_stack.Pop ());
                        break;
                    case OpCode.FLOOR:
                        _stack.Push (_stack.Pop () & -64);
                        break;
                    case OpCode.CEILING:
                        _stack.Push ((_stack.Pop () + 63) & -64);
                        break;
                    case OpCode.MAX:
                        _stack.Push (Math.Max (_stack.Pop (), _stack.Pop ()));
                        break;
                    case OpCode.MIN:
                        _stack.Push (Math.Min (_stack.Pop (), _stack.Pop ()));
                        break;
                    case OpCode.FDEF:
                        if (!allowFunctionDefs | inFunction) {
                            throw new InvalidFontException ("Can't define functions here.");
                        }
                        _functions[_stack.Pop ()] = stream;
                        while (SkipNext (ref stream) != OpCode.ENDF) { }
                        break;
                    case OpCode.IDEF:
                        if (!allowFunctionDefs | inFunction) {
                            throw new InvalidFontException ("Can't define functions here.");
                        }
                        _instructionDefs[_stack.Pop ()] = stream;
                        while (SkipNext (ref stream) != OpCode.ENDF) { }
                        break;
                    case OpCode.ENDF:
                        if (!inFunction) {
                            throw new InvalidFontException ("Found invalid ENDF marker outside of a function definition.");
                        }
                        return;
                    case OpCode.LOOPCALL:
                    case OpCode.CALL:
                        {
                            _callStackSize++;
                            if (_callStackSize > 128) {
                                throw new InvalidFontException ("Stack overflow; infinite recursion?");
                            }
                            InstructionStream stream2 = _functions[_stack.Pop ()];
                            int num24 = (opCode != OpCode.LOOPCALL) ? 1 : _stack.Pop ();
                            for (int m = 0; m < num24; m++) {
                                Execute (stream2, true, false);
                            }
                            _callStackSize--;
                            break;
                        }
                    case OpCode.ROUND0:
                    case OpCode.ROUND1:
                    case OpCode.ROUND2:
                    case OpCode.ROUND3:
                        _stack.Push (Round (_stack.PopFloat ()));
                        break;
                    case OpCode.DELTAC1:
                    case OpCode.DELTAC2:
                    case OpCode.DELTAC3:
                        {
                            int num18 = _stack.Pop ();
                            for (int k = 1; k <= num18; k++) {
                                int num19 = _stack.Pop ();
                                int num20 = _stack.Pop ();
                                int num21 = (num20 >> 4) & 0xF;
                                num21 += (int) (opCode - 115) * 16;
                                num21 += _state.DeltaBase;
                                if (_ppem == num21) {
                                    int num22 = (num20 & 0xF) - 8;
                                    if (num22 >= 0) {
                                        num22++;
                                    }
                                    num22 *= 1 << 6 - _state.DeltaShift;
                                    CheckIndex (num19, _controlValueTable.Length);
                                    _controlValueTable[num19] += F26Dot6ToFloat (num22);
                                }
                            }
                            break;
                        }
                    case OpCode.DELTAP1:
                    case OpCode.DELTAP2:
                    case OpCode.DELTAP3:
                        {
                            int num14 = _stack.Pop ();
                            for (int j = 1; j <= num14; j++) {
                                int index = _stack.Pop ();
                                int num15 = _stack.Pop ();
                                int num16 = (num15 >> 4) & 0xF;
                                num16 += _state.DeltaBase;
                                if (opCode != OpCode.DELTAP1) {
                                    num16 += (int) (opCode - 113 + 1) * 16;
                                }
                                if (_ppem == num16) {
                                    int num17 = (num15 & 0xF) - 8;
                                    if (num17 >= 0) {
                                        num17++;
                                    }
                                    num17 *= 1 << 6 - _state.DeltaShift;
                                    MovePoint (_zp0, index, F26Dot6ToFloat (num17));
                                }
                            }
                            break;
                        }
                    case OpCode.DEBUG:
                        _stack.Pop ();
                        break;
                    case OpCode.GETINFO:
                        {
                            int num9 = _stack.Pop ();
                            int num10 = 0;
                            if ((num9 & 1) != 0) {
                                num10 = 35;
                            }
                            if ((num9 & 0x20) != 0) {
                                num10 |= 0x1000;
                            }
                            _stack.Push (num10);
                            break;
                        }
                    default:
                        {
                            if ((int) opCode >= 224) {
                                MoveIndirectRelative ((int) (opCode - 224));
                                break;
                            }
                            if ((int) opCode >= 192) {
                                MoveDirectRelative ((int) (opCode - 192));
                                break;
                            }
                            int num = (int) opCode;
                            if (num > _instructionDefs.Length || !_instructionDefs[num].IsValid) {
                                throw new InvalidFontException ("Unknown opcode in font program.");
                            }
                            _callStackSize++;
                            if (_callStackSize > 128) {
                                throw new InvalidFontException ("Stack overflow; infinite recursion?");
                            }
                            Execute (_instructionDefs[num], true, false);
                            _callStackSize--;
                            break;
                        }
                    case OpCode.EIF:
                    case OpCode.NROUND0:
                    case OpCode.NROUND1:
                    case OpCode.NROUND2:
                    case OpCode.NROUND3:
                        break;
                }
            }
        }

        private int CheckIndex (int index, int length) {
            if (index < 0 || index >= length) {
                throw new InvalidFontException ();
            }
            return index;
        }

        private float ReadCvt () {
            return _controlValueTable[CheckIndex (_stack.Pop (), _controlValueTable.Length)];
        }

        private void OnVectorsUpdated () {
            _fdotp = Vector2.Dot (_state.Freedom, _state.Projection);
            if (Math.Abs (_fdotp) < 1E-06f) {
                _fdotp = 1f;
            }
        }

        private void SetFreedomVectorToAxis (int axis) {
            _state.Freedom = ((axis == 0) ? Vector2.UnitY : Vector2.UnitX);
            OnVectorsUpdated ();
        }

        private void SetProjectionVectorToAxis (int axis) {
            _state.Projection = ((axis == 0) ? Vector2.UnitY : Vector2.UnitX);
            _state.DualProjection = _state.Projection;
            OnVectorsUpdated ();
        }

        private void SetVectorToLine (int mode, bool dual) {
            int index = _stack.Pop ();
            int index2 = _stack.Pop ();
            Vector2 current = _zp2.GetCurrent (index);
            Vector2 vector = _zp1.GetCurrent (index2) - current;
            if (vector.LengthSquared () == 0f) {
                if (mode >= 2) {
                    _state.Freedom = Vector2.UnitX;
                } else {
                    _state.Projection = Vector2.UnitX;
                    _state.DualProjection = Vector2.UnitX;
                }
            } else {
                if ((mode & 1) != 0) {
                    vector = new Vector2 (0f - vector.Y, vector.X);
                }
                vector = Vector2.Normalize (vector);
                if (mode >= 2) {
                    _state.Freedom = vector;
                } else {
                    _state.Projection = vector;
                    _state.DualProjection = vector;
                }
            }
            if (dual) {
                current = _zp2.GetOriginal (index);
                vector = _zp2.GetOriginal (index2) - current;
                if (vector.LengthSquared () == 0f) {
                    _state.DualProjection = Vector2.UnitX;
                } else {
                    if ((mode & 1) != 0) {
                        vector = new Vector2 (0f - vector.Y, vector.X);
                    }
                    _state.DualProjection = Vector2.Normalize (vector);
                }
            }
            OnVectorsUpdated ();
        }

        private Zone GetZoneFromStack () {
            switch (_stack.Pop ()) {
                case 0:
                    return _twilight;
                case 1:
                    return _points;
                default:
                    throw new InvalidFontException ("Invalid zone pointer.");
            }
        }

        private void SetSuperRound (float period) {
            int num = _stack.Pop ();
            switch (num & 0xC0) {
                case 0:
                    roundPeriod = period / 2f;
                    break;
                case 64:
                    roundPeriod = period;
                    break;
                case 128:
                    roundPeriod = period * 2f;
                    break;
                default:
                    throw new InvalidFontException ("Unknown rounding period multiplier.");
            }
            switch (num & 0x30) {
                case 0:
                    _roundPhase = 0f;
                    break;
                case 16:
                    _roundPhase = roundPeriod / 4f;
                    break;
                case 32:
                    _roundPhase = roundPeriod / 2f;
                    break;
                case 48:
                    _roundPhase = roundPeriod * 3f / 4f;
                    break;
            }
            if ((num & 0xF) == 0) {
                _roundThreshold = roundPeriod - 1f;
            } else {
                _roundThreshold = (float) ((num & 0xF) - 4) * roundPeriod / 8f;
            }
        }

        private void MoveIndirectRelative (int flags) {
            float num = ReadCvt ();
            int num2 = _stack.Pop ();
            if (Math.Abs (num - _state.SingleWidthValue) < _state.SingleWidthCutIn) {
                num = ((!(num >= 0f)) ? (0f - _state.SingleWidthValue) : _state.SingleWidthValue);
            }
            Vector2 original = _zp0.GetOriginal (_state.Rp0);
            if (_zp1.IsTwilight) {
                Vector2 p = original + _state.Freedom * num;
                _zp1.Original[num2].P = p;
                _zp1.Current[num2].P = p;
            }
            Vector2 current = _zp1.GetCurrent (num2);
            float num3 = DualProject (_zp1.GetOriginal (num2) - original);
            float num4 = Project (current - _zp0.GetCurrent (_state.Rp0));
            if (_state.AutoFlip && Math.Sign (num3) != Math.Sign (num)) {
                num = 0f - num;
            }
            float num5 = num;
            if ((flags & 4) != 0) {
                if (_zp0.IsTwilight == _zp1.IsTwilight && Math.Abs (num - num3) > _state.ControlValueCutIn) {
                    num = num3;
                }
                num5 = Round (num);
            }
            if ((flags & 8) != 0) {
                num5 = ((!(num3 >= 0f)) ? Math.Min (num5, 0f - _state.MinDistance) : Math.Max (num5, _state.MinDistance));
            }
            MovePoint (_zp1, num2, num5 - num4);
            _state.Rp1 = _state.Rp0;
            _state.Rp2 = num2;
            if ((flags & 0x10) != 0) {
                _state.Rp0 = num2;
            }
        }

        private void MoveDirectRelative (int flags) {
            int num = _stack.Pop ();
            Vector2 original = _zp0.GetOriginal (_state.Rp0);
            Vector2 original2 = _zp1.GetOriginal (num);
            float num2 = DualProject (original2 - original);
            if (Math.Abs (num2 - _state.SingleWidthValue) < _state.SingleWidthCutIn) {
                num2 = ((!(num2 >= 0f)) ? (0f - _state.SingleWidthValue) : _state.SingleWidthValue);
            }
            float num3 = num2;
            if ((flags & 4) != 0) {
                num3 = Round (num3);
            }
            if ((flags & 8) != 0) {
                num3 = ((!(num2 >= 0f)) ? Math.Min (num3, 0f - _state.MinDistance) : Math.Max (num3, _state.MinDistance));
            }
            num2 = Project (_zp1.GetCurrent (num) - _zp0.GetCurrent (_state.Rp0));
            MovePoint (_zp1, num, num3 - num2);
            _state.Rp1 = _state.Rp0;
            _state.Rp2 = num;
            if ((flags & 0x10) != 0) {
                _state.Rp0 = num;
            }
        }

        private Vector2 ComputeDisplacement (int mode, out Zone zone, out int point) {
            if ((mode & 1) == 0) {
                zone = _zp1;
                point = _state.Rp2;
            } else {
                zone = _zp0;
                point = _state.Rp1;
            }
            return Project (zone.GetCurrent (point) - zone.GetOriginal (point)) * _state.Freedom / _fdotp;
        }

        private TouchState GetTouchState () {
            TouchState touchState = TouchState.None;
            if (_state.Freedom.X != 0f) {
                touchState = TouchState.X;
            }
            if (_state.Freedom.Y != 0f) {
                touchState |= TouchState.Y;
            }
            return touchState;
        }

        private void ShiftPoints (Vector2 displacement) {
            TouchState touchState = GetTouchState ();
            for (int i = 0; i < _state.Loop; i++) {
                int num = _stack.Pop ();
                _zp2.Current[num].P += displacement;
                _zp2.TouchState[num] |= touchState;
            }
            _state.Loop = 1;
        }

        private void MovePoint (Zone zone, int index, float distance) {
            Vector2 p = zone.GetCurrent (index) + distance * _state.Freedom / _fdotp;
            TouchState touchState = GetTouchState ();
            zone.Current[index].P = p;
            zone.TouchState[index] |= touchState;
        }

        private float Round (float value) {
            switch (_state.RoundState) {
                case RoundMode.ToGrid:
                    if (!(value >= 0f)) {
                        return 0f - (float) Math.Round (0f - value);
                    }
                    return (float) Math.Round (value);
                case RoundMode.ToHalfGrid:
                    if (!(value >= 0f)) {
                        return 0f - ((float) Math.Floor (0f - value) + 0.5f);
                    }
                    return (float) Math.Floor (value) + 0.5f;
                case RoundMode.ToDoubleGrid:
                    if (!(value >= 0f)) {
                        return 0f - (float) (Math.Round ((0f - value) * 2f, MidpointRounding.AwayFromZero) / 2.0);
                    }
                    return (float) (Math.Round (value * 2f, MidpointRounding.AwayFromZero) / 2.0);
                case RoundMode.DownToGrid:
                    if (!(value >= 0f)) {
                        return 0f - (float) Math.Floor (0f - value);
                    }
                    return (float) Math.Floor (value);
                case RoundMode.UpToGrid:
                    if (!(value >= 0f)) {
                        return 0f - (float) Math.Ceiling (0f - value);
                    }
                    return (float) Math.Ceiling (value);
                case RoundMode.Super:
                case RoundMode.Super45:
                    {
                        float num;
                        if (value >= 0f) {
                            num = value - _roundPhase + _roundThreshold;
                            num = (float) Math.Truncate (num / roundPeriod) * roundPeriod;
                            num += _roundPhase;
                            if (num < 0f) {
                                num = _roundPhase;
                            }
                        } else {
                            num = 0f - value - _roundPhase + _roundThreshold;
                            num = (0f - (float) Math.Truncate (num / roundPeriod)) * roundPeriod;
                            num -= _roundPhase;
                            if (num > 0f) {
                                num = 0f - _roundPhase;
                            }
                        }
                        return num;
                    }
                default:
                    return value;
            }
        }

        private float Project (Vector2 point) {
            return Vector2.Dot (point, _state.Projection);
        }

        private float DualProject (Vector2 point) {
            return Vector2.Dot (point, _state.DualProjection);
        }

        private static OpCode SkipNext (ref InstructionStream stream) {
            OpCode opCode = stream.NextOpCode ();
            switch (opCode) {
                case OpCode.NPUSHB:
                case OpCode.PUSHB1:
                case OpCode.PUSHB2:
                case OpCode.PUSHB3:
                case OpCode.PUSHB4:
                case OpCode.PUSHB5:
                case OpCode.PUSHB6:
                case OpCode.PUSHB7:
                case OpCode.PUSHB8:
                    {
                        int num2 = (opCode == OpCode.NPUSHB) ? stream.NextByte () : ((int) (opCode - 176 + 1));
                        for (int j = 0; j < num2; j++) {
                            stream.NextByte ();
                        }
                        break;
                    }
                case OpCode.NPUSHW:
                case OpCode.PUSHW1:
                case OpCode.PUSHW2:
                case OpCode.PUSHW3:
                case OpCode.PUSHW4:
                case OpCode.PUSHW5:
                case OpCode.PUSHW6:
                case OpCode.PUSHW7:
                case OpCode.PUSHW8:
                    {
                        int num = (opCode == OpCode.NPUSHW) ? stream.NextByte () : ((int) (opCode - 184 + 1));
                        for (int i = 0; i < num; i++) {
                            stream.NextWord ();
                        }
                        break;
                    }
            }
            return opCode;
        }

        private unsafe static void InterpolatePoints (byte * current, byte * original, int start, int end, int ref1, int ref2) {
            if (start <= end) {
                float num = * GetPoint (original, ref1);
                float num2 = * GetPoint (original, ref2);
                float num4;
                float num5;
                if (num > num2) {
                    float num3 = num;
                    num = num2;
                    num2 = num3;
                    num4 = * GetPoint (current, ref2) - num;
                    num5 = * GetPoint (current, ref1) - num2;
                } else {
                    num4 = * GetPoint (current, ref1) - num;
                    num5 = * GetPoint (current, ref2) - num2;
                }
                float num6 = num4 + num;
                float num7 = (num5 + num2 - num6) / (num2 - num);
                for (int i = start; i <= end; i++) {
                    float point = * GetPoint (original, i);
                    point = ((!(point <= num)) ? ((!(point >= num2)) ? (num6 + (point - num) * num7) : (point + num5)) : (point + num4));
                    * GetPoint (current, i) = point;
                }
            }
        }

        private static void InterpolatePointsXAxis (GlyphPointF[] current, GlyphPointF[] original, int start, int end, int ref1, int ref2) {
            if (start <= end) {
                float num = original[ref1].X;
                float num2 = original[ref2].X;
                float num4;
                float num5;
                if (num > num2) {
                    float num3 = num;
                    num = num2;
                    num2 = num3;
                    num4 = current[ref2].X - num;
                    num5 = current[ref1].X - num2;
                } else {
                    num4 = current[ref1].X - num;
                    num5 = current[ref2].X - num2;
                }
                float num6 = num4 + num;
                float num7 = (num5 + num2 - num6) / (num2 - num);
                for (int i = start; i <= end; i++) {
                    float x = original[i].X;
                    x = ((!(x <= num)) ? ((!(x >= num2)) ? (num6 + (x - num) * num7) : (x + num5)) : (x + num4));
                    current[i].UpdateX (x);
                }
            }
        }

        private static void InterpolatePointsYAxis (GlyphPointF[] current, GlyphPointF[] original, int start, int end, int ref1, int ref2) {
            if (start <= end) {
                float num = original[ref1].Y;
                float num2 = original[ref2].Y;
                float num4;
                float num5;
                if (num > num2) {
                    float num3 = num;
                    num = num2;
                    num2 = num3;
                    num4 = current[ref2].Y - num;
                    num5 = current[ref1].Y - num2;
                } else {
                    num4 = current[ref1].Y - num;
                    num5 = current[ref2].Y - num2;
                }
                float num6 = num4 + num;
                float num7 = (num5 + num2 - num6) / (num2 - num);
                for (int i = start; i <= end; i++) {
                    float y = original[i].Y;
                    y = ((!(y <= num)) ? ((!(y >= num2)) ? (num6 + (y - num) * num7) : (y + num5)) : (y + num4));
                    current[i].UpdateY (y);
                }
            }
        }

        private static float F2Dot14ToFloat (int value) {
            return (float) (short) value / 16384f;
        }

        private static int FloatToF2Dot14 (float value) {
            return (short) Math.Round (value * 16384f);
        }

        private static float F26Dot6ToFloat (int value) {
            return (float) value / 64f;
        }

        private static int FloatToF26Dot6 (float value) {
            return (int) Math.Round (value * 64f);
        }

        private unsafe static float * GetPoint (byte * data, int index) {
            return (float * ) (data + sizeof (GlyphPointF) * index);
        }
    }
}