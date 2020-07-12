using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows.Markup;

namespace Anura.Wasm {

    // Little Endian Base 不定长整型数编解码
    // 
    // LEB 表示法使用低位在前的规则，使用一序列 byte[] 表示不定长整数，其中，
    // 每个 byte 的最高位指示是否需要使用下一位 byte 用作数据，如果最高位 1，
    // 则需要用到下一位，反之，则就此截止：
    //
    // 例如 1 000 0110  0 111 1010 的有效位是 1111010 0000110 （共14位）
    //
    // 这样一来，一个 byte 中储存 7 位有效位数，使用一个字节可以表示无符号的
    // 2^7 - 1 个整数；然而，对于 32 位和 64 位的数字，与 7 不整除时，会保留
    // 空位（正数全为 0，负数全为 1）
    //
    // 对于有符号整数而言，在有效位的最高位上是符号位；如果这个位值为 0 ，

    /// <summary>
    /// 表示一个 LEB 1 位无符号整数 （自然，它只能取 0 和 1 两个值），在读取时自动
    /// 转换为 <see cref="ushort"/> 类型作为真实值
    /// </summary>
    public struct uvint1 {

        byte values;

        public static implicit operator byte(uvint1 v_1) {
            return v_1.values;
        }

        public static implicit operator uvint1(byte barr) {
            return new uvint1() { values = barr };
        }

        public static implicit operator uvint1(ushort b) {
            if (b > 1) throw new Exceptions.OverflowException();
            return new uvint1()
            {
                values = (byte)Convert.ToByte((Convert.ToByte(b) << 7) >> 7)
            };
        }

        [CLSCompliant(false)]
        public static implicit operator ushort(uvint1 v) {
            return (byte)(v.values & 0b00000001);
        }

        public override string ToString() {
            return ((ushort)this).ToString();
        }
    }

    /// <summary>
    /// 表示一个 LEB 7 位无符号整数，在读取时自动转换为 <see cref="ushort"/> 类型作为真实值
    /// </summary>
    public struct uvint7 {

        byte values;

        public static implicit operator byte(uvint7 v_7) {
            return v_7.values;
        }

        public static implicit operator uvint7(byte barr) {
            return new uvint7() { values = barr };
        }

        public static implicit operator uvint7(ushort b) {
            if (b > 127) throw new Exceptions.OverflowException();
            return new uvint7()
            {
                values = (byte)Convert.ToByte((Convert.ToByte(b) << 1) >> 1)
            };
        }

        public static implicit operator ushort(uvint7 v) {
            return (byte)(v.values & 0b01111111);
        }

        public override string ToString() {
            return ((ushort)this).ToString();
        }
    }

    /// <summary>
    /// 表示一个 LEB 16 位无符号整数，在读取时自动转换为 <see cref="uint"/> 类型作为真实值
    /// </summary>
    public struct uvint14 {

        byte[] values;

        public static implicit operator byte[](uvint14 v_32) {
            return v_32.values;
        }


        public static implicit operator uvint14(byte[] barr) {
            if (barr.Length != 2)
                throw new Exceptions.NumericException("一个 uvint14 只能由一个长度为 2 的 byte[] 表示");
            return new uvint14() { values = barr };
        }

        [CLSCompliant(false)]
        public static implicit operator uint(uvint14 v_32) {
            if (v_32.values.Length != 2)
                throw new Exceptions.NumericException("一个 uvint14 只能由一个长度为 2 的 byte[] 表示");
            var barr = v_32.values;
#if w_leb
            if (!(barr[0] >> 7 == 1 &&
                barr[1] >> 7 == 0))
                throw new Exceptions.NumericException("一个 uvint14 只对应 2 个连续的字节组，且前 1 个最高位为 1");
#endif
            uint val = ((((uint)(barr[1] & 0b01111111)) << 7) +
                        (((uint)(barr[0] & 0b01111111))));
            return val;

        }

        public static implicit operator uvint14(uint le) {
            return new uvint14()
            {
                values = new byte[2]
                {
                    (byte)(0b10000000 + (byte)((le << 7) >> 7)),
                    (byte)(0b00000000 + (byte)(((le >> 7))))
                }
            };
        }

        public override string ToString() {
            return ((uint)this).ToString();
        }
    }

    /// <summary>
    /// 表示一个 LEB 32 位无符号整数，在读取时自动转换为 <see cref="uint"/> 类型作为真实值
    /// </summary>
    public struct uvint32 {

        byte[] values;

        public static implicit operator byte[](uvint32 v_32) {
            return v_32.values;
        }


        public static implicit operator uvint32(byte[] barr) {
            if (barr.Length != 5)
                throw new Exceptions.NumericException("一个 uvint32 只能由一个长度为 5 的 byte[] 表示");
            return new uvint32() { values = barr };
        }

        [CLSCompliant(false)]
        public static implicit operator uint(uvint32 v_32) {
            if (v_32.values.Length != 5)
                throw new Exceptions.NumericException("一个 uvint32 只能由一个长度为 5 的 byte[] 表示");
            var barr = v_32.values;
#if w_leb
            if (!(barr[0] >> 7 == 1 &&
                barr[1] >> 7 == 1 &&
                barr[2] >> 7 == 1 &&
                barr[3] >> 7 == 1 &&
                barr[4] >> 7 == 0))
                throw new Exceptions.NumericException("一个 uvint32 只对应 5 个连续的字节组，且前 4 个最高位为 1");
#endif
            uint val = ((((uint)(barr[4] & 0b01111111)) << 28) +
                        (((uint)(barr[3] & 0b01111111)) << 21) +
                        (((uint)(barr[2] & 0b01111111)) << 14) +
                        (((uint)(barr[1] & 0b01111111)) << 7) +
                        (((uint)(barr[0] & 0b01111111))));
            return val;

        }

        public static implicit operator uvint32(uint le) {
            return new uvint32()
            {
                values = new byte[5]
                {
                    (byte)(0b10000000 + (byte)((le << 25) >> 25)),
                    (byte)(0b10000000 + (byte)(((le >> 7) << 25) >> 25)),
                    (byte)(0b10000000 + (byte)(((le >> 14) << 25) >> 25)),
                    (byte)(0b10000000 + (byte)(((le >> 21) << 25) >> 25)),
                    (byte)(0b00000000 + (byte)((le >> 28)))
                }
            };
        }

        public override string ToString() {
            return ((uint)this).ToString();
        }
    }

    /// <summary>
    /// 表示无限长 Leb 编码无符号整数
    /// </summary>
    public struct uvintn {
        public bool[] values;

        public static explicit operator ulong(uvintn n) {
            ulong l = 0;
            for (int i = n.values.Length - 1; i >= 0; i--) {
                l = l << 1;
                if (n.values[i]) l += 1;
                else l += 0;
            }
            return l;
        }

        public static explicit operator uint(uvintn n) {
            uint l = 0;
            for (int i = n.values.Length - 1; i >= 0; i--) {
                l = l << 1;
                if (n.values[i]) l += 1;
                else l += 0;
            }
            return l;
        }

        public static explicit operator ushort(uvintn n) {
            ushort l = 0;
            for (int i = n.values.Length - 1; i >= 0; i--) {
                l = (ushort)(l << 1);
                if (n.values[i]) l += 1;
                else l += 0;
            }
            return l;
        }

        public override string ToString() {
            return ((ulong)this).ToString();
        }
    }

    /// <summary>
    /// 表示一个 LEB 7 位有符号整数，在读取时自动转换为 <see cref="sbyte"/> 类型作为真实值 [-64, +63]
    /// </summary>
    public struct vint7 {

        byte values;

        public static implicit operator vint7(byte b) {
            return new vint7() { values = b };
        }

        public static implicit operator byte(vint7 v_7) {
            return v_7.values;
        }

        public static implicit operator sbyte(vint7 v_7) {
            if((v_7.values & 0b01000000) == 0b01000000) {
                int abs = ((~(v_7.values & 0b00111111)) & 0b00111111) + 1;
                return (sbyte)-abs;
            } else {
                return (sbyte)((ushort)((uvint7)v_7.values));
            }
        }

        public static implicit operator vint7(sbyte b) {
            if (b > 63) throw new Exceptions.OverflowException();
            else if (b < -64) throw new Exceptions.UnderflowException();
            if (b < 0) {
                return new vint7()
                {
                    values = (byte)(0b01000000 + ((~(-b) << 2) >> 2))
                };
            } else if (b > 0) {
                return new vint7() { values = (byte)((b << 2) >> 2) };
            } else return new vint7() { values = 0 };

        }

        public override string ToString() {
            return ((sbyte)this).ToString();
        }
    }

    /// <summary>
    /// 表示无限长 Leb 有符号整数
    /// </summary>
    public struct vintn {
        public bool[] values;

