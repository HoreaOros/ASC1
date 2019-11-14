using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorBCD4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 305; // 0011 0000 0101

            Console.WriteLine(n.ConvertToBCD());
            
        }
    }
}
