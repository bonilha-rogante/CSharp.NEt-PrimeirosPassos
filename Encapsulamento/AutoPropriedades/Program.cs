using System;
using System.Globalization;

namespace AutoPropriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Tv", 500.00, 10);

            p.Nome = "Tv 4k";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}