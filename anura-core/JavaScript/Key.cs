using Anura.JavaScript.Runtime;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Anura.JavaScript
{
    /// <summary>
    /// Represents a key that Jint uses with pre-calculated hash code
    /// as runtime does a lot of repetitive dictionary lookups.
    /// </summary>
    [DebuggerDisplay("{" + nameof(Name) + "}")]
    public readonly struct Key : IEquatable<Key>
    {
        private Key(string name) {
            Name = name ?? Anura.JavaScript.Runtime.ExceptionHelper.ThrowArgumentException<string>("name cannot be null");
            HashCode = name.GetHashCode();
        }

        internal readonly string Name;
        internal readonly int HashCode;

        public static implicit operator Key(string name) {
            return new Key(name);
        }

        public static implicit operator string(Key key) {
            return key.Name;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(in Key a, in Key b) {
            return a.HashCode == b.HashCode && a.Name == b.Name;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(in Key a, in Key b) {
            return a.HashCode != b.HashCode || a.Name != b.Name;
        }

        public static bool operator ==(in Key a, string b) {
            return a.Name == b;
        }

        public static bool operator !=(in Key a, string b) {
            return a.Name != b;
        }

        public bool Equals(Key other) {
            return HashCode == other.HashCode && Name == other.Name;
        }

        public override bool Equals(object obj) {
            return obj is Key other && Equals(other);
        }

        public override int GetHashCode() {
            return HashCode;
        }

        public override string ToString() {
            return Name;
        }
    }
}