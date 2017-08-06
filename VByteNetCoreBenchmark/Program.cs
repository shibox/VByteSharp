using System;
using System.Diagnostics;
using System.Linq;
using VByteNetCore;
using size_t = System.UIntPtr;

namespace VByteNetCoreBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] input = new uint[10000];
            for (int i = 0; i < input.Length; i++)
                input[i] = (uint)i;
            byte[] output = new byte[100000];

            uint[] result = new uint[100000];

            long rs = 0;
            uint n = ExternMethods.vbyte_encode(input, (size_t)input.Length, output);
            Stopwatch w = Stopwatch.StartNew();
            for (int i = 0; i < 10000; i++)
                rs += ExternMethods.masked_vbyte_decode(output, result, n);
            
            Console.WriteLine($"count:{n},{rs},cost:{w.ElapsedMilliseconds}");

            //int result = ExternMethods.Add(10, 20);
            //Console.WriteLine("10 + 20 = {0}", result);
            Console.ReadLine();
        }
    }
}
