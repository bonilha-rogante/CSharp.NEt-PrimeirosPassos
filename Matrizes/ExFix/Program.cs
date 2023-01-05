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

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (mat[i, j] == numero)
                    {
                        Console.WriteLine("Posição: " + i + ", " + j + ": ");
                    }
                    if (j > 0)
                    {
                        Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                    }
                    if (i > 0)
                    {
                        Console.WriteLine("Cima: " + mat[i - 1, j]);
                    }
                    if (j < c - 1)
                    {
                        Console.WriteLine("Direita: " + mat[i, j + 1]);
                    }
                    if (i < l - 1)
                    {
                        Console.WriteLine("Embaixo: " + mat[i + 1, j]);
                    }
                }
            }

        }
    }
}