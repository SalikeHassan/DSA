using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal static class DiagonalMatrixPrint
    {
        internal static void PrintLRDiagonalMatrix(int[,] matArr)
        {
            var totalRow = 4;
            var totalColm = 4;
            var colm = 0;
            var row = 0;

            while (colm < totalColm && row < totalRow)
            {
                Console.WriteLine(matArr[row, colm]);
                row = row + 1;
                colm = colm + 1;
            }
        }

        internal static void PrintRLDiagonalMatrix(int[,] matArr)
        {
            var totalRow = 4;
            var totalColm = 4;
            var colm = totalColm - 1;
            var row = 0;

            while (row < totalRow && colm > -1)
            {
                Console.WriteLine(matArr[row, colm]);
                row = row + 1;
                colm = colm - 1;
            }
        }
    }
}
