using System;
using System.Globalization;

namespace ExAluguel2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluguel rent = new Aluguel[10];
            Console.Write("Quantos Quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Quarto #{i}");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                rent[quarto] = new Aluguel(name, email);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (rent[i] != null)
                {
                    Console.WriteLine(i + ": " + rent[i]);
                }
            }
        }
    }
}