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

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Quarto #{i + 1}: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                rent[quarto] = new Aluguel(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            Console.WriteLine();
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