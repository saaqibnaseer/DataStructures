using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercies
{
    public class StudentExercise
    {
        // Find the missing elements from a sorted integer array
        public static void FindMissingElementOfArray()
        {
            int diff = 1;
            int[] array = { 1, 2, 5, 6, 7, 9, 10, 11, 12, 13, 14 };     // Given Array

            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] - index != diff)
                {
                    while (diff < array[index] - index)
                    {
                        Console.WriteLine(index + diff++);
                    }
                }
            }
        }
    }
}
