using System;
using System.Globalization;

namespace VetorEx02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Preco;
            }

            double avg = soma / n;

            Console.WriteLine("Média: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}