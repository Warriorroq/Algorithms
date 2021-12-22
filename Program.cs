using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Linq;
namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] a = new int[100];
            for (int i = 0; i < 100; i++)
                a[i] = random.Next() % 100_000;

            var time1 = DateTime.Now;
            ArraySorts.HeapSort(a);
            Console.WriteLine(string.Join('\n', a.TakeLast(15)));
            Console.WriteLine((DateTime.Now - time1).TotalSeconds);
        }
    }
}

