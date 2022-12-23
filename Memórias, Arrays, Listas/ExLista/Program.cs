using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos empregados serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Funcionário #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Informe o ID do funcionário que terá o Salário aumentado: ");
            int idFunc = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == idFunc);
            if (emp != null)
            {
                Console.Write("Coloque a Porcentagem: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("Esse ID não está cadastrado");
            }
            Console.WriteLine();
            Console.WriteLine("Lista de empregados atualizada: ");
            foreach (Employee empregados in list)
            {
                Console.WriteLine(empregados);
            }
        }
    }
}