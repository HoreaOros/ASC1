using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorBCD2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 305; // 0011 0000 0101

            int choice;
            bool done = false;
            while(!done)
            {
                printMenu();
                try
                {
                    choice = getNumber();
                }
                catch
                {
                    choice = 0;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Introduceti un numar fara semn");
                        try
                        {
                            n = getNumber();
                        }
                        catch (Exception)
                        {
                            break;
                        }
                        Console.WriteLine(Convert2BCDUnsigned(n));
                        break;
                    case 2:
                        Console.WriteLine("Introduceti un numar cu semn");
                        try
                        {
                            n = getNumber();
                        }
                        catch (Exception)
                        {
                            break;
                        }
                        Console.WriteLine(Convert2BCDSigned(n));
                        break;
                    case 3:
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }

        }

        private static bool Convert2BCDSigned(int n)
        {
            throw new NotImplementedException();
        }

        private static int getNumber()
        {
            string line;
            line = Console.ReadLine();
            int n = 0;
            try
            {
                n = int.Parse(line);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
                throw;
            }

            return n;
        }

        private static void printMenu()
        {
            Console.WriteLine("Your choice...");
            Console.WriteLine("1. Unsigned BCD");
            Console.WriteLine("2. Signed BCD - Compl'10");
            Console.WriteLine("3. Quit");
        }

        private static string Convert2BCDUnsigned(int n)
        {
            int cifra;
            string[] bcd = {"0000", "0001", "0010", "0011", 
            "0100", "0101", "0110", "0111", "1000", "1001"};
            Stack<int> stack = new Stack<int>();
            while (n > 0)
            {
                cifra = n % 10;
                n = n / 10;
                stack.Push(cifra);
            }

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
