using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Task119
    {
        public static void Run()
        {
            Time[] array = new Time[int.Parse(Console.ReadLine())];
            for (var i = 0; i < array.Length; i++)
                array[i] = new Time(Console.ReadLine());

            var length = array.Length - 1;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - i; j++)
                {
                    if (array[j] > array[j + 1])
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }

            foreach (var s in array)
                Console.WriteLine(s);
        }
    }
    public struct Time
    {
        public int hours;
        public int minutes;
        public int seconds;
        public Time(string a)
        {
            var b = a.Split();
            hours = int.Parse(b[0]);
            minutes = int.Parse(b[1]);
            seconds = int.Parse(b[2]);
        }
        public override string ToString()
            => hours + " " + minutes + " " + seconds;
        public static bool operator >(Time a, Time b)
        {
            if (a.hours != b.hours)
                return a.hours > b.hours;
            if (a.minutes != b.minutes)
                return a.minutes > b.minutes;
            return a.seconds > b.seconds;
        }
        public static bool operator <(Time a, Time b)
            => b > a;
    }
}
