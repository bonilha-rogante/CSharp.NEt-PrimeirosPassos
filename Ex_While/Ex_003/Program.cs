using System;
using System.Globalization;

namespace Ex_003
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int g = 0;
            int d = 0;

            Console.WriteLine("Bem vindo ao Posto de abastecimento");
            Console.WriteLine("Digite o número referente ao seu combustível:");
            Console.WriteLine("1-Álcool\n2-Gasolina\n3-Diesel\n4-Sair");

            int m = int.Parse(Console.ReadLine());

            while (m != 4)
            {
                if (m == 1)
                {
                    a += 1;
                }
                else if (m == 2)
                {
                    g += 1;
                }
                else if (m == 3)
                {
                    d += 1;
                }
                else
                {
                    Console.WriteLine("Digite um número válido:");
                }
                Console.WriteLine("1-Álcool\n2-Gasolina\n3-Diesel\n4-Sair");
                m = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Obrigado!");
            Console.WriteLine($"Álcool: {a} Gasolina: {g} Diesel: {d}");
        }
    }
}