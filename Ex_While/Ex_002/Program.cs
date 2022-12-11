using System;
using System.Globalization;

namespace Ex_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de X: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de Y: ");
            int y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }
                Console.WriteLine("Digite Novas Coordenadas: ");
                Console.WriteLine("Coordenada de X ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Coordenada de Y ");
                y = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Uma das coordenadas foi nula");
        }
    }
}

