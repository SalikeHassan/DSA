using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal static class RowToColumZero
    {
        internal static void MakeRowToColumZero(int[,] A)
        {
            int rows = A.GetLength(0);
            int columns = A.GetLength(1);
            int rowIdx;
            int colIdx;
            int[,] result = new int[rows, columns];

            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < columns; col++)
                {
                    result[row, col] = Int32.MinValue;
                }
            }

            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < columns; col++)
                {
                    if (A[row, col] == 0)
                    {
                        rowIdx = 0;
                        colIdx = 0;
                        while (colIdx < columns)
                        {
                            result[row, colIdx] = 0;
                            colIdx++;
                        }

                        while (rowIdx < rows)
                        {
                            result[rowIdx, col] = 0;
                            rowIdx++;
                        }

                        break;
                    }
                    else
                    {
                        result[row, col] = result[row, col] == Int32.MinValue ? A[row, col] : 0;
                    }
                }
            }

            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < columns; col++)
                {
                    Console.Write($"{result[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
