using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 458, baza = 16;

            Console.WriteLine(Convert_10_b(n, baza));


            string numar = "CAFEBABE";
            baza = 16;
            Console.WriteLine(Convert_b_10(numar, baza));
        }

        private static long Convert_b_10(string numar, int baza)
        {
            long result = 0;

            for (int i = 0; i < numar.Length; i++)
            {
                result = result * baza + Digit2Num(numar[i]);
            }

            return result;
        }

        private static long Digit2Num(char v)
        {
            long result = 0;
            if (v >= '0' && v <= '9')
                result = v - '0';
            else if (v >= 'A' && v <= 'F')
                result = v - 'A' + 10;

            return result;
        }

        private static string Convert_10_b(int n, int baza)
        {
            int rest;
            Stack<int> stiva = new Stack<int>();
            while (n > 0)
            {
                rest = n % baza;
                stiva.Push(rest);
                n = n / baza;
            }
            StringBuilder sb = new StringBuilder();
            int cifra;
            while (stiva.Count > 0)
            {
                cifra = stiva.Pop();
                sb.Append(Num2Digit(cifra));
            }
            return sb.ToString();
        }

        private static char Num2Digit(int cifra)
        {
            char ch;
            if (cifra >= 0 && cifra <= 9)
                ch = (char)('0' + cifra);
            else if (cifra >= 10 && cifra <= 15)
                ch = (char)('A' + cifra - 10);
            else ch = 'X';

            return ch;
        }
    }
}
