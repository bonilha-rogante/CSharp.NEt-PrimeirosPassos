using System;
using System.Globalization;

namespace ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            Console.WriteLine("Digite os 3 valores em sequência: ");
            string[] vet = Console.ReadLine().Split(" ");
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double tri = a * c / 2.0;
            double cir = pi * Math.Pow(c, 2.0);
            double tra = (a + b) * c / 2.0;
            double qua = Math.Pow(b, 2.0);
            double ret = (a * b);

            Console.WriteLine("TRIÂNGULO: " + tri.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + cir.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " + tra.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + qua.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + ret.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}

