using System;
using System.Globalization;

//Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
//Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
//ordem crescente ou decrescente.

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números:");
            string[] vetor = Console.ReadLine().Split(' ');
            int A = int.Parse(vetor[0]);
            int B = int.Parse(vetor[1]);

            if (A > B && A % B == 0) Console.WriteLine("São Múltiplos");

            else if (B > A && B % A == 0) Console.WriteLine("São Múltiplos");

            Console.WriteLine("Não são múltiplos");

        }
    }
}