using System;
using System.Globalization;

namespace Ex_003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantes testes você quer fazer? ");
            int teste = int.Parse(Console.ReadLine());

            for (int t = 0; t < teste; t++)
            {
                string[] notas = Console.ReadLine().Split(" ");
                double notaA = double.Parse(notas[0], CultureInfo.InvariantCulture);
                double notaB = double.Parse(notas[1], CultureInfo.InvariantCulture);
                double notaC = double.Parse(notas[2], CultureInfo.InvariantCulture);

                double media = (notaA * 2.0 + notaB * 3.0 + notaC * 5.0) / 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
