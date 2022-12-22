using System;

namespace ModificadorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(5, 9, 1);

            Console.WriteLine(s1);
            Console.Write(s2);
        }
    }
}