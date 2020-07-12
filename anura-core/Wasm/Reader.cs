using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Numerics;

namespace Anura.Wasm {

    /// <summary>
    /// 从二进制 Web Assembly 码中读取内容，并将其映射到一个新的<see cref="Wasm"/> 
    /// 文件对象中。 本类解析的 Wasm 文件需要提前解压缩和解密。
    /// </summary>
    public class Reader {
        private BinaryReader binReader = null;

        /// <summary>
        /// 从目标文件流中获取数据
        /// </summary>
        /// <param name="input">内容流</param>
        public void Read (Stream input) {
            if (binReader != null)
                binReader.Dispose();
            binReader = new BinaryReader(input, Encoding.UTF8);

            // 一个合格的 Wasm 由两个 uint32 类型开头，分别是
            //   1. Magic Number (uint32)
            //   2. Version      (uint32)

            uint magicNumber = binReader.ReadUInt32();
            uint version = binReader.ReadUInt32();

            // 模块序言后面是一系列部分。每个部分都由一个 1 字节的部分代码标识，该代码对已知部分
            // 或自定义部分进行编码。然后是段长度和有效载荷数据。已知节的ID为非零，而自定义节的
            // ID 为 0 ，后跟标识字符串，作为有效负载的一部分。

            //   1. Id                  (varuint7)
            //   2. Payload Length      (varuint32)
            //   3. Name Length?        (varuint32)                             |
            //   4. Name?               (utf-8 string byte*)   | Name Length    |
            //   5. Payload Data        (byte*)                                 | Payload Length
            //   
            //   注： 3，4节只在 Id == 0 时才存在
            
            try {
                while(binReader.PeekChar() > -1) {
                    uvintn id = binReader.ReadUVIntN();
                    uvintn payloadLength = binReader.ReadUVIntN();
                    uint offset = 0;
                    switch ((ushort)id) {
                        case 0:
                            uvintn nameLength = binReader.ReadUVIntN(ref offset);
                            byte[] name = binReader.ReadBytes((int)((uint)nameLength));
                            string s = Encoding.UTF8.GetString(name);
                            byte[] data = binReader.ReadBytes((int)((uint)payloadLength - offset - (sizeof(byte) * name.Length)));
                            Console.WriteLine("Custom Section: " + name);
                            break;
                        case 1:
                            Console.WriteLine("Type Section");
                            offset = 0;
                            uvintn typeCount = binReader.ReadUVIntN(ref offset);
                            
                            for(uint i = 0; i<(ushort)typeCount; i++) {
                                string sExp = "(type (;"+i.ToString()+";) (";

                                vintn form = binReader.ReadVIntN(ref offset);
                                switch ((short)form) {
                                    case -0x01: sExp = sExp + "i32 ";break;
                                    case -0x02: sExp = sExp + "i64 "; break;
                                    case -0x03: sExp = sExp + "f32 "; break;
                                    case -0x04: sExp = sExp + "f64 "; break;
                                    case -0x10: sExp = sExp + "anyfunc "; break;
                                    case -0x20: sExp = sExp + "func "; break;
                                    case -0x40: sExp = sExp + "block_type "; break;
                                    default:
                                        break;
                                }

                                uvintn paramCount = binReader.ReadUVIntN( ref offset);
                                if ((ushort)paramCount > 0) {
                                    sExp = sExp + "(param ";
                                    for (int param_i = 0; param_i < (ushort)paramCount; param_i++) {
                                        vint7 paramType = binReader.ReadByte();
                                        switch ((sbyte)paramType) {
                                            case -0x01: sExp = sExp + "i32 "; break;
                                            case -0x02: sExp = sExp + "i64 "; break;
                                            case -0x03: sExp = sExp + "f32 "; break;
                                            case -0x04: sExp = sExp + "f64 "; break;
                                            case -0x10: sExp = sExp + "anyfunc "; break;
                                            case -0x20: sExp = sExp + "func "; break;
                                            case -0x40: sExp = sExp + "block_type "; break;
                                            default:
                                                break;
                                        }
                                        offset++;
                                    }
                                    if ((uint)paramCount > 0) sExp = sExp + ") ";
                                }

                                uvintn returnCount = binReader.ReadUVIntN(ref offset);
                                if((ushort)returnCount == 1) {
                                    vintn returnType = binReader.ReadVIntN(ref offset);
                                    sExp = sExp + "(result ";
                                    switch ((sbyte)returnType) {
                                        case -0x01: sExp = sExp + "i32 "; break;
                                        case -0x02: sExp = sExp + "i64 "; break;
                                        case -0x03: sExp = sExp + "f32 "; break;
                                        case -0x04: sExp = sExp + "f64 "; break;
                                        case -0x10: sExp = sExp + "anyfunc "; break;
                                        case -0x20: sExp = sExp + "func "; break;
                                        case -0x40: sExp = sExp + "block_type "; break;
                                        default:
                                            break;
                                    }
                                    sExp = sExp + ")";
                                }
                                sExp = sExp + "))";
                                Console.WriteLine(sExp);
                            }

                            if((uint)payloadLength-offset>0) {
                                Console.WriteLine("Payload Leak Exist");
                                binReader.ReadBytes((int)((uint)payloadLength - offset));
                            }

                            break;
                        case 2:
                            Console.WriteLine("Import Section");

                            offset = 0;
                            uvintn importCount = binReader.ReadUVIntN(ref offset);

                            for (int i = 0; i < (ushort)importCount; i++) {
                                uvintn moduleLength = binReader.ReadUVIntN(ref offset);
                                byte[] moduleName = binReader.ReadBytes((ushort)moduleLength);
                                uvintn fieldLength = binReader.ReadUVIntN(ref offset);
                                byte[] fieldName = binReader.ReadBytes((ushort)fieldLength);
                                uvintn importType = binReader.ReadUVIntN(ref offset);
                                string s_moduleName = Encoding.UTF8.GetString(moduleName);
                                string s_importName = Encoding.UTF8.GetString(fieldName);
                                offset = offset + (uint)((uint)moduleLength + (uint)fieldLength );

                                switch ((ushort)importType) {
                                    case 0:
                                        uvintn funcType = binReader.ReadUVIntN(ref offset);
                                        Console.WriteLine("(import \"" + s_moduleName + "\" \"" + s_importName + "\" (func $" + s_importName + " (type " + funcType.ToString() + ")))");
                                        break;
                                    case 1:
                                        uvintn elemType = binReader.ReadUVIntN(ref offset);

                                        uvintn resLimitFlag = binReader.ReadUVIntN(ref offset);
                                        uvintn initial = binReader.ReadUVIntN(ref offset);
                                        if ((ushort)resLimitFlag == 1) {
                                            uvintn maximum = binReader.ReadUVIntN(ref offset);
                                        }
                                        break;
                                    case 2:
                                        uvintn resLimitFlag_m = binReader.ReadUVIntN(ref offset);
                                        uvintn initial_m = binReader.ReadUVIntN(ref offset);
                                        if ((ushort)resLimitFlag_m == 1) {
                                            uvintn maximum_m = binReader.ReadUVIntN(ref offset);
                                        }
                                        break;
                                    case 3:
                                        vintn contentType = binReader.ReadVIntN(ref offset);
                                        uvintn mutable = binReader.ReadUVIntN(ref offset);
                                        break;
                                    default:
                                        break;
                                }
                            }

                            if ((uint)payloadLength - offset > 0) {
                                Console.WriteLine("Payload Leak Exist");
                                binReader.ReadBytes((int)((uint)payloadLength - offset));
                            }

                            break;
                        case 3:
                            Console.WriteLine("Function Section");
                            offset = 0;
                            uvintn functionCount = binReader.ReadUVIntN(ref offset);
                            for(int f_c = 0; f_c < (uint)functionCount; f_c++) {
                                uvintn funcType = binReader.ReadUVIntN(ref offset);
                            }
                            goto default;
                        case 4:
                            Console.WriteLine("Table Section");
                            goto default;
                        case 5:
                            Console.WriteLine("Memory Section");
                            goto default;
                        case 6:
                            Console.WriteLine("Global Section");
                            goto default;
                        case 7:
                            Console.WriteLine("Export Section");
                            goto default;
                        case 8:
                            Console.WriteLine("Start Section");
                            goto default;
                        case 9:
                            Console.WriteLine("Element Section");
                            goto default;
                        case 10:
                            Console.WriteLine("Code Section");

                            offset = 0; 
                            functionCount = binReader.ReadUVIntN(ref offset);
                            for (int f_c = 0; f_c < (uint)functionCount; f_c++) {
                                uvintn bdSize = binReader.ReadUVIntN(ref offset);
                                uint sizeOffset = offset; 
                                uvintn localCount = binReader.ReadUVIntN(ref offset);
                                for(int l_c = 0; l_c < (uint)localCount; l_c++) {
                                    uvintn lpc = binReader.ReadUVIntN(ref offset);
                                    vintn lpType = binReader.ReadVIntN(ref offset); 
                                }
                                uint bodyOffset = offset;
                                uint length = (uint)bdSize - (bodyOffset - sizeOffset);

                                offset = 0;
                                while(offset < length) {
                                    byte code = binReader.ReadByte();
                                    offset++;


                                }
                            }
                            goto default;
                        case 11:
                            Console.WriteLine("Data Section");
                            goto default;
                        default:
                            var payload = binReader.ReadBytes((int)((uint)payloadLength));
                            Console.WriteLine((uint)payloadLength);
                            break;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        enum OpCodes {
            unreachable,
            nop,
            block,
            loop,
            @if,
            @else,
            end,
            br,
            br_if,
            br_table,
            @return,

            call,
            call_indirect,

            drop,
            select,

            get_local,
            set_local,
            tee_local,
            get_global,
            set_global,

            i32_load,
            i64_load,
            f32_load,
            f64_load,
            i32_load8_s,
            i32_load8_u,
            i32_load16_s,
            i32_load16_u,
            i64_load8_s,
            i64_load8_u,
            i64_load16_s,
            i64_load16_u,
            i64_load32_s,
            i64_load32_u,
            i32_store,
            i64_store,
            f32_store,
            f64_store,
            i32_store8,
            i32_store16,
            i64_store8,
            i64_store16,
            i64_store32,
            current_memory,
            grow_memory,

            i32_const,
            i64_const,
            f32_const,
            f64_const,


        }
    }
}
