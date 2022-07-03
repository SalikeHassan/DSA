using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionProblems
{
    internal class ReverseString
    {
        internal static void Reverse(string str, int index)
        {
            if (index < 0)
            {
                return;
            }
            else
            {
                Console.Write(str[index]);
                index = index - 1;
                Reverse(str, index);
            }
        }
    }
}
