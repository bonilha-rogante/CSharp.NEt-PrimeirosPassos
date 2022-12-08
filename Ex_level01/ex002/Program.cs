using System;
using System.Globalization;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            Console.WriteLine("Digite o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = (pi * Math.Pow(raio, 2));
            Console.WriteLine("A área do círculo é de " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}