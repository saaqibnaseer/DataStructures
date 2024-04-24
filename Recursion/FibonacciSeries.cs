using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class FibonacciSeries
    {
        // Recursive
        public static int FindNthFibonacciTerm(int n)
        {
            if (n < 2) return n;

            return FindNthFibonacciTerm(n - 1) + FindNthFibonacciTerm(n - 2);
        }

    }
}
