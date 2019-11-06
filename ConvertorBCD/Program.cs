using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorBCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 305;
            string bcd;
            bcd = Convert2BCDUnsigned(n);

           
        }

        private static string Convert2BCDUnsigned(int n)
        {

            int cifra;
            string[] cifreBCD = {"0000", "0001", "0010", "0011",
                "0100", "0101", "0110", "0111", "1000", "1001"};


            Stack<int> stack = new Stack<int>();
            while (n > 0)
            {
                cifra = n % 10;
                n /= 10; // echivalent cu n = n / 10;
                stack.Push(cifra);
            }

            StringBuilder sb = new StringBuilder();
            while (stack.Count > 0)
            {
                cifra = stack.Pop();

                sb.Append(cifreBCD[cifra]);
                sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}
