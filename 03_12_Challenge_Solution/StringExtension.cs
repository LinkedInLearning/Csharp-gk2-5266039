using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Solution
{
    internal static class StringExtension
    {
        public static string ReverseString(this string input)
        {
            var zeichen = input.ToCharArray();
            Array.Reverse( zeichen );
            return new string( zeichen );
        }
    }
}
