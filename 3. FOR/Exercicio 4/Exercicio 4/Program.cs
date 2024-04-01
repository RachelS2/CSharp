using System;
//Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo segundo.
//Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de repetições: ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                double a, b, div;
                Console.Write("Digite um par de números: ");
                string[] vetor = Console.ReadLine().Split(' ');
                a = double.Parse(vetor[0]);
                b = double.Parse(vetor[1]);
                if (b == 0)
                {
                    Console.WriteLine("Divisão Impossível.");
                }
                else {
                    div = a / b;
                    Console.WriteLine(div); }
            }
        }
    }
}