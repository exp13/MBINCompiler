﻿using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    // todo: maybe get rid of this and just read strings directly into the list, if all strings are the same size?
    public class NMSString0x80 : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Value;
    }
}
