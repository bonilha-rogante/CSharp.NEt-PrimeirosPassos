using System;

namespace ModificarRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            int x = 10;
            int triplo;
            Calculator.Triplo(x, out triplo);
            Console.WriteLine(triplo);

        }
    }
}