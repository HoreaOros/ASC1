using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitPattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = 1u; // 00...0001
            float f = (float)Math.Pow(2, 32);
            byte[] b;
            b = BitConverter.GetBytes(n);
            Console.WriteLine(BitConverter.IsLittleEndian);
            for (int i = b.Length - 1; i >= 0; i--)
            {
                // Console.Write($"{Convert.ToString(b[i], 2).PadLeft(8, '0')} ");
                Console.Write($"{b[i].BitPattern()} ");
            }
        }
    }
}
