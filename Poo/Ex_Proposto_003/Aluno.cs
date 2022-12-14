using System;
using System.Globalization;

namespace Ex_Proposto_003
{
    public class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double Media()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (Media() < 60)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double QtdFalta()
        {
            if (Aprovado() == true)
            {
                return 0.0;
            }
            else
            {
                return 60 - Media();
            }
        }
    }
}