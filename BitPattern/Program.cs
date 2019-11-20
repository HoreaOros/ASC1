using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 52f;
            int n = 2123589158;

            double d = Math.Pow(2, 127);
            byte[] b = BitConverter.GetBytes(0);


            StringBuilder sb = new StringBuilder();
            for (int i = b.Length - 1; i >= 0; i--)
            {
                sb.Append(Byte2Binary(b[i]));
                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString());
        }

        private static string Byte2Binary(byte v)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 8; i++)
            {
                sb.Insert(0, ((v >> i) & 1) == 1 ? "1" : "0");
            }

            return sb.ToString();
        }
    }
}
