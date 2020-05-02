namespace Anura.Typography.OpenFont.CFF {
    internal enum OperatorName : byte {
        Unknown,
        LoadInt,
        GlyphWidth,
        [OriginalType2Operator (Type2Operator1.hstem)]
        hstem,
        [OriginalType2Operator (Type2Operator1.vstem)]
        vstem,
        [OriginalType2Operator (Type2Operator1.vmoveto)]
        vmoveto,
        [OriginalType2Operator (Type2Operator1.rlineto)]
        rlineto,
        [OriginalType2Operator (Type2Operator1.hlineto)]
        hlineto,
        [OriginalType2Operator (Type2Operator1.vlineto)]
        vlineto,
        [OriginalType2Operator (Type2Operator1.rrcurveto)]
        rrcurveto,
        [OriginalType2Operator (Type2Operator1.callsubr)]
        callsubr,
        [OriginalType2Operator (Type2Operator1._return)]
        _return,
        [OriginalType2Operator (Type2Operator1.endchar)]
        endchar,
        [OriginalType2Operator (Type2Operator1.hstemhm)]
        hstemhm,
        [OriginalType2Operator (Type2Operator1.hintmask)]
        hintmask1,
        [OriginalType2Operator (Type2Operator1.hintmask)]
        hintmask2,
        [OriginalType2Operator (Type2Operator1.hintmask)]
        hintmask3,
        [OriginalType2Operator (Type2Operator1.hintmask)]
        hintmask4,
        [OriginalType2Operator (Type2Operator1.hintmask)]
        hintmask_bits,
        [OriginalType2Operator (Type2Operator1.cntrmask)]
        cntrmask1,
        [OriginalType2Operator (Type2Operator1.cntrmask)]
        cntrmask2,
        [OriginalType2Operator (Type2Operator1.cntrmask)]
        cntrmask3,
        [OriginalType2Operator (Type2Operator1.cntrmask)]
        cntrmask4,
        [OriginalType2Operator (Type2Operator1.cntrmask)]
        cntrmask_bits,
        [OriginalType2Operator (Type2Operator1.rmoveto)]
        rmoveto,
        [OriginalType2Operator (Type2Operator1.hmoveto)]
        hmoveto,
        [OriginalType2Operator (Type2Operator1.vstemhm)]
        vstemhm,
        [OriginalType2Operator (Type2Operator1.rcurveline)]
        rcurveline,
        [OriginalType2Operator (Type2Operator1.rlinecurve)]
        rlinecurve,
        [OriginalType2Operator (Type2Operator1.vvcurveto)]
        vvcurveto,
        [OriginalType2Operator (Type2Operator1.hhcurveto)]
        hhcurveto,
        [OriginalType2Operator (Type2Operator1.shortint)]
        shortint,
        [OriginalType2Operator (Type2Operator1.callgsubr)]
        callgsubr,
        [OriginalType2Operator (Type2Operator1.vhcurveto)]
        vhcurveto,
        [OriginalType2Operator (Type2Operator1.hvcurveto)]
        hvcurveto,
        [OriginalType2Operator (Type2Operator2.and)]
        and,
        [OriginalType2Operator (Type2Operator2.or)]
        or,
        [OriginalType2Operator (Type2Operator2.not)]
        not,
        [OriginalType2Operator (Type2Operator2.abs)]
        abs,
        [OriginalType2Operator (Type2Operator2.add)]
        add,
        [OriginalType2Operator (Type2Operator2.sub)]
        sub,
        [OriginalType2Operator (Type2Operator2.div)]
        div,
        [OriginalType2Operator (Type2Operator2.neg)]
        neg,
        [OriginalType2Operator (Type2Operator2.eq)]
        eq,
        [OriginalType2Operator (Type2Operator2.drop)]
        drop,
        [OriginalType2Operator (Type2Operator2.put)]
        put,
        [OriginalType2Operator (Type2Operator2.get)]
        get,
        [OriginalType2Operator (Type2Operator2.ifelse)]
        ifelse,
        [OriginalType2Operator (Type2Operator2.random)]
        random,
        [OriginalType2Operator (Type2Operator2.mul)]
        mul,
        [OriginalType2Operator (Type2Operator2.sqrt)]
        sqrt,
        [OriginalType2Operator (Type2Operator2.dup)]
        dup,
        [OriginalType2Operator (Type2Operator2.exch)]
        exch,
        [OriginalType2Operator (Type2Operator2.index)]
        index,
        [OriginalType2Operator (Type2Operator2.roll)]
        roll,
        [OriginalType2Operator (Type2Operator2.hflex)]
        hflex,
        [OriginalType2Operator (Type2Operator2.flex)]
        flex,
        [OriginalType2Operator (Type2Operator2.hflex1)]
        hflex1,
        [OriginalType2Operator (Type2Operator2.flex1)]
        flex1
    }
}