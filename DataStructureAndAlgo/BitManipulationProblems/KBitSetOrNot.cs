/*
Check whether K-th bit is set or not

Problem Statement
Given a number n, check if the Kth bit of n is set or not.
Examples: 
Input : n = 5, k = 1
Output : SET
5 is represented as 101 in binary and has its first bit set.

Input : n = 2, k = 3
Output : NOT SET
2 is represented as 10 in binary, all higher i.e. beyond MSB, bits are NOT SET.

https://www.geeksforgeeks.org/check-whether-k-th-bit-set-not/
 */

namespace BitManipulationProblems
{
    using System;

    internal static class KBitSetOrNot
    {
        internal static void Solution(int num, int k)
        {
            if (((num >> k - 1) & 1) > 0)
            {
                Console.WriteLine("Set bit");
            }
            else
            {
                Console.WriteLine("Unset bit");
            }
        }
    }
}
