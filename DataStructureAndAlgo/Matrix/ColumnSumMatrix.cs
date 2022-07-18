using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal static class ColumnSumMatrix
    {
        internal static int[] GetColumnSum(int[,] A)
        {
            var totalRows = A.GetLength(0);
            var totalColms = A.GetLength(1);
            int[] columnSum = new int[totalColms];
            var sum = 0;
            var idx = 0;

            for (var colm = 0; colm < totalColms; colm++)
            {
                for (var row = 0; row < totalRows; row++)
                {
                    sum = sum + A[row, colm];
                }

                columnSum[idx] = sum;
                sum = 0;
                idx++;
            }

            return columnSum;
        }
    }
}
