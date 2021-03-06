﻿using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcNGuiLayoutData : NMSTemplate
    {
        public float PositionX;
        public float PositionY;
        public float Width; 
        public bool WidthPercentage;

        [MarshalAs( UnmanagedType.ByValArray, SizeConst = 0x3 )]
        public byte[] Padding1;

        public float Height;
        public bool HeightPercentage;
        public bool ConstrainProportions;

        [MarshalAs( UnmanagedType.ByValArray, SizeConst = 0x2 )]
        public byte[] Padding2;

        public float ConstrainAspect;
        public bool Anchor;
        public bool AnchorPercent;
        public bool SameLine;

        [MarshalAs( UnmanagedType.ByValArray, SizeConst = 0x1 )]
        public byte[] Padding3;

        public TkNGuiAlignment Align;
        public bool SlowCursorOnHower;

        [MarshalAs( UnmanagedType.ByValArray, SizeConst = 0xB )]
        public byte[] Padding4;
    }
}
