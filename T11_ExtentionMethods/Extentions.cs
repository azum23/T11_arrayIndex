using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_ExtentionMethods
{
    public static class Extentions
    {
        public static int Reverse(this int i)
        {
            char[] digit = i.ToString().ToCharArray();
            Array.Reverse(digit);
            string s = new string(digit);
            return int.Parse(s);
        }
    }
}
