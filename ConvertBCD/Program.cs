using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertBCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 305; // 0011 0000 0101
            int m = -305; // complem 10; 9999-0305= 9694 + 1 = 
                //9695 --> 1001 0110 1001 0101
            Console.WriteLine(ConvertBCDUnsigned(n));
            Console.WriteLine(ConvertBCDSigned(m));
        }

        private static bool ConvertBCDSigned(int m)
        {
            throw new NotImplementedException();
        }

        private static string ConvertBCDUnsigned(int n)
        {
            Stack<int> stack = new Stack<int>();
            while (n > 0)
            {
                stack.Push(n % 10); // obtin ultima cifra
                n = n / 10; // elimin ultima cifra
            }

            int cifra;
            string[] bcd = {"0000", "0001", "0010", "0011", "0100",
                    "0101", "0110", "0111", "1000", "1001"};
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
