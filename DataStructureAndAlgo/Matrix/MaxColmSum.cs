/*
Find column with maximum sum in a Matrix
Given a N*N matrix. The task is to find the index of column with maximum sum. That is the column whose sum of elements are maximum.
Examples: 
 

Input : mat[][] = {
        { 1, 2, 3, 4, 5 },
        { 5, 3, 1, 4, 2 },
        { 5, 6, 7, 8, 9 },
        { 0, 6, 3, 4, 12 },
        { 9, 7, 12, 4, 3 },
    };
Output : Column 5 has max sum 31

Input : mat[][] = {
        { 1, 2, 3 },
        { 4, 2, 1 },
        { 5, 6, 7 },
    };
Output : Column 3 has max sum 11
https://www.geeksforgeeks.org/find-column-with-maximum-sum-in-a-matrix/
 */

namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal static class MaxColmSum
    {
        internal static void PrintMaxColmSumAndIndex(int[,] matArr)
        {
            var totalRows = 3;
            var totalColms = 4;
            var sum = 0;
            var maxSum = 0;
            var colmIdx = -1;

            for (var colm = 0; colm < totalColms; colm++)
            {
                for (var row = 0; row < totalRows; row++)
                {
                    sum = sum + matArr[row, colm];
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    colmIdx = colm;
                }

                sum = 0;
            }

            Console.WriteLine($"Column {colmIdx} has max sum {maxSum}");
        }
    }
}
