using System;

namespace Ex_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos valores você quer digitar? ");
            int n = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Digite o {i}º valor: ");
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && n <= 20)
                {
                    dentro += 1;
                }
                else
                {
                    fora += 1;
                }
            }
            Console.WriteLine($"In: {dentro}\nOut: {fora}");
        }
    }
}