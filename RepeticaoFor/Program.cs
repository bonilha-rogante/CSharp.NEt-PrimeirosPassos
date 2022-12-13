using System;
using System.Globalization;

namespace RepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Valor #{i}");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine($"A Soma dos números foi de: {soma} ");
        }
    }
}