using System;
using System.Globalization;

namespace Ex_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua Senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("SENHA INVÁLIDA!");
                Console.WriteLine("Digite novamente");

                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Bem-Vindo! Senha Correta");
        }
    }
}