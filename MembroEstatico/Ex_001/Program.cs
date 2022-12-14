using System;
using System.Globalization;

namespace Ex_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.Conversor(dolar, qtd);

            Console.Write("Valor a ser paga em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}