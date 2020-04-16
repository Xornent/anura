using System;
using System.Linq;
using System.Reflection;

namespace Anura.JavaScript {
    internal static partial class ReflectionExtensions {
        internal static bool IsEnum (this Type type) {
            return type.GetTypeInfo ().IsEnum;
        }

        internal static bool IsGenericType (this Type type) {
            return type.GetTypeInfo ().IsGenericType;
        }

        internal static bool IsValueType (this Type type) {
            return type.GetTypeInfo ().IsValueType;
        }

        internal static bool HasAttribute<T> (this ParameterInfo member) where T : Attribute {
            return member.GetCustomAttributes<T> ().Any ();
        }
    }
}