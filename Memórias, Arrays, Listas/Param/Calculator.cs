using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Param
{
    public class Calculator
    {
        public static int Soma(params int[] number)
        {
            int soma = 0;
            for (int i = 0; i < number.Length; i++)
            {
                soma += number[i];
            }
            return soma;
        }
    }
}