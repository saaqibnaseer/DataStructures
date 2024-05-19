using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SearchingAlgorithms
{
    public static class ArrayADT
    {
        //Given the array nums consisting of 2n elements in the form[x1, x2, ..., xn, y1, y2, ..., yn].
        //Return the array in the form[x1, y1, x2, y2, ..., xn, yn]
        public static int[] Shuffle(int[] nums, int no)
        {
            int n = nums.Length;
            int[] answer = new int[no * 2];

            int j = no;
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                answer[i] = (i % 2 == 1) ? nums[j++] : nums[k++];
            }

            return answer;
        }

        //Given an array of integers nums, return the number of good pairs.
        //A pair(i, j) is called good if nums[i] == nums[j] and i<j.
        public static int NumIdenticalPairs(int[] nums)
        {
            int goodPairCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = i + 1; j < nums.Length; j++)
                {

                    if (nums[i] == nums[j])
                    {
                        goodPairCount++;
                    }

                }

            }

            return goodPairCount;
        }

        static void Main(string[] args)
        {
            var answer = ArrayADT.Shuffle([2, 5, 1, 3, 4, 7], 3);
            answer.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            Console.ReadKey();
        }
    }
}
