// Copyright (c) 2020 Jonathan Wood (www.softcircuits.com)
// Licensed under the MIT license.
//

using System.Collections.Generic;
using System.Text;

namespace Anura.JavaScript.Formatter {
    /// <summary>
    /// Class to track script indents.
    /// </summary>
    internal class Indents {
        // Characters used for indent tabs
        private readonly string Tab;

        protected Stack<IndentFlags> IndentStack = new Stack<IndentFlags> ();

        /// <summary>
        /// Current indent depth.
        /// </summary>
        public int Count => IndentStack.Count;

        /// <summary>
        /// Gets the most recently removed indent.
        /// </summary>
        public IndentFlags LastIndent { get; private set; } = IndentFlags.None;

        public Indents (string tab) {
            Tab = tab;
        }

        /// <summary>
        /// Gets or sets the most recently added indent.
        /// </summary>
        public IndentFlags Current {
            get {
                if (IndentStack.Count > 0)
                    return IndentStack.Peek ();
                return IndentFlags.None;
            }
            set {
                if (IndentStack.Count > 0) {
                    IndentStack.Pop ();
                    IndentStack.Push (value);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="flags"></param>
        public void Indent (IndentFlags flags) {
            IndentStack.Push (flags);
        }

        /// <summary>
        /// Removes and returns the most recently added tab.
        /// </summary>
        public IndentFlags Unindent () {
            if (IndentStack.Count > 0)
                LastIndent = IndentStack.Pop ();
            else
                LastIndent = IndentFlags.None;
            return LastIndent;
        }

        /// <summary>
        /// Strips the trailing indent from the given StringBuilder.
        /// </summary>
        public void StripTrailingIndent (StringBuilder builder) {
            if (Tab.Length <= builder.Length)
                builder.Remove (builder.Length - Tab.Length, Tab.Length);
        }

        /// <summary>
        /// Returns a string representing the current indentation whitespace.
        /// </summary>
        public override string ToString () {
            StringBuilder builder = new StringBuilder (Tab.Length * IndentStack.Count);
            for (int i = 0; i < IndentStack.Count; i++)
                builder.Append (Tab);
            return builder.ToString ();
        }
    }
}