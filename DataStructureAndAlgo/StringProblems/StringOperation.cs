using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    internal static class StringOperation
    {
        internal static void ConcatDelReplaceOperation(string str)
        {
            char[] arrChars = (str + str).ToCharArray();
            int size = arrChars.Length;
            int steps = 0;
            StringBuilder sb = new StringBuilder();

            
            for (int idx = size - 1; idx >= 0; idx--)
            {
                if (arrChars[idx] >= 65 && arrChars[idx] <= 90)
                {
                    for (int idx2 = idx; idx2 < idx + steps; idx2++)
                    {
                        arrChars[idx2] = arrChars[idx2 + 1];
                    }

                    arrChars[idx + steps] = '\0';
                }
                else
                {
                    steps++;
                }
            }

            steps = 0;

            while (arrChars[steps] != '\0')
            {
                if (arrChars[steps] == 'a' ||
                       arrChars[steps] == 'e' ||
                       arrChars[steps] == 'i' ||
                       arrChars[steps] == 'o' ||
                       arrChars[steps] == 'u' ||
                       arrChars[steps] == 'A' ||
                       arrChars[steps] == 'E' ||
                       arrChars[steps] == 'I' ||
                       arrChars[steps] == 'O' ||
                       arrChars[steps] == 'U'
                   )
                {
                    arrChars[steps] = '#';
                }

                sb.Append(arrChars[steps]);

                steps++;
            }

            Console.Write(sb.ToString());


        }
    }
}
