using System;

namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Digite um número: ");
           int a = int.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            int b = int.Parse(Console.ReadLine());
           int c = a + b;
           Console.WriteLine("SOMA = {0}", c);   
        }
    }
}