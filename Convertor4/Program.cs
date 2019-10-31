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
