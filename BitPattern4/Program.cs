using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitPattern4
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n1 = 1u; // 000 ..... 0001
            uint n2 = 511u; // 0000....000111111111; 
            uint n3 = 2589758321u;
            float f = 52; // 

            byte[] b = BitConverter.GetBytes(n3);
            StringBuilder sb = new StringBuilder();
            for (int i = b.Length - 1; i >= 0; i--)
            {
                // Console.Write(Convert.ToString(b[i], 2).PadLeft(8, '0'));
                sb.Append(b[i].BitPattern());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
