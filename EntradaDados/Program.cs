using System;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.ReadLine(); -> Lê da entrada padrão  até a quebra de Linha. Retorna os dados lidos na forma de String;

            // string frase = Console.ReadLine();
            // string x = Console.ReadLine();
            // string y = Console.ReadLine();
            // string z = Console.ReadLine();

            // Console.WriteLine($"Você digitou: {frase}");
            // Console.WriteLine(x);
            // Console.WriteLine(y);
            // Console.WriteLine(z);

            // string s = Console.ReadLine();
            // string[] vet = s.Split(' ');
            // string p1 = vet[0];
            // string p2 = vet[1];
            // string p3 = vet[2];

            // Console.WriteLine(s);
            // Console.WriteLine(p1);
            // Console.WriteLine(p2);
            // Console.WriteLine(p3);

            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}