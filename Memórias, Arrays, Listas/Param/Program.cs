using System;

namespace Param
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Soma(5, 3, 8);
            int s2 = Calculator.Soma(8, 5, 4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}