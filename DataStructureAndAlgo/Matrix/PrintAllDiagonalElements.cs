using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal static class PrintAllDiagonalElements
    {
        internal static void PrintBasedOnZerothRow(int[,] matArr)
        {
            var totalColm = 5;
            var totalRow = 3;

            for (var j = 0; j < totalColm; j++)
            {
                var rowIdx = 0;
                var colmIdx = j;

                while (rowIdx < totalRow && colmIdx >= 0)
                {
                    Console.Write($"{matArr[rowIdx, colmIdx]},");
                    rowIdx++;
                    colmIdx--;
                }
                Console.WriteLine();
            }

            for (var i = 1; i < totalRow; i++)
            {
                var rowIdx = i;
                var colmIdx = totalColm - 1;

                while (rowIdx < totalRow && colmIdx >= 0)
                {
                    Console.Write($"{matArr[rowIdx, colmIdx]},");
                    rowIdx++;
                    colmIdx--;
                }
                Console.WriteLine();
            }
        }
    }
}
