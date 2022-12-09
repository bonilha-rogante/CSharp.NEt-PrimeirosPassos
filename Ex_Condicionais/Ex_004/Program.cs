using System;

namespace Ex_004
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(" ");

            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int horario = 0;

            if (horaInicial < horaFinal)
            {
                horario = horaFinal - horaInicial;
            }
            else
            {
                horario = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine($"O jogo durou {horario} horas");
        }
    }
}