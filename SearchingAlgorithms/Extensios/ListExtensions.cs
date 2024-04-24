using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms.Extensios
{
    public static class ListExtensions
    {

        public static int? FindIndexInSorted<T>(this List<T> list, T itemToFind) where T : IComparable<T>
        {
            int leftBound = 0;
            int rightBound = list.Count() - 1;

            while (leftBound <= rightBound)
            {

                int middleIndex = (leftBound + rightBound) / 2;
                if (itemToFind.Equals(list[middleIndex]))
                {
                    return middleIndex;
                }
                if (itemToFind.CompareTo(list[middleIndex]) < 0)        // If negative, then it means number is at left side.
                {
                    rightBound = middleIndex - 1;
                }
                else
                {
                    leftBound = middleIndex + 1;
                }

            }

            return null;
        }
    }
}
