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

            var str = "842554936302263";
            long num = Convert.ToInt64(str);
            long res = num % 41;
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
