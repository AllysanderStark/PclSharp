using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using PclSharp.Struct;
using PclSharp.Std;
namespace PclSharp.IO
{
    public static partial class Invoke
    {
        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern void io_concatenateFields(IntPtr cloud1, IntPtr cloud2, IntPtr cloudOut);
    }

    public class Static
    {
        public static void ConcatenateFields(IntPtr cloud1, IntPtr cloud2, IntPtr cloudOut)
        {
            Invoke.io_concatenateFields(cloud1, cloud2, cloudOut);
        }
    }
}