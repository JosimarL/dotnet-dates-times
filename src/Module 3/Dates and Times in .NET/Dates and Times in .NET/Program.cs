using System;

namespace Dates_and_Times_in.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = DateTimeOffset.UtcNow;
            var end = start.AddSeconds(45);

            TimeSpan difference = start - end;
            
            Console.WriteLine(difference.TotalSeconds);

            var timeSpan = new TimeSpan(1, 61, 0)

            Console.WriteLine(timeSpan.Hours);
        }
    }
}
