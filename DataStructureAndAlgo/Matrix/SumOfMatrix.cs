using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal static class SumOfMatrix
    {
        internal static void PrintSumOfMatrix(int[,] a, int[,] b)
        {
            var rows = a.GetLength(0);
            var columns = a.GetLength(1);
            var rowIdx = 0;
            var colIdx = 0;
            int[,] sumMatrix = new int[rows, columns];

            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < columns; col++)
                {
                    sumMatrix[rowIdx, colIdx++] = a[row, col] + b[row, col];
                }
                colIdx = 0;
                rowIdx++;
            }

            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < columns; col++)
                {
                    Console.Write($"{sumMatrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
