using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
    class Program
    {
        /// <summary>
        /// Convert input from base b to base 10
        /// </summary>
        /// <param name="input"></param>
        /// <param name="b"></param>
        /// <returns>value in base 10</returns>
        static int Convert_b_10(string input, int b)
        {
            int value = 0;

            input = input.ToUpper();
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    value = value * b + (input[i] - '0');
                }
                else if (input[i] >= 'A' && input[i] <= 'F')
                    value = value * b + (input[i] - 'A' + 10);

            }
            return value;
        }
        static string Convert_10_b(int n, int b)
        {
            int r;
            char c;
            StringBuilder sb = new StringBuilder();
            while (n > 0)
            {
                r = n % b;
                n = n / b;
                if (r < 10)
                {
                    c = (char)('0' + r);
                }
                else
                {
                    c = (char)('A' + (r - 10));
                }
                sb.Append(c);
            }






            return Reverse(sb.ToString());
        }

        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            int n =17;

            Console.WriteLine(Convert_10_b(n, 3));

            //Console.WriteLine(Convert_b_10("100101", 2));
        }
    }
}
