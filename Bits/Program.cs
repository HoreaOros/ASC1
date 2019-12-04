using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bits
{
    class Program
    {
        static void BitPattern(uint n)
        {
            byte[] b;
            b = BitConverter.GetBytes(n);
            for (int i = b.Length - 1; i >= 0; i--)
            {
                Console.Write($"{Convert.ToString(b[i], 2).PadLeft(8, '0')} ");
                //Console.Write($"{b[i].BitPattern()} ");
            }
            Console.WriteLine();
        }
        static void SetBit(ref uint n, int position)
        {
            if(position >= 0 && position <= 31)
                n = n | (1u << position);
            //1u      00000000 00000000 00000000 00000001
            // -------------------------------------------
            //1u << 7 00000000 00000000 00000000 10000000 
            //    |   01000011 11110000 11010011 01111000
            // ------------------------------------------
            //        01000011 11110000 11010011 11111000
        }
        static void Main(string[] args)
        {
            uint instr = 0u;
            BitPattern(instr);

            SetBit(ref instr, 7);
            BitPattern(instr);

            SetBit(ref instr, 15);
            BitPattern(instr);

            SetBit(ref instr, 23);
            BitPattern(instr);

            SetBit(ref instr, 31);
            BitPattern(instr);


            ResetBit(ref instr, 23);
            BitPattern(instr);


            for (int pos = 0; pos < 32; pos++)
            {
                Console.WriteLine($"Position {pos} is {GetBit(instr, pos)}");
            }


            int low = 30, high = 31, value = 2;
            SetBits(ref instr, low, high, value);
            uint value =  GetValue(instr, low, high);
        }

        private static uint GetBit(uint instr, int pos)
        {
            return (instr >> pos) & 1u;
        }

        private static void ResetBit(ref uint n, int position)
        {
            //        01000011 11110000 11010011 11111000
            //    &   11111111 11111111 11111111 01111111
            //        -----------------------------------
            //        01000011 11110000 11010011 01111000

            n = n & (~(1u << position));
        }
        // & - SI pe biti
        // | - SAU pe biti
        // ~ - complement
        // ^ - SAU eXclusiv
        // << - deplasare la stanga
        // >> - deplasare la dreapta
    }
}
