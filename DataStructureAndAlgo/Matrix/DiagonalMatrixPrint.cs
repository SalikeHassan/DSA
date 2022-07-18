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

        internal static void PrintMinorDiagonalSum(int[,] matArr)
        {
            int rows = matArr.GetLength(0);
            int colms = matArr.GetLength(1);

            int right = colms - 1;
            int top = 0;
            int sum = 0;

            while (right >= 0 && top >= 0)
            {
                sum = sum + matArr[top, right];
                top++;
                right--;
            }

            Console.WriteLine(sum);
        }
    }
}
