using System;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {

            // int x = 10;

            // Console.WriteLine("Bom dia!");

            // if (x < 5)
            // {
            //     Console.WriteLine("Boa Tarde!");
            // }
            // else
            // {
            //     Console.WriteLine("Boa Noite!");
            // }

            // Console.WriteLine("Entre com um número inteiro: ");
            // int x = int.Parse(Console.ReadLine());

            // if (x % 2 == 0)
            // {
            //     Console.WriteLine($"Você digitou o número {x} e ele é PAR");
            // }
            // else
            // {
            //     Console.WriteLine($"Você digitou o número {x} e ele é ÍMPAR");
            // }

            Console.WriteLine("Digite o horário atual: ");
            double hora = double.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}