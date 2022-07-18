using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal static class SpiralMatrix
    {
        internal static void PrintSprialMatrix(int A)
        {
            int[,] spiralMatrix = new int[A, A];
            if (A == 1)
            {
                Console.WriteLine("[[1]]");
            }
            else
            {
                int left = 0;
                int top = 0;
                int right = A - 1;
                int bottom = A - 1;
                int val = 1;
              

                while (val <= A * A)
                {
                    for (int idx = left; idx <= right; idx++)
                    {
                        spiralMatrix[top, idx] = val++;
                    }
                    top++;

                    for (int idx = top; idx <= bottom; idx++)
                    {
                        spiralMatrix[idx, right] = val++;
                    }
                    right--;

                    for (int idx = right; idx >= left; idx--)
                    {
                        spiralMatrix[bottom, idx] = val++;
                    }
                    bottom--;

                    for (int idx = bottom; idx >= top; idx--)
                    {
                        spiralMatrix[idx, left] = val++;
                    }
                    left++;
                }
            }
        }
    }
}
