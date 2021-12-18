using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1, 2, 3 };
            int[] b = {1, 4, 5, 7};
            Console.WriteLine(string.Join(',', MergeSortedArrays(a, b)));
        }
        static int[] MergeSortedArrays(int[] a, int[] b)
        {
            int aCount = 0, bCount = 0;
            int[] answer = new int[a.Length + b.Length];
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
