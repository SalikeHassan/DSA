namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal static class RotateMatrix
    {
        internal static void PrintNightyDegreeRotateMatrix(int[,] matArr)
        {
            var rows = matArr.GetLength(0);
            var columns = matArr.GetLength(1);

            var x = 0;
            var y = 0;

            int[,] matTranspose = new int[rows, columns];

            for (var row = 0; row < rows; row++)
            {
                for (var colm = 0; colm < columns; colm++)
                {
                    matTranspose[x, y] = matArr[row, colm];
                    x++;
                }
                x = 0;
                y++;
            }

            x = 0;
            var transColms = matTranspose.GetLength(1);
            var transRows = matTranspose.GetLength(0);
            y = transColms - 1;

            for (var row = 0; row < transRows; row++)
            {
                while (x < y)
                {
                    var temp = matTranspose[row, y];
                    matTranspose[row, y] = matTranspose[row, x];
                    matTranspose[row, x] = temp;

                    x++;
                    y--;
                }
                x = 0;
                y = transColms - 1;
            }

            //Console.Write("[");
            //Console.WriteLine();
            for (int row = 0; row < transRows; row++)
            {
                string colmRes = "";
                for (int colm = 0; colm < transColms; colm++)
                {
                    if (colmRes == "")
                    {
                        colmRes = "[" + matTranspose[row, colm];
                    }
                    else
                    {
                        colmRes = colmRes + ", " + matTranspose[row, colm];
                    }

                    //Console.Write($"{matTranspose[row, colm]} ");

                }
                colmRes = colmRes + "] ";
                Console.Write(colmRes);
                //Console.WriteLine();
            }
            //Console.Write("]");
        }
    }
}
