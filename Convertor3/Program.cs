using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 42;
            //int baza = 16;

            //Console.WriteLine(Convert_10_b(n, baza));

            //string numar = "CAFEBABE";
            //int baza = 16;
            //Console.WriteLine(Convert_b_10(numar, 16));
            float f;

            f = 1.0f / (2 * 0);

            Console.WriteLine(f);
            if (float.IsInfinity(f))
            {
                Console.WriteLine("Infinit");
            }

            f = 0.0f / 0.0f;
            f += 10f;
            Console.WriteLine(f);

        }

        private static long Convert_b_10(string numar, int baza)
        {
            long result = 0;
            for (int i = 0; i < numar.Length; i++)
            {
                result = result * baza + GetDigitValue(numar[i]);
            }
            return result;
        }

        private static long GetDigitValue(char v)
        {
            if (v >= '0' && v <= '9')
                return v - '0';
            else if (v >= 'A' && v <= 'F')
                return v - 'A' + 10;
            else
                return 0;
        }

        private static string Convert_10_b(int n, int baza)
        {
            int rest;
            int cifra;
            Stack<int> stack = new Stack<int>();
            while (n > 0)
            {
                rest = n % baza;
                stack.Push(rest);
                n = n / baza;
            }

            StringBuilder sb = new StringBuilder();
            while (stack.Count > 0)
            {
                cifra = stack.Pop();
                if (cifra >= 0 && cifra <= 9)
                    sb.Append((char)('0' + cifra));
                else if(cifra >= 10 && cifra <= 15)
                    sb.Append((char)('A' + (cifra - 10)));
                    //sb.Append(cifra.ToString("X"));
            }

            return sb.ToString();


        }
    }
}
