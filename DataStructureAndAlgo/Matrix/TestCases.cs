namespace Matrix
{
    internal class TestCases
    {
        static void Main(string[] args)
        {
            //int[,] matArr = new int[3, 4];
            //matArr[0, 0] = 3;
            //matArr[0, 1] = 8;
            //matArr[0, 2] = 9;
            //matArr[0, 3] = 2;

            //matArr[1, 0] = 1;
            //matArr[1, 1] = 2;
            //matArr[1, 2] = 3;
            //matArr[1, 3] = 6;

            //matArr[2, 0] = 4;
            //matArr[2, 1] = 10;
            //matArr[2, 2] = 11;
            //matArr[2, 3] = 18;

            //int[,] sqMatrix = new int[4, 4];
            //sqMatrix[0, 0] = 3;
            //sqMatrix[0, 1] = 8;
            //sqMatrix[0, 2] = 9;
            //sqMatrix[0, 3] = 2;

            //sqMatrix[1, 0] = 1;
            //sqMatrix[1, 1] = 2;
            //sqMatrix[1, 2] = 3;
            //sqMatrix[1, 3] = 6;

            //sqMatrix[2, 0] = 4;
            //sqMatrix[2, 1] = 10;
            //sqMatrix[2, 2] = 11;
            //sqMatrix[2, 3] = 18;

            //sqMatrix[3, 0] = 100;
            //sqMatrix[3, 1] = 200;
            //sqMatrix[3, 2] = 300;
            //sqMatrix[3, 3] = 400;

            //SumRow.PrintSumRow(matArr);

            //MaxColmSum.PrintMaxColmSumAndIndex(matArr);

            //DiagonalMatrixPrint.PrintLRDiagonalMatrix(sqMatrix);
            //DiagonalMatrixPrint.PrintRLDiagonalMatrix(sqMatrix);

            //int[,] matrix =
            //    {
            //        { 1,2,3,4,5},
            //        { 6,7,8,9,10},
            //        { 11,12,13,14,15},
            //    };

            //PrintAllDiagonalElements.PrintBasedOnZerothRow(matrix);

            //int[,] arr = {
            //    {
            //        1,2,3,4
            //    },
            //    {
            //       5,6,7,8
            //    },
            //    {
            //        9,10,11,12
            //    },
            //    {
            //        13,14,15,16
            //    }
            //};
            //int[,] arr = {
            //    {
            //        1,2
            //    },
            //    {
            //      3,4
            //    }
            //};


            //// TransposeMatrix.PrintTransposeMatrix(arr);
            //RotateMatrix.PrintNightyDegreeRotateMatrix(arr);

            //int[,] matArr =
            //{
            //    {1,2,3,4 },
            //    {5,6,7,8 },
            //    {9,2,3,4 }
            //};
            //var sumColumn = ColumnSumMatrix.GetColumnSum(matArr);

            // int[,] a =
            // {
            //     { 1, 2, 3},
            //     {4, 5, 6 },
            //     { 7, 8, 9}
            // };

            // int[,] b =
            //{
            //     { 10, 8, 7},
            //     {6, 5, 4 },
            //     {3, 2, 1}
            // };

            // SumOfMatrix.PrintSumOfMatrix(a, b);

            //SpiralMatrix.PrintSprialMatrix(4);

            //int[,] mat1 =
            //{
            //    {1, 2, 3 },
            //    {4, 5, 6 },
            //    { 7, 8, 9}
            //};
            //int[,] mat2 =
            //{
            //    {1, 2, 3 },
            //    {4, 5, 6 },
            //    { 7, 81, 9}
            //};

            //SameMatrixCheck.IsMatrixSame(mat1, mat2);

            int[,] matArr =
            {
                { 1, -2, -3},
                {-4, 5, -6 },
                {-7, -8, 9 }
            };

            DiagonalMatrixPrint.PrintMinorDiagonalSum(matArr);

            Console.ReadKey();
        }
    }
}