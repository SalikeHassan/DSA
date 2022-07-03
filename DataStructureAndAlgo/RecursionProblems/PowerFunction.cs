using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionProblems
{
    internal class PowerFunction
    {
        internal static int GetPow(int a, int b, int c)
        {
            //Base Condition
            if (b == 0)
            {
                return 1;
            }
            else
            {
                //Logic
                return (a * GetPow(a, b - 1, c) + c) % c;
            }
        }
    }
}
