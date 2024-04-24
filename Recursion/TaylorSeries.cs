using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class TaylorSeries
    {
        public static double power = 1;
        public static double factorial = 1;

        public static double RecursiveCall(int number, int pow)
        {
            double result = 0;
            if (pow == 0) return 1;

            result = RecursiveCall(number, pow - 1);
            power = power * number;
            factorial = factorial * pow;

            return result + power / factorial;
        }

    }
}
