using SearchingAlgorithms.Extensios;
using System.Collections.Generic;

namespace SearchingAlgorithms
{
    public class BinarySearch
    {
        // Implemented an extension method on List Class to calculate index of the given element
        // Time Complexity : O(log n)
        public static void BinarySearchAlgorithm()
        {
            // List should be sorted for binary search to be perfomed.
            var sortedList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            Console.WriteLine(sortedList.FindIndexInSorted(1));
            Console.WriteLine(sortedList.FindIndexInSorted(4));
            Console.WriteLine(sortedList.FindIndexInSorted(15));

            Console.ReadKey();

        }



    }
}
