///Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
///código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1, numero1; double valor1;
            int codigo2, numero2; double valor2;

            Console.WriteLine("Escreva o código da peça 1, o número de peças 1 e o valor unitário de cada peça 1. ");
            string[] vetor = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(vetor[0]);
            numero1 = int.Parse(vetor[1]);
            valor1 = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            double total1 = numero1 * valor1;

            Console.WriteLine("Escreva o código da peça 2, o número de peças 2 e o valor unitário de cada peça 2. ");
            string[] lista = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(lista[0]);
            numero2 = int.Parse(lista[1]);
            valor2 = double.Parse(lista[2], CultureInfo.InvariantCulture);

            double total2 = numero2 * valor2;

            double total_da_compra = total1 + total2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total_da_compra.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}