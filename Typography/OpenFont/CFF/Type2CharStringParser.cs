using System;
using System.IO;

namespace Anura.Typography.OpenFont.CFF {
    internal class Type2CharStringParser : IDisposable {
        private MemoryStream _msBuffer;

        private BinaryReader _reader;

        private bool _foundSomeStem;

        private Type2GlyphInstructionList _insts;

        private int _current_int_count;

        private bool _doStemCount = true;

        private OperatorName _latestOpName;

        public Type2CharStringParser () {
            _msBuffer = new MemoryStream ();
            _reader = new BinaryReader (_msBuffer);
        }

        public Type2GlyphInstructionList ParseType2CharString (byte[] buffer) {
            _current_int_count = 0;
            _foundSomeStem = false;
            _doStemCount = true;
            _msBuffer.SetLength (0L);
            _msBuffer.Position = 0L;
            _msBuffer.Write (buffer, 0, buffer.Length);
            _msBuffer.Position = 0L;
            int num = buffer.Length;
            _insts = new Type2GlyphInstructionList ();
            byte b = 0;
            int hintStemCount = 0;
            bool flag = true;
            while (flag && _reader.BaseStream.Position < num) {
                b = _reader.ReadByte ();
                switch (b) {
                    default : if (b < 32) {
                        return null;
                    }
                    _insts.AddInt (ReadIntegerNumber (b));
                    if (_doStemCount) {
                        _current_int_count++;
                    }
                    break;
                    case 28:
                        {
                            byte b2 = _reader.ReadByte ();
                            byte b3 = _reader.ReadByte ();
                            _insts.AddInt ((short) ((b2 << 8) | b3));
                            if (_doStemCount) {
                                _current_int_count++;
                            }
                            break;
                        }
                    case 14:
                            _insts.AddOp (OperatorName.endchar);
                        flag = false;
                        break;
                    case 12:
                            b = _reader.ReadByte ();
                        switch (b) {
                            default : if (b <= 38) {
                                return null;
                            }
                            break;
                            case 35:
                                    _insts.AddOp (OperatorName.flex);
                                break;
                            case 34:
                                    _insts.AddOp (OperatorName.hflex);
                                break;
                            case 36:
                                    _insts.AddOp (OperatorName.hflex1);
                                break;
                            case 37:
                                    _insts.AddOp (OperatorName.flex1);
                                break;
                            case 9:
                                    _insts.AddOp (OperatorName.abs);
                                break;
                            case 10:
                                    _insts.AddOp (OperatorName.add);
                                break;
                            case 11:
                                    _insts.AddOp (OperatorName.sub);
                                break;
                            case 12:
                                    _insts.AddOp (OperatorName.div);
                                break;
                            case 14:
                                    _insts.AddOp (OperatorName.neg);
                                break;
                            case 23:
                                    _insts.AddOp (OperatorName.random);
                                break;
                            case 24:
                                    _insts.AddOp (OperatorName.mul);
                                break;
                            case 26:
                                    _insts.AddOp (OperatorName.sqrt);
                                break;
                            case 18:
                                    _insts.AddOp (OperatorName.drop);
                                break;
                            case 28:
                                    _insts.AddOp (OperatorName.exch);
                                break;
                            case 29:
                                    _insts.AddOp (OperatorName.index);
                                break;
                            case 30:
                                    _insts.AddOp (OperatorName.roll);
                                break;
                            case 27:
                                    _insts.AddOp (OperatorName.dup);
                                break;
                            case 20:
                                    _insts.AddOp (OperatorName.put);
                                break;
                            case 21:
                                    _insts.AddOp (OperatorName.get);
                                break;
                            case 3:
                                    _insts.AddOp (OperatorName.and);
                                break;
                            case 4:
                                    _insts.AddOp (OperatorName.or);
                                break;
                            case 5:
                                    _insts.AddOp (OperatorName.not);
                                break;
                            case 15:
                                    _insts.AddOp (OperatorName.eq);
                                break;
                            case 22:
                                    _insts.AddOp (OperatorName.ifelse);
                                break;
                        }
                        StopStemCount ();
                        break;
                    case 21:
                            _insts.AddOp (OperatorName.rmoveto);
                        StopStemCount ();
                        break;
                    case 22:
                            _insts.AddOp (OperatorName.hmoveto);
                        StopStemCount ();
                        break;
                    case 4:
                            _insts.AddOp (OperatorName.vmoveto);
                        StopStemCount ();
                        break;
                    case 5:
                            _insts.AddOp (OperatorName.rlineto);
                        StopStemCount ();
                        break;
                    case 6:
                            _insts.AddOp (OperatorName.hlineto);
                        StopStemCount ();
                        break;
                    case 7:
                            _insts.AddOp (OperatorName.vlineto);
                        StopStemCount ();
                        break;
                    case 8:
                            _insts.AddOp (OperatorName.rrcurveto);
                        StopStemCount ();
                        break;
                    case 27:
                            _insts.AddOp (OperatorName.hhcurveto);
                        StopStemCount ();
                        break;
                    case 31:
                            _insts.AddOp (OperatorName.hvcurveto);
                        StopStemCount ();
                        break;
                    case 24:
                            _insts.AddOp (OperatorName.rcurveline);
                        StopStemCount ();
                        break;
                    case 25:
                            _insts.AddOp (OperatorName.rlinecurve);
                        StopStemCount ();
                        break;
                    case 30:
                            _insts.AddOp (OperatorName.vhcurveto);
                        StopStemCount ();
                        break;
                    case 26:
                            _insts.AddOp (OperatorName.vvcurveto);
                        StopStemCount ();
                        break;
                    case 1:
                            AddStemToList (OperatorName.hstem, ref hintStemCount);
                        break;
                    case 3:
                            AddStemToList (OperatorName.vstem, ref hintStemCount);
                        break;
                    case 23:
                            AddStemToList (OperatorName.vstemhm, ref hintStemCount);
                        break;
                    case 18:
                            AddStemToList (OperatorName.hstemhm, ref hintStemCount);
                        break;
                    case 19:
                            AddHintMaskToList (_reader, ref hintStemCount);
                        StopStemCount ();
                        break;
                    case 20:
                            AddCounterMaskToList (_reader, ref hintStemCount);
                        StopStemCount ();
                        break;
                    case 10:
                            _insts.AddOp (OperatorName.callsubr);
                        StopStemCount ();
                        break;
                    case 29:
                            _insts.AddOp (OperatorName.callgsubr);
                        StopStemCount ();
                        break;
                    case 11:
                            _insts.AddOp (OperatorName._return);
                        StopStemCount ();
                        break;
                    case 0:
                            case 2:
                            case 9:
                            case 13:
                            case 15:
                            case 16:
                            case 17:
                            break;
                }
            }
            return _insts;
        }

        private void StopStemCount () {
            _current_int_count = 0;
            _doStemCount = false;
        }

        private void AddStemToList (OperatorName stemName, ref int hintStemCount) {
            if (_current_int_count % 2 != 0) {
                if (_foundSomeStem) {
                    throw new NotSupportedException ();
                }
                _insts.ChangeFirstInstToGlyphWidthValue ();
                _current_int_count--;
            }
            hintStemCount += _current_int_count / 2;
            _insts.AddOp (stemName);
            _current_int_count = 0;
            _foundSomeStem = true;
            _latestOpName = stemName;
        }

        private void AddHintMaskToList (BinaryReader reader, ref int hintStemCount) {
            if (_foundSomeStem && _current_int_count > 0) {
                switch (_latestOpName) {
                    case OperatorName.hstem:
                        hintStemCount += _current_int_count / 2;
                        _insts.AddOp (OperatorName.vstem);
                        _latestOpName = OperatorName.vstem;
                        _current_int_count = 0;
                        break;
                    case OperatorName.hstemhm:
                        hintStemCount += _current_int_count / 2;
                        _insts.AddOp (OperatorName.vstem);
                        _latestOpName = OperatorName.vstem;
                        _current_int_count = 0;
                        break;
                    case OperatorName.vstemhm:
                        hintStemCount += _current_int_count / 2;
                        _insts.AddOp (OperatorName.vstem);
                        _latestOpName = OperatorName.vstem;
                        _current_int_count = 0;
                        break;
                    default:
                        throw new NotSupportedException ();
                }
            }
            if (hintStemCount == 0) {
                if (_foundSomeStem) {
                    throw new NotSupportedException ();
                }
                hintStemCount = _current_int_count / 2;
                _foundSomeStem = true;
            }
            int num = (hintStemCount + 7) / 8;
            if (_reader.BaseStream.Position + num >= _reader.BaseStream.Length) {
                throw new NotSupportedException ();
            }
            if (num > 4) {
                int num2;
                for (num2 = num; num2 > 3; num2 -= 4) {
                    _insts.AddInt ((_reader.ReadByte () << 24) | (_reader.ReadByte () << 16) | (_reader.ReadByte () << 8) | _reader.ReadByte ());
                }
                switch (num2) {
                    case 1:
                        _insts.AddInt (_reader.ReadByte () << 24);
                        break;
                    case 2:
                        _insts.AddInt ((_reader.ReadByte () << 24) | (_reader.ReadByte () << 16));
                        break;
                    case 3:
                        _insts.AddInt ((_reader.ReadByte () << 24) | (_reader.ReadByte () << 16) | (_reader.ReadByte () << 8));
                        break;
                    default:
                        throw new NotSupportedException ();
                    case 0:
                        break;
                }
                _insts.AddOp (OperatorName.hintmask_bits, num);
            } else {
                switch (num) {
                    default : throw new NotSupportedException ();
                    case 1:
                            _insts.AddOp (OperatorName.hintmask1, _reader.ReadByte () << 24);
                        break;
                    case 2:
                            _insts.AddOp (OperatorName.hintmask2, (_reader.ReadByte () << 24) | (_reader.ReadByte () << 16));
                        break;
                    case 3:
                            _insts.AddOp (OperatorName.hintmask3, (_reader.ReadByte () << 24) | (_reader.ReadByte () << 16) | (_reader.ReadByte () << 8));
                        break;
                    case 4:
                            _insts.AddOp (OperatorName.hintmask4, (_reader.ReadByte () << 24) | (_reader.ReadByte () << 16) | (_reader.ReadByte () << 8) | _reader.ReadByte ());
                        break;
                }
            }
        }

