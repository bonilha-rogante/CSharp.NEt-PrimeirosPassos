using System;
using System.Globalization;

namespace ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número da Primeira Peça, a quantidade de peças e o valor(na mesma linha)");
            string[] vet1 = Console.ReadLine().Split(" ");

            int cod1 = int.Parse(vet1[0]);
            int qtd1 = int.Parse(vet1[1]);
            double valor1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);
            double total1 = qtd1 * valor1;

            Console.WriteLine("Digite o número da Segunda Peça, a quantidade de peças e o valor(na mesma linha");
            string[] vet2 = Console.ReadLine().Split(" ");

            int cod2 = int.Parse(vet2[0]);
            int qtd2 = int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);
            double total2 = qtd2 * valor2;

            double total = total1 + total2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}