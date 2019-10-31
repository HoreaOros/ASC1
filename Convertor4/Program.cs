using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 255;
            int baza = 8;
            Console.WriteLine(Convert_10_b(n, baza));

            string numar = "babe";
            baza = 16;
            Console.WriteLine(Convert_b_10(numar, baza));
        }

        private static int Convert_b_10(string numar, int baza)
        {
            int result = 0;
            for (int i = 0; i < numar.Length; i++)
            {
                result = result * baza + Digit2Num(numar[i]);
            }

            return result;
        }

        private static int Digit2Num(char v)
        {
            v = char.ToUpper(v);
            if (v >= '0' && v <= '9')
            {
                return v - '0';
            }
            else if (v >= 'A' && v <= 'Z')
                return v - 'A' + 10;
            else
                return 0; // aici nu ar trebuie sa se ajunga??
        }

        private static string Convert_10_b(int n, int baza)
        {
            int cifra;

            Stack<int> stack = new Stack<int>();

            while (n > 0)
            {
                cifra = n % baza;
                n = n / baza;
                stack.Push(cifra);
            }

            StringBuilder sb = new StringBuilder();
            while (stack.Count > 0)
            {
                cifra = stack.Pop();
                sb.Append(Num2Digit(cifra));
            }

            return sb.ToString();
        }

        private static char Num2Digit(int cifra)
        {
            if (cifra >= 0 && cifra <= 9)
            {
                return (char)('0' + cifra);
            }
            else if (cifra >= 10 && cifra <= 15)
                return (char)('A' + cifra - 10);
            
            return 'X';
        }
    }
}
