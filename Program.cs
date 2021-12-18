using System;
using System.Threading;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] a = new int[100_000_000];
            for (int i = 0; i < 100_000_000; i++)
                a[i] = random.Next();

            var time1 = DateTime.Now;
            var ans = ArraySorts.MergeSort(a); //100_000_000 51 sec 3.4Gb
            Console.WriteLine((DateTime.Now - time1).TotalSeconds);
        }
    }
}
