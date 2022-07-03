namespace RecursionProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class SumOfDigits
    {
        internal static int GetSum(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else
            {
                return num % 10 + GetSum(num / 10);
            }
        }
    }
}
