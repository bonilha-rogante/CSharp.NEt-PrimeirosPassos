using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModificarRefOut
{
    public class Calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void Triplo(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}