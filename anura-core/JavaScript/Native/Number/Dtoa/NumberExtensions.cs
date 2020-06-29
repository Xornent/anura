﻿using System.Runtime.CompilerServices;

namespace Anura.JavaScript.Native.Number.Dtoa
{
    internal static class NumberExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long UnsignedShift(this long l, int shift) {
            return (long)((ulong)l >> shift);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong UnsignedShift(this ulong l, int shift) {
            return l >> shift;
        }
    }
}
