// Copyright (c) 2020 Jonathan Wood (www.softcircuits.com)
// Licensed under the MIT license.
//

namespace Anura.JavaScript.Formatter {
    /// <summary>
    /// Enumeration of available token types.
    /// </summary>
    internal enum TokenType {
        Unknown,
        OpenBrace,
        CloseBrace,
        OpenParen,
        CloseParen,
        OpenBracket,
        CloseBracket,
        Symbol,
        String,
        Number,
        RegEx,
        SemiColon,
        Comma,
        Colon,
        Dot,
        QuestionMark,
        BinaryOperator,
        UnaryPrefix,
        UnarySuffix,
        LineComment,
        InlineComment,
    }
}