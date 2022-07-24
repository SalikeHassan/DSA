using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    internal static class LongestPallindrome
    {
        //Time Complexity Best O(N^2)
        //Worst O(N^3)
        internal static void PrintLongestPallindromeStrLength(string str)
        {
            char[] arrChar = str.ToCharArray();

            int left = 0;
            int right = 0;
            int size = arrChar.Length;
            int cnt = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    int temp = cnt;

                    if (arrChar[i] == arrChar[j])
                    {
                        right = j;
                        left = i;

                        while (left <= right)
                        {
                            if (arrChar[left] == arrChar[right])
                            {
                                cnt++;
                                left++;
                                right--;
                            }
                            else
                            {
                                cnt = 0;
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"{cnt}");
        }

        internal static void PrintLongestPallindromeStrLengthOptimized(string str)
        {
            char[] arrChar = str.ToCharArray();
            int size = arrChar.Length;
            int cnt = 0;

            //Odd length palindrome
            //O(N^2)
            for (int idx = 0; idx < size; idx++)
            {
                cnt = Math.Max(cnt, (int)Expand(arrChar, idx, idx));
            }

            //Even length palindrome
            //O(N^2)
            for (int idx = 0; idx < size - 1; idx++)
            {
                cnt = Math.Max(cnt, (int)Expand(arrChar, idx, idx + 1));
            }

            Console.WriteLine(cnt);
        }

        private static int Expand(char[] arrChar, int idx1, int idx2)
        {
            while (idx1 >= 0 && idx2 < arrChar.Length && arrChar[idx1] == arrChar[idx2])
            {
                idx1--;
                idx2++;
            }

            return idx2 - idx1 - 1;
        }

        public static void PrintLongestPallindromeSubStr(string A)
        {
            char[] arrChar = A.ToCharArray();
            int size = arrChar.Length;
            string str1 = "";
            string str2 = "";
            string result = "";

            for (int idx = 0; idx < size; idx++)
            {
                str1 = GetSubStr(arrChar, idx, idx);

                str2 = GetSubStr(arrChar, idx, idx + 1);

                if (result.Length < str1.Length || result.Length < str2.Length)
                {
                    result = str1.Length < str2.Length ? str2 : str1;
                }
            }

            Console.WriteLine(result);
        }

        private static string GetSubStr(char[] arrChar, int idx1, int idx2)
        {
            StringBuilder sb = new StringBuilder();

            while (idx1 >= 0 && idx2 < arrChar.Length && arrChar[idx1] == arrChar[idx2])
            {
                idx1--;
                idx2++;
            }

            idx1 = idx1 + 1;

            while (idx1 < idx2)
            {
                sb.Append(arrChar[idx1]);
                idx1++;
            }

            return sb.ToString();
        }
    }
}
