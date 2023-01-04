using System;

namespace ExRefazendo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {

                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Diagonal Principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mat[i, i] + ' ');
            }

            Console.WriteLine();
            int contador = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        contador++;
                    }
                }
            }
            Console.Write(contador);
        }
    }
}