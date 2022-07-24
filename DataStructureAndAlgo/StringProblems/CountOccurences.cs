using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    internal static class CountOccurences
    {
        internal static void CountBobOccurences(string str)
        {
            char[] arrChars = str.ToCharArray();
            int size = arrChars.Length;
            int cnt = 0;

            for (int idx = 0; idx < size; idx++)
            {
                if (arrChars[idx] == 'b')
                {
                    int midIdx = idx + 1;
                    int rightIdx = idx + 2;

                    if (midIdx < size && rightIdx < size &&
                        arrChars[midIdx] == 'o' && arrChars[rightIdx] == 'b')
                    {
                        cnt++;

                        idx = idx + 1;
                    }
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
