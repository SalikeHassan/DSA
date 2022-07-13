/*
find the Sum of each row in a Matrix
https://www.tutorialgateway.org/c-program-to-find-sum-of-each-row-in-a-matrix/
 */

namespace Matrix
{
    using System;

    internal static class SumRow
    {
        internal static void PrintSumRow(int[,] matArr)
        {
            var totalColms = 4;
            var totalRows = 3;
            var sum = 0;

            for (var row = 0; row < totalRows; row++)
            {
                for (var colm = 0; colm < totalColms; colm++)
                {
                    sum = sum + matArr[row, colm];
                }

                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}
