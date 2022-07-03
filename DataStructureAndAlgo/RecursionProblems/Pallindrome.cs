using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionProblems
{
    internal class Pallindrome
    {
        internal static bool IsStringPallindrome(string str, int startIndex, int endIndex)
        {
            if (str.Length == 1)
            {
                return true;
            }

            if (startIndex > endIndex)
            {
                return true;
            }

            if (str[startIndex] == str[endIndex])
            {
                startIndex = startIndex + 1;
                endIndex = endIndex - 1;
                return IsStringPallindrome(str, startIndex, endIndex);
            }
            else
            {
                return false;
            }
        }
    }
}
