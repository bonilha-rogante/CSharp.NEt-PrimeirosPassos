using System;
using System.Globalization;

namespace DateTimeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime d1 = DateTime.Now;
            // Console.WriteLine(d1);
            // Console.WriteLine(d1.Ticks);

            // DateTime d1 = new DateTime(2022, 01, 05);
            // DateTime d2 = DateTime.Now;
            // DateTime d3 = DateTime.Today;
            // DateTime d4 = DateTime.UtcNow;


            // Console.WriteLine(d1);
            // Console.WriteLine(d2);
            // Console.WriteLine(d3);
            // Console.WriteLine(d4);

            // DateTime d1 = DateTime.Parse("2000-02-05");
            // DateTime d2 = DateTime.Parse("2000-11-15 13:05:58");
            // DateTime d3 = DateTime.Parse("22/01/2000");
            // DateTime d4 = DateTime.Parse("22/01/2001 11:31:42");

            // Console.WriteLine(d1);
            // Console.WriteLine(d2);
            // Console.WriteLine(d3);
            // Console.WriteLine(d4);

            DateTime d1 = DateTime.ParseExact("2000-09-13", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);

            DateTime d2 = DateTime.ParseExact("03/01/2000 18:07:32", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d2);

        }
    }
}