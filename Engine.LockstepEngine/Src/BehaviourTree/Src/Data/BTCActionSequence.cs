// Copyright 2019 谭杰鹏. All Rights Reserved //https://github.com/JiepengTan 

using System.Runtime.InteropServices;
using Lockstep.Util;

namespace Lockstep.BehaviourTree {
    [StructLayout(LayoutKind.Sequential, Pack = NativeHelper.STRUCT_PACK)]
    public unsafe partial struct BTCActionSequence :IBTContent
    {
        internal int currentSelectedIndex;
        public BTCActionSequence(int idx = -1)
        {
            currentSelectedIndex = idx;
        }
    }
}