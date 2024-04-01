/* Fazer um programa para ler um número inteiro N e uma matriz de
ordem N contendo números inteiros. Em seguida, mostrar a diagonal
principal e a quantidade de valores negativos da matriz. */

using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordem da matriz quadrada: ");
            int N = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N, N];
            for (int linha = 0; linha < N; linha++)
            {
                string[] values = Console.ReadLine().Split(' ');
                 
                for (int coluna = 0; coluna < N; coluna++)
                {
                    matriz[linha, coluna] = int.Parse(values[coluna]);
                }
            }

            Console.WriteLine("Diagonal Principal:");
            for (int linha = 0; linha < N; linha++)
            {

                Console.Write(matriz[linha, linha] + " ");     
                    
                
            }

            int neg = 0;

            for (int linha = 0; linha < N; linha++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int coluna = 0; coluna < N; coluna++)
                {
                    if (matriz[linha, coluna] < 0) neg += 1;
                }
            }

            Console.Write("\nNúmeros negativos: " + neg);
        }
    }
}
