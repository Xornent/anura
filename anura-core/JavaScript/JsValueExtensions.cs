using Anura.JavaScript.Native;
using Anura.JavaScript.Runtime;
using System.Runtime.CompilerServices;

namespace Anura.JavaScript
{
    public static class JsValueExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AsBoolean(this JsValue value) {
            if (value._type != InternalTypes.Boolean) {
                ThrowWrongTypeException(value, "boolean");
            }

            return ((JsBoolean)value)._value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AsNumber(this JsValue value) {
            if (!value.IsNumber()) {
                ThrowWrongTypeException(value, "number");
            }

            return ((JsNumber)value)._value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int AsInteger(this JsValue value) {
            return (int)((JsNumber)value)._value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string AsString(this JsValue value) {
            if (!value.IsString()) {
                ThrowWrongTypeException(value, "string");
            }

            return AsStringWithoutTypeCheck(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static string AsStringWithoutTypeCheck(this JsValue value) {
            return value.ToString();
        }

        private static void ThrowWrongTypeException(JsValue value, string expectedType) {
            Anura.JavaScript.Runtime.ExceptionHelper.ThrowArgumentException($"Expected {expectedType} but got {value._type}");
        }
    }
}