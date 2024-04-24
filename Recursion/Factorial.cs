using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Factorial
    {
        // Function to find factorial by recursive approach
        public static int findFactorialRecursive(int n)
        {
            if (n == 1) return 1;
            return n * findFactorialRecursive(n - 1);
        }

        // Function to find factorial by iterative approach
        public static int findFactorialIterative(int n)
        {
            int result = 1;

            for (int i = n; i >= 1; i--)
            {
                result = result * n;
                n--;
            }

            return result;
        }

    }
}