        public static explicit operator long(vintn n) {
            long l = 0;
            if (n.values.Last() == true) {
                for (int i = n.values.Length - 2; i >= 0; i--) {
                    l = l << 1;
                    if (n.values[i]) l += 0;
                    else l += 1;
                }
                l = -(l + 1);
            } else {
                for (int i = n.values.Length - 2; i >= 0; i--) {
                    l = l << 1;
                    if (n.values[i]) l += 1;
                    else l += 0;
                }
            }
            return l;
        }

        public static explicit operator int(vintn n) {
            int _i = 0;
            if (n.values.Last() == true) {
                for (int i = n.values.Length - 2; i >= 0; i--) {
                    _i = _i << 1;
                    if (n.values[i]) _i += 0;
                    else _i += 1;
                }
                _i = -(_i + 1);
            } else {
                for (int i = n.values.Length - 2; i >= 0; i--) {
                    _i = _i << 1;
                    if (n.values[i]) _i += 1;
                    else _i += 0;
                }
            }
            return _i;
        }

        public static explicit operator short(vintn n) {
            short s = 0;
            if (n.values.Last() == true) {
                for (int i = n.values.Length - 2; i >= 0; i--) {
                    s = (short)(s << 1);
                    if (n.values[i]) s += 0;
                    else s += 1;
                }
                s = (short)-(s + 1);
            } else {
                for (int i = n.values.Length - 2; i >= 0; i--) {
                    s = (short)(s << 1);
                    if (n.values[i]) s += 1;
                    else s += 0;
                }
            }
            return s;
        }

        public override string ToString() {
            return ((long)this).ToString();
        }
    }

    public static class LebReader {

        public static uvintn ReadUVIntN (this BinaryReader bin, ref uint offset) {
            List<bool> array = new List<bool>();
            bool flag = true;
            while(flag) {
                byte b = bin.ReadByte();
                offset++;
                if((b & 0b10000000) == 0b00000000) {
                    flag = false;
                }
                
                array.Add((b & 0b00000001) == 0b00000001);
                array.Add((b & 0b00000010) == 0b00000010);
                array.Add((b & 0b00000100) == 0b00000100);
                array.Add((b & 0b00001000) == 0b00001000); 
                array.Add((b & 0b00010000) == 0b00010000); 
                array.Add((b & 0b00100000) == 0b00100000);
                array.Add((b & 0b01000000) == 0b01000000);
            }
            return new uvintn() { values = array.ToArray() };
        }

        public static uvintn ReadUVIntN(this BinaryReader bin) {
            List<bool> array = new List<bool>();
            bool flag = true;
            while (flag) {
                byte b = bin.ReadByte();
                if ((b & 0b10000000) == 0b00000000) {
                    flag = false;
                }
               
                array.Add((b & 0b00000001) == 0b00000001);
                array.Add((b & 0b00000010) == 0b00000010);
                array.Add((b & 0b00000100) == 0b00000100);
                array.Add((b & 0b00001000) == 0b00001000);
                array.Add((b & 0b00010000) == 0b00010000);
                array.Add((b & 0b00100000) == 0b00100000);
                array.Add((b & 0b01000000) == 0b01000000);
            }
            return new uvintn() { values = array.ToArray() };
        }

        public static vintn ReadVIntN(this BinaryReader bin, ref uint offset) {
            List<bool> array = new List<bool>();
            bool flag = true;
            while (flag) {
                byte b = bin.ReadByte();
                offset++;
                if ((b & 0b10000000) == 0b00000000) {
                    flag = false;
                }

                array.Add((b & 0b00000001) == 0b00000001);
                array.Add((b & 0b00000010) == 0b00000010);
                array.Add((b & 0b00000100) == 0b00000100);
                array.Add((b & 0b00001000) == 0b00001000);
                array.Add((b & 0b00010000) == 0b00010000);
                array.Add((b & 0b00100000) == 0b00100000);
                array.Add((b & 0b01000000) == 0b01000000);
            }
            return new vintn() { values = array.ToArray() };
        }

        public static vintn ReadVIntN(this BinaryReader bin) {
            List<bool> array = new List<bool>();
            bool flag = true;
            while (flag) {
                byte b = bin.ReadByte();
                if ((b & 0b10000000) == 0b00000000) {
                    flag = false;
                }

                array.Add((b & 0b00000001) == 0b00000001);
                array.Add((b & 0b00000010) == 0b00000010);
                array.Add((b & 0b00000100) == 0b00000100);
                array.Add((b & 0b00001000) == 0b00001000);
                array.Add((b & 0b00010000) == 0b00010000);
                array.Add((b & 0b00100000) == 0b00100000);
                array.Add((b & 0b01000000) == 0b01000000);
            }
            return new vintn() { values = array.ToArray() };
        }
    }
}
