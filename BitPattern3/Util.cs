using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitPattern3
{
    static class Util
    {
        public static string BitPattern(this byte b)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 8; i++)
            {
                sb.Insert(0, ((b >> i) & 1) == 1? "1":"0");
            }

            return sb.ToString();
        }
    }
}
