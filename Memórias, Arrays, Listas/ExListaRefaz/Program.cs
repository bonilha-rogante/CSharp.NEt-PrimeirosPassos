using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExListaRefaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Funcionário: #{i + 1}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Informe o Id do funcionário que terá o salário aumentado: ");
            int idFunc = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == idFunc);
            if (emp != null)
            {
                Console.Write("Qual a porcentagem do aumento? ");
                double aumento = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(aumento);
            }
            else
            {
                Console.WriteLine("ID não cadastrado");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionários atualizada: ");
            foreach (Employee empregado in list)
            {
                Console.WriteLine(empregado);
            }
        }
    }
}