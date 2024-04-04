/* Fazer um programa para ler um número inteiro N e os dados (nome e
preço) de N Produtos. Armazene os N produtos em um vetor. Em
seguida, mostrar o preço médio dos produtos. */

using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a quantidade de produtos: ");
            int N = int.Parse(Console.ReadLine());
            double[] Preco = new double[N];
            string[] Nome = new string[N];

            double soma = 0.0;

            for (int i = 0; i < N; i++)
            {
                Console.Write("\nEscreva o nome do {0}º produto: ", i+1);
                string nome = Console.ReadLine();


                Console.Write("Escreva o preço do {0}º produto: ", i+1);
                Preco[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                soma = soma + Preco[i];

            }

            double media = soma / N;

            Console.Write("\nA média é de preços do produto é R$ " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}




