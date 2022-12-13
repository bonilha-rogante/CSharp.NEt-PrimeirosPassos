using System;

namespace Ex_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos pares de números você vai digitar? ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Digite o {i}º par: ");
                string[] par = Console.ReadLine().Split(" ");
                double n1 = double.Parse(par[0]);
                double n2 = double.Parse(par[1]);
                double divisao = 0.0;

                if (n2 == 0)
                {
                    Console.WriteLine("Divisão Impossível");
                }
                else
                {
                    divisao = n1 / n2;
                }
                Console.WriteLine($"{divisao}");
            }
        }
    }
}