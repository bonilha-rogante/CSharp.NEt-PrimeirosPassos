using System;

namespace ExFix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de Linhas da matriz: ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de colunas da matriz: ");
            int c = int.Parse(Console.ReadLine());

            int[,] mat = new int[l, c];

            for (int i = 0; i < l; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.Write("Digite o número que deseja analisar: ");
            int numero = int.Parse(Console.ReadLine());
        }


    }
}