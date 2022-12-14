using System;
using System.Globalization;

namespace Ex_Proposto_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre com a Largura e altura do retângulo: ");
            Console.Write("Largura: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            ret.Area();
            ret.Perimetro();
            ret.Diagonal();
            Console.Write(ret);
        }
    }
}