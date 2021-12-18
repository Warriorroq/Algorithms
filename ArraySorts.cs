using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class ArraySorts
    {
        public static int[] BubbleSort(int[] array)
        {
            var length = array.Length - 1;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - i; j++)
                {
                    if (array[j] > array[j + 1])
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
            return array;
        }
        public static int[] MergeSort(int[] array)
            => MergeSortedArrays(
                DoMergeSort(array.Take(array.Length / 2).ToArray()), 
                DoMergeSort(array.Skip(array.Length / 2).ToArray())
            );
        private static int[] DoMergeSort(int[] array)
        {
            if (array.Length < 3)
                BubbleSort(array);
            else
            {
                var firstArray = DoMergeSort(array.Take(array.Length / 2).ToArray());
                var secondArray = DoMergeSort(array.Skip(array.Length / 2).ToArray());
                array = MergeSortedArrays(firstArray, secondArray);
            }
            return array;
        }
        private static int[] MergeSortedArrays(int[] a, int[] b)
        {
            int aCount = 0, bCount = 0;
            var answer = new int[a.Length + b.Length];
            for (int k = 0; k < answer.Length; k = aCount + bCount)
            {
                (int, int) nums;

                nums.Item1 = aCount < a.Length ? a[aCount] : int.MaxValue;
                nums.Item2 = bCount < b.Length ? b[bCount] : int.MaxValue;

                if (nums.Item1 < nums.Item2)
                {
                    answer[k] = nums.Item1;
                    aCount++;
                }
                else
                {
                    answer[k] = nums.Item2;
                    bCount++;
                }
            }
            return answer;
        }
    }
}
