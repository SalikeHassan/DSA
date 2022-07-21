using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    internal static class ReverseString
    {
        //Time complexity O(N)
        internal static void PrintReverseStringForGivenIndexes(string str, int l, int r)
        {
            char[] arrStr = str.ToArray();
            while (l < r)
            {
                char temp = arrStr[l];
                arrStr[l] = arrStr[r];
                arrStr[r] = temp;
                r--;
                l++;
            }

            for (int idx = 0; idx < arrStr.Length; idx++)
            {
                Console.Write($"{arrStr[idx]} ");
            }
        }

        internal static void PrintReverseStringWordbyWord(string str)
        {
            char[] arrStr = str.ToCharArray();
            int len = arrStr.Length - 1;
            int tail = len;
            int j = 0;

            char[] result = new char[len + 1];

            for (int i = len; i >= 0; i--)
            {
                if (arrStr[i] == '-')
                {
                    for (int idx = i + 1; idx <= tail; idx++)
                    {
                        result[j] = arrStr[idx];
                        j++;
                    }

                    tail = i - 1;
                }
            }

            int index = 0;
            while (arrStr[index] != '-')
            {
                result[j++] = arrStr[index];
                index++;
            }

            for (int i = 0; i <= len; i++)
            {
                Console.Write($"{result[i]} ");
            }

        }

        internal static void PrintReverseStringWordbyWordOptimized(string str)
        {
            char[] arrCharacters = str.ToCharArray();
            int size = arrCharacters.Length;

            //Reverse the entire char array
            int startIdx = 0;
            int endIdx = size - 1;
            int leftIdx = 0;
            int rightIdx = 0;

            //Time complexity O(N)
            while (startIdx <= endIdx)
            {
                char temp = arrCharacters[startIdx];
                arrCharacters[startIdx] = arrCharacters[endIdx];
                arrCharacters[endIdx] = temp;

                startIdx++;
                endIdx--;
            }

            //Swap the reverse array elements
            for (int idx = 0; idx < size; idx++)
            {
                if (arrCharacters[idx] == '-')
                {
                    rightIdx = idx;
                    arrCharacters = SwapCharacters(arrCharacters, leftIdx, rightIdx - 1);
                    leftIdx = rightIdx + 1;
                }
            }

            arrCharacters = SwapCharacters(arrCharacters, leftIdx, size - 1);

            //Time complexity O(N)
            for (int idx = 0; idx < size; idx++)
            {
                Console.Write($"{arrCharacters[idx]} ");
            }

        }

        private static char[] SwapCharacters(char[] arrCharacters, int leftIdx, int rightIdx)
        {
            while (leftIdx <= rightIdx)
            {
                char temp = arrCharacters[leftIdx];
                arrCharacters[leftIdx] = arrCharacters[rightIdx];
                arrCharacters[rightIdx] = temp;
                leftIdx++;
                rightIdx--;
            }

            return arrCharacters;
        }
    }
}
