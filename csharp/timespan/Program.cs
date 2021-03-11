using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine("Duration : " + duration);

            // Properties

            // 2
            Console.WriteLine("Minutes : " + timeSpan.Minutes);
            // 62.5
            Console.WriteLine("Total Minutes : " + timeSpan.TotalMinutes);

            // Add

            // +8 Minutes
            Console.WriteLine("Add Example : " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            // -2 Minutes
            Console.WriteLine("Subtract Example : " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // Tostring
            Console.WriteLine("ToString : " + timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse : " + TimeSpan.Parse("01:02:03"));
        }
    }
}
