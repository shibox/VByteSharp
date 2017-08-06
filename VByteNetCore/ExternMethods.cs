using System;
using System.Runtime.InteropServices;
using size_t = System.UIntPtr;

namespace VByteNetCore
{
    public class ExternMethods
    {
        private const string DllName = "lib\\x64\\vbyte.dll";

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vbyte_encode(uint[] @in, size_t length, byte[] bout);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint masked_vbyte_decode(byte[] @in, uint[] @out, ulong length);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Add(int x, int y);

        //(uint32_t *in, size_t length, uint8_t *bout)
        //(const uint8_t* in, uint32_t* out,uint64_t length)

    }
}
