/*
Find the element that appears once in an array where every other element appears twice

Problem Statement
Given an array of integers. All numbers occur twice except one number which occurs once. 
Find the number in O(n) time & constant extra space.
Example : 

Input:  ar[] = {7, 3, 5, 4, 5, 3, 4}
Output: 7 

https://www.geeksforgeeks.org/find-element-appears-array-every-element-appears-twice/
*/

namespace BitManipulationProblems
{
    using System;
    using System.Collections.Generic;

    internal static class UniqueElementInArray
    {
        internal static void Approach1(int[] arrNum)
        {
            /*
             * Time complexity = O(N)
             * Space complexity = O(N)
             */

            var lstKeyVaulePair = new Dictionary<int, int>();

            var size = arrNum.Length;
            var nonRepeatingNum = Int32.MaxValue;

            for (var index = 0; index < size; index++)
            {
                if (lstKeyVaulePair.ContainsKey(arrNum[index]))
                {
                    var cnt = 0;
                    lstKeyVaulePair.TryGetValue(arrNum[index], out cnt);

                    cnt = cnt + 1;
                    lstKeyVaulePair[arrNum[index]] = cnt;
                }
                else
                {
                    lstKeyVaulePair.Add(arrNum[index], 1);
                }
            }

            foreach (var item in lstKeyVaulePair)
            {
                if (item.Value == 1)
                {
                    nonRepeatingNum = item.Key;
                }
            }

            if (nonRepeatingNum != Int32.MaxValue)
            {
                Console.WriteLine(nonRepeatingNum);
            }
            else
            {
                Console.WriteLine("No Unique number found");
            }
        }

        internal static void Approach2(int[] arrNum)
        {
            /*
            * Time complexity = O(N)
            * Space complexity = O(1)
            * This solution only works when duplicate elements are in even number
            */
            var uniqueNum = 0;
            var size = arrNum.Length;

            for (var i = 0; i < size; i++)
            {
                uniqueNum = uniqueNum ^ arrNum[i];
            }

            if(uniqueNum != 0)
            {
                Console.WriteLine(uniqueNum);
            }
            else
            {
                Console.WriteLine("No Unique number found");
            }
        }
    }
}
