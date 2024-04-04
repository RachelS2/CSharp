using System;
using System.Globalization;

//Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número:");
            int numero = int.Parse(Console.ReadLine());
            if (numero < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else if (numero >= 0) 
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
        }
    }
}
