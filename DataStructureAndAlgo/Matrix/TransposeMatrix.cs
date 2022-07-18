using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal static class TransposeMatrix
    {
        internal static void PrintTransposeMatrix(int[,] matArr)
        {
            var totalRow = matArr.GetLength(0);
            var totalColm = matArr.GetLength(1);
            var x = 0;
            var y = 0;

            int[,] matTranspose = new int[totalColm, totalRow];

            for (var row = 0; row < totalRow; row++)
            {
                for (var colm = 0; colm < totalColm; colm++)
                {
                    matTranspose[x, y] = matArr[row, colm];
                    x++;
                }
                x = 0;
                y++;
            }

            x = totalColm;
            y = totalRow;

            for (var row = 0; row < x; row++)
            {
                for (var colm = 0; colm < y; colm++)
                {
                    Console.Write($"{matTranspose[row, colm]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
