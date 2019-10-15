using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC1
{
    class Program
    {
        static void Main(string[] args)
        {
            double f = 0.0;

            for (int i = 0; i < 1000000; i++)
            {
                f += 0.001;
            }

            Console.WriteLine(f);
        }
    }
}
