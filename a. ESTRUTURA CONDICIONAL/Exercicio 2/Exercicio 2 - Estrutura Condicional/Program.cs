using System;
using System.Globalization;

//Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva um número inteiro: ");
            int N = int.Parse(Console.ReadLine());
            if (N % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else Console.WriteLine("ÍMPAR");
        }
    }
}