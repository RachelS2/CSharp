using System;
using System.Globalization;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número de casos: ");
            int rep = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rep; i++)
            {
                Console.WriteLine("Escreva 3 valores: ");

                string[] vetor = Console.ReadLine().Split(' ');
                double a, b, c, media;

                a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

                media = ((a * 2) + (b * 3) + (c * 5)) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}