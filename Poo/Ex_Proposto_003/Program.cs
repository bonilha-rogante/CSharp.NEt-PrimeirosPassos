using System;
using System.Globalization;

namespace Ex_Proposto_003
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.Write("NOTA FINAL = " + aluno.Media().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado())
            {
                Console.WriteLine("\nAPROVADO");
            }
            else
            {
                Console.WriteLine("\nREPROVADO");
                Console.WriteLine("FALTARAM: " + aluno.QtdFalta().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }


        }
    }
}
