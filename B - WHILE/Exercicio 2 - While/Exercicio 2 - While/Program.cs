using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            Console.WriteLine("Pontos X e Y: ");
            string[] vetor = Console.ReadLine().Split(' ');
            X = int.Parse(vetor[0]);
            Y = int.Parse(vetor[1]);
            while (X != 0 || Y != 0)
            {

                if (X > 0 && Y > 0) Console.WriteLine("primeiro");

                else if (X < 0 && Y > 0) Console.WriteLine("segundo");

                else if (X < 0 && Y < 0) Console.WriteLine("terceiro");

                else if (X > 0 && Y < 0) Console.WriteLine("quarto");

                Console.WriteLine("Pontos X e Y: ");
                string[] lista = Console.ReadLine().Split(' ');
                X = int.Parse(lista[0]);
                Y = int.Parse(lista[1]);
            }
        }
    }
}