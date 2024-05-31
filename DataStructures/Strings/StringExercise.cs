using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings
{
    public static class StringExercise
    {
        // Convert any string into number without using builtin function
        public static void ConvertStringToNumber(string str)
        {
            int num = 0;

            for (int i = 0; i < str.Length; i++)
            {
                num = num * 10 + ((int)str[i] - '0');
            }

            Console.WriteLine(num);

            //Console.WriteLine((int)'0');
            //Console.WriteLine((int)'2');

        }

    }
}
