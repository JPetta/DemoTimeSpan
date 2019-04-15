using System;

namespace DemoTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan();

            var timeSpan1 = new TimeSpan(1, 2, 3);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration : " + duration);

            //properties
            Console.WriteLine("Minutes : "+timeSpan.Minutes);
            Console.WriteLine("Minutes : "+timeSpan.TotalMinutes);

            //add
            Console.WriteLine("Add Example : "+timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Add Example : "+timeSpan.Subtract(TimeSpan.FromMinutes(8)));

            //ToString
            Console.WriteLine("ToString : " + timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse : "+ TimeSpan.Parse("01:02:03"));
            
        }
    }
}