        private void AddCounterMaskToList (BinaryReader reader, ref int hintStemCount) {
            if (hintStemCount == 0) {
                if (_foundSomeStem) {
                    throw new NotSupportedException ();
                }
                hintStemCount = _current_int_count / 2;
                _foundSomeStem = true;
            }
            int num = (hintStemCount + 7) / 8;
            if (_reader.BaseStream.Position + num >= _reader.BaseStream.Length) {
                throw new NotSupportedException ();
            }
            if (num > 4) {
                int num2;
                for (num2 = num; num2 > 3; num2 -= 4) {
                    _insts.AddInt ((_reader.ReadByte () << 24) | (_reader.ReadByte () << 16) | (_reader.ReadByte () << 8) | _reader.ReadByte ());
                }
                switch (num2) {
                    case 1:
                        _insts.AddInt (_reader.ReadByte () << 24);
                        break;
                    case 2:
                        _insts.AddInt ((_reader.ReadByte () << 24) | (_reader.ReadByte () << 16));
                        break;
                    case 3:
                        _insts.AddInt ((_reader.ReadByte () << 24) | (_reader.ReadByte () << 16) | (_reader.ReadByte () << 8));
                        break;
                    default:
                        throw new NotSupportedException ();
                    case 0:
                        break;
                }
                _insts.AddOp (OperatorName.cntrmask_bits, num);
            } else {
                switch (num) {
                    default : throw new NotSupportedException ();
                    case 1:
                            _insts.AddOp (OperatorName.cntrmask1, _reader.ReadByte () << 24);
                        break;
                    case 2:
                            _insts.AddOp (OperatorName.cntrmask2, (_reader.ReadByte () << 24) | (_reader.ReadByte () << 16));
                        break;
                    case 3:
                            _insts.AddOp (OperatorName.cntrmask3, (_reader.ReadByte () << 24) | (_reader.ReadByte () << 16) | (_reader.ReadByte () << 8));
                        break;
                    case 4:
                            _insts.AddOp (OperatorName.cntrmask4, (_reader.ReadByte () << 24) | (_reader.ReadByte () << 16) | (_reader.ReadByte () << 8) | _reader.ReadByte ());
                        break;
                }
            }
        }

        private int ReadIntegerNumber (byte b0) {
            if (b0 >= 32 && b0 <= 246) {
                return b0 - 139;
            }
            if (b0 <= 250) {
                int num = _reader.ReadByte ();
                return (b0 - 247) * 256 + num + 108;
            }
            if (b0 <= 254) {
                int num2 = _reader.ReadByte ();
                return -(b0 - 251) * 256 - num2 - 108;
            }
            if (b0 == byte.MaxValue) {
                return _reader.ReadInt32 ();
            }
            throw new NotSupportedException ();
        }

        public void Dispose () {
            if (_msBuffer != null) {
                _msBuffer.Dispose ();
                _msBuffer = null;
            }
        }
    }
}