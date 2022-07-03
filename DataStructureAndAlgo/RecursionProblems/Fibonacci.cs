/*
 Program for Fibonacci numbers
The Fibonacci numbers are the numbers in the following integer sequence.
0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ……..
In mathematical terms, the sequence Fn of Fibonacci numbers is defined by the recurrence relation 
Fn = Fn-1 + Fn-2
with seed values 
F0 = 0 and F1 = 1.

https://www.geeksforgeeks.org/program-for-nth-fibonacci-number/
 */

namespace RecursionProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Fibonacci
    {
        internal static int GetAthFibonacci(int num)
        {
            if (num == 0)
            {
                return 0;
            }

            if (num == 1)
            {
                return 1;
            }

            else
            {
                return GetAthFibonacci(num - 1) + GetAthFibonacci(num - 2);
            }
        }
    }
}
