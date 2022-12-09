using System;

namespace Ex_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");

            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine($"Você digitou o número {n} e ele é POSITIVO");
            }
            else if (n < 0)
            {
                Console.WriteLine($"Você digitou o número {n} e ele é NEGATIVO");
            }
            else
            {
                Console.WriteLine($"Você digitou {n}");
            }

        }
    }
}