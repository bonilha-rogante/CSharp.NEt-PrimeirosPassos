using System;
using System.Globalization;

namespace ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de funcionários: ");
            int funcionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite Quantas horas trabalahadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o salário por hora do funcionário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = horas * salario;

            Console.WriteLine($"NUMBER = {funcionario}");
            Console.WriteLine("SALARY R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}