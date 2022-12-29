using System;
using System.Globalization;
using System.Collections.Generic;

namespace Ex007
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empregado> empregado = new List<Empregado>();

            Console.Write("Quantos empregados serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Empregado #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                empregado.Add(new Empregado(id, nome, salario));
            }

            Console.Write("Entre com o Id do funcionário que terá o salário aumentado: ");
            int idFunc = int.Parse(Console.ReadLine());
            Empregado emp = empregado.Find(x => x.Id == idFunc);

            if (emp != null)
            {
                Console.Write("Coloque a porcentagem do aumento: ");
                double porcentagem = double.Parse(Console.ReadLine());
                emp.aumentoSalario(porcentagem);
            }
            else
            {
                Console.Write("Esse Id não está cadastrado.");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de empregados atualizada: ");
            foreach (Empregado empregados in empregado)
            {
                Console.WriteLine(empregados);
            }
        }
    }
}