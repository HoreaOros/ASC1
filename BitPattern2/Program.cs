using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            float f = (float)Math.Pow(2, 127);
            float infinity = 1f / 0f;
            double d = Math.Pow(2, -128);
            byte[] b = BitConverter.GetBytes(f);

            

            StringBuilder sb = new StringBuilder();
            for (int i = b.Length - 1; i >= 0; i--)
            {
                //sb.Append(Convert.ToString(b[i], 2).PadLeft(8, '0'));
                sb.Append(Byte2BitPattern(b[i]));
            }
            Console.WriteLine(sb.ToString());

        }

        private static string Byte2BitPattern(byte v)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                sb.Insert(0, (((v >> i) & 1) == 1)?"1":"0");
            }
            return sb.ToString();
        }

    }
}
