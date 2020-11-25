using System;
using System.IO;

namespace DataAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(60, 100, 200);
            Console.WriteLine(timeSpan.Days);
            Console.WriteLine(timeSpan.Hours);
            Console.WriteLine(timeSpan.TotalMilliseconds);

            var start = DateTimeOffset.UtcNow;
            var end = start.AddSeconds(45);

            TimeSpan difference = end - start;
            Console.WriteLine(difference.Seconds);

            difference = difference.Multiply(2);
        }
    }
}
