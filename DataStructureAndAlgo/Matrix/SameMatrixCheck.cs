/*
Program to check if two given matrices are identical
The below program checks if two square matrices of size 4*4 are identical or not. For any two matrices to be equal, a number of rows and columns 
in both the matrix should be equal and the corresponding elements should also be equal. 

https://www.geeksforgeeks.org/program-to-check-if-two-given-matrices-are-identical/
 */

namespace Matrix
{
    using System;
    internal static class SameMatrixCheck
    {
        internal static void IsMatrixSame(int[,] mat1, int[,] mat2)
        {
            int rows = mat1.GetLength(0);
            int columns = mat1.GetLength(1);

            bool isMatrixSame = true;

            for (var row = 0; row < rows; row++)
            {
                for (var colm = 0; colm < columns; colm++)
                {
                    if (mat1[row, colm] != mat2[row, colm])
                    {
                        isMatrixSame = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isMatrixSame);
        }
    }
}
