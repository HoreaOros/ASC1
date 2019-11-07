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
            //Console.WriteLine(ConvertBCDUnsigned(n));
            //Console.WriteLine(ConvertBCDSigned(m));

            int choice;
            bool done = false;
            while (!done)
            { 
                printMenu();
                try
                {
                    choice = getNumber();
                }
                catch (Exception)
                {
                    choice = -1;
                }
                switch (choice)
                {
                    case -1:
                        break;
                    case 1:
                        try
                        {
                            n = getNumber();
                        }
                        catch (Exception)
                        {
                            n = -1;
                        }
                        if(n >= 0)
                            Console.WriteLine(ConvertBCDUnsigned(n));
                        else
                            Console.WriteLine("Numarul introdus nu este fara semn");
                        break;
                    case 2:
                        // TODO
                        break;
                    case 3:
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }

        }

        private static int getNumber()
        {
            string line;
            line = Console.ReadLine();
            int n;

            try
            {
                n = int.Parse(line);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }


            return n;

        }

        private static void printMenu()
        {
            Console.WriteLine("Alegeti o optiune");
            Console.WriteLine("1. Convert BCD Unsigned");
            Console.WriteLine("2. Convert BCD Signed");
            Console.WriteLine("3. Quit");
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
