using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a = 10;
            // Console.WriteLine(a);

            // a += 2;
            // Console.WriteLine(a);

            // a *= 3;
            // Console.WriteLine(a);

            // string s = "ABC";
            // Console.WriteLine(s);

            // s += "DEF";
            // Console.WriteLine(s);

            // int b = 10;
            // int c = b++;
            // int d = ++b;
            // // b++;
            // // b --;

            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // Console.WriteLine(d);

            // float x = 4.5f;
            // double y = x;

            // Console.WriteLine(y);

            // double a;
            // float b;

            // a = 5.1;
            // b = (float)a;

            // Console.WriteLine(b);


            // double a;
            // int b;

            // a = 5.1;
            // b = (int)a;

            // Console.WriteLine(b);

            // int a = 5;
            // int b = 2;

            // double resultado = (double)a / b;

            // Console.WriteLine(resultado);

            // int n1 = 3 + 4 * 2;
            // int n2 = (3 + 4) * 2;
            // int n3 = 17 % 3;
            // double n4 = 10.0 / 8;

            // double a = 1.0, b = -3.0, c = -4.0;
            // double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            // double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            // double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            // Console.WriteLine(n1);
            // Console.WriteLine(n2);
            // Console.WriteLine(n3);
            // Console.WriteLine(n4);

            // Console.WriteLine(delta);
            // Console.WriteLine(x1);
            // Console.WriteLine(x2);

            // int a = 10;
            // bool c1 = a < 10;
            // bool c2 = a < 20;
            // bool c3 = a > 10;
            // bool c4 = a > 5;

            // Console.WriteLine(c1);
            // Console.WriteLine(c2);
            // Console.WriteLine(c3);
            // Console.WriteLine(c4);

            // bool c5 = a <= 10;
            // bool c6 = a >= 10;
            // bool c7 = a == 10;
            // bool c8 = a != 10;

            // Console.WriteLine(c5);
            // Console.WriteLine(c6);
            // Console.WriteLine(c7);
            // Console.WriteLine(c8);


            bool c1 = 2 > 3 && 4 < 5;

            Console.WriteLine(c1);

            bool c2 = 2 > 3 || 4 < 5;

            Console.WriteLine(c2);

            bool c3 = !(2 > 3) && 4 != 5;

            Console.WriteLine(c3);
            bool c4 = 10 < 5;
            bool c5 = c2 || c3 && c4;
        }
    }
}


