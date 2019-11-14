using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace ConvertorBCD4
{
    static class Extensions
    {
        public static string ConvertToBCD(this int n)
        {
            Stack<int> stack = new Stack<int>();

            int cifra;
            while (n > 0)
            {
                cifra = n % 10;
                n = n / 10;
                stack.Push(cifra);
            }

            string[] bcd = {"0000", "0001", "0010", "0011", "0100",
                "0101", "0110", "0111", "1000", "1001" };

            StringBuilder sb = new StringBuilder();
            while (stack.Count > 0)
            {
                cifra = stack.Pop();
                sb.Append(bcd[cifra]);
                sb.Append(" ");
            }
            
            
            return sb.ToString();
        }
    }
}
