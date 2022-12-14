using System;
using System.Globalization;

namespace Ex_Proposto_001
{
    public class Retangulo
    {

        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString()
        {
            return "AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture) +
             "\nPERÍMETRO: " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) +
             "\nDiagonal: " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}