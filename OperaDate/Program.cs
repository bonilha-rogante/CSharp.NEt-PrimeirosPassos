using System;

namespace OperaDate
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 13, 42, 31);
            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);

            DateTime d4 = DateTime.Now;
            DateTime vencimento = d4.AddDays(7);

            DateTime d5 = new DateTime(2000, 10, 15);
            DateTime d6 = new DateTime(2000, 10, 18);

            TimeSpan t = d6.Subtract(d5);


            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(vencimento);
            Console.WriteLine(t);
        }
    }
}