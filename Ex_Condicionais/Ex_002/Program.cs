using System;

namespace Ex_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");

            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine($"O número {n} é PAR");
            }
            else
            {
                Console.WriteLine($"O número {n} é ÍMPAR");
            }
        }
    }
}