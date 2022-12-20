using System;
using System.Globalization;

namespace Ex_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Tv", 500.00, 10);

            p.SetNome("Tv 4K");

            Console.WriteLine(p.GetNome());
        }
    }
}