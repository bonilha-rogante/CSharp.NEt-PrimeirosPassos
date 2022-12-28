using System;
using System.Globalization;
using System.Collections.Generic;

namespace Ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] rent = new Aluguel[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Quarto #{i}: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                rent[quarto] = new Aluguel(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados: ");
            for (int i = 1; i <= 10; i++)
            {
                if (rent[i] != null)
                {
                    Console.WriteLine(i + ": " + rent[i]);
                }
            }
        }
    }
}