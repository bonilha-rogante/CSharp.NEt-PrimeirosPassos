using System;
using System.Globalization;

namespace CondicionalWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (n >= 0.0)
            {
                double sqrt = Math.Sqrt(n);
                Console.WriteLine(sqrt.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.Write("Número Negativo");
        }
    }
}