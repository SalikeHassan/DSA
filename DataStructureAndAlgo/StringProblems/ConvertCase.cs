using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    internal static class ConvertCase
    {
        internal static void UpperToLowerCase(List<char> chars)
        {
            int size = chars.Count;

            for (int idx = 0; idx < size; idx++)
            {
                if (chars[idx] >= 65 && chars[idx] <= 90)
                {
                    chars[idx] = (char)(chars[idx] + 32);
                }
            }

            for (int idx = 0; idx < size; idx++)
            {
                Console.Write(chars[idx]);
            }
        }

        internal static void LowerToUpperCase(List<char> chars)
        {
            int size = chars.Count;

            for (int idx = 0; idx < size; idx++)
            {
                if (chars[idx] >= 97 && chars[idx] <= 122)
                {
                    chars[idx] = (char)(chars[idx] - 32);
                }
            }

            for (int idx = 0; idx < size; idx++)
            {
                Console.Write(chars[idx]);
            }
        }
    }
}
