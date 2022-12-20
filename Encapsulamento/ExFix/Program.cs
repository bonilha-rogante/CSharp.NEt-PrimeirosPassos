using System;
using System.Globalization;

namespace ExFix
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o número da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n) ? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, nome, valorInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, nome);
            }

            Console.WriteLine();
            Console.Write("Dados Bancários: ");
            Console.Write(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.Write(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.Write(conta);
            Console.WriteLine();


        }
    }
}