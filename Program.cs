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


            float f1 = 0.0f;
            float eps = 0.00001f;
            f1 = 0.01f + 0.01f + 0.01f + 0.01f + 0.01f + 0.01f;

            Console.WriteLine(f1);
            if (Math.Abs(f1 - 0.06f) < eps)
                Console.WriteLine("Egale");
            else
                Console.WriteLine("Nu sunt egale");

            Console.WriteLine(f);
        }
    }
}
