using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionProblems
{
    internal class MagicNum
    {
        internal static int IsMagicNum(int num)
        {
            var sum = Int32.MinValue;
            if (sum > 2)
            {
                num = sum;
            }

            if (num == 0)
            {
                return 0;
            }
            else
            {
                sum = num % 10 + IsMagicNum(num / 10);
                return sum;
            }
        }
    }
}
