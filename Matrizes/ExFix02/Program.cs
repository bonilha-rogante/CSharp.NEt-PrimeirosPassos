using System;

namespace ExFix02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de linhas: ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de colunas: ");
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

            Console.WriteLine();
            Console.Write("Digite o número que quer analisar: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (mat[i, j] == numero)
                    {
                        Console.WriteLine("Posição: " + i + ", " + j);
                    }

                }
            }
        }
    }
}