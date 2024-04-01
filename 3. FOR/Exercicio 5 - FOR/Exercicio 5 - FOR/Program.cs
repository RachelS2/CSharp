using System;
//Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
//Lembrando que, por definição, fatorial de 0 é 1.

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor: ");
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                int fat = 1;
                for (int i = 1; i <= n; i++)
                {
                    fat = fat * i;
                }
                Console.WriteLine(fat);
            }
        }
    }
}
