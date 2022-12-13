using System;

namespace Ex_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a = new Pessoa();
            Pessoa b = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            a.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Idad: ");
            b.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Nome: {a.Nome}\nIdade: {a.Idade}");
            Console.WriteLine($"Nome: {b.Nome}\nIdade: {b.Idade}");

            if (a.Idade > b.Idade)
            {
                Console.WriteLine($"A pessoa mais velha é: {a.Nome}");
            }
            else
            {
                Console.WriteLine($"A pessoa mais velha é: {b.Nome}");
            }

        }
    }
}