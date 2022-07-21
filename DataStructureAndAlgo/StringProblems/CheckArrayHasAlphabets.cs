using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    internal static class CheckArrayHasAlphabets
    {
        internal static void CheckIfArrayHasAlphabets(char[] A)
        {
            int size = A.Length;
            bool isAllAlphabets = true;

            for (int idx = 0; idx < size; idx++)
            {
                int asciiValue = (int)A[idx];

                if (!(asciiValue >= (int)'a' && asciiValue <= (int)'z')
                    && !(asciiValue >= (int)'A' && asciiValue <= (int)'Z'))
                {
                    isAllAlphabets = false;
                    break;
                }
            }

            Console.WriteLine(isAllAlphabets);
        }
    }
}
