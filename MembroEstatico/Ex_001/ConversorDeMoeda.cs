using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_001
{
    public class ConversorDeMoeda
    {
        public static double iof = 6.0;

        public static double Conversor(double dolar, double qtd)
        {
            double total = dolar * qtd;

            return total + total * iof / 100.0;
        }
    }
}