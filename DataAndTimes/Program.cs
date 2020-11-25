using System;
using System.Globalization;
using System.IO;

namespace DataAndTimes
{
    class Program
    {
        static Calendar calendar = CultureInfo.InvariantCulture.Calendar;
        static void Main(string[] args)
        {
            var contractDate = new DateTimeOffset(2019, 7, 1, 0, 0, 0, TimeSpan.Zero);
            Console.WriteLine(contractDate);
            contractDate = contractDate.AddMonths(6).AddTicks(-1);
            Console.WriteLine(contractDate);


            var start = new DateTimeOffset(2007, 12, 31, 0, 0, 0, TimeSpan.Zero);
            var week = calendar.GetWeekOfYear(start.DateTime,
                CalendarWeekRule.FirstFourDayWeek,
                DayOfWeek.Monday);
            Console.WriteLine(week);



            var timeSpan = new TimeSpan(60, 100, 200);
            Console.WriteLine(timeSpan.Days);
            Console.WriteLine(timeSpan.Hours);
            Console.WriteLine(timeSpan.TotalMilliseconds);

            var start1 = DateTimeOffset.UtcNow;
            var end = start.AddSeconds(45);

            TimeSpan difference = end - start1;
            Console.WriteLine(difference.Seconds);

            difference = difference.Multiply(2);
        }
    }
}
