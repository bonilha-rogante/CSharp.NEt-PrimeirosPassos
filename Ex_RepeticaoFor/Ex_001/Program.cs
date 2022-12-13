using System;

namespace Ex_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor entre 1 e 1000: ");
            int x = int.Parse(Console.ReadLine());
            int impar = 0;


            for (int i = 1; i <= x; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}