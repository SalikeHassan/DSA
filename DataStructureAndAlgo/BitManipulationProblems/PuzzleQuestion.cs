using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitManipulationProblems
{
    internal class PuzzleQuestion
    {
        internal static void Solution(int[] nums)
        {
            var ans = 0;
            var size = nums.Length;
          
            for (var index = 0; index < size; index++)
            {
                ans = ans ^ nums[index];
            }

            Console.WriteLine(ans);
        }
    }
}
