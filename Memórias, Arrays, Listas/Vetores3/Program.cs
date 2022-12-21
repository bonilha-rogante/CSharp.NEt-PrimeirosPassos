using System;
using System.Globalization;

namespace Vetores3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Product { Nome = nome, Valor = valor };
            }


            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Valor;
            }

            double avg = soma / n;
            Console.WriteLine("AVERAGE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}