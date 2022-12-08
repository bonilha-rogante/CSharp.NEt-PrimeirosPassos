using System;
using System.Globalization;

namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os 4 valores em sequência na mesma linha: ");
            string[] vet = Console.ReadLine().Split(" ");
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);
            int d = int.Parse(vet[3]);
            int diferenca = ((a * b) - (c * d));
            Console.WriteLine($"Diferença: {diferenca}");
        }
    }
}