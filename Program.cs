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
            float f = 0.0f;

            for (int i = 0; i < 1000000; i++)
            {
                f += 0.001f;
                Console.WriteLine(f);
                if (i % 25 == 0)
                    Console.ReadKey();
            }

            Console.WriteLine(f);
        }
    }
}
