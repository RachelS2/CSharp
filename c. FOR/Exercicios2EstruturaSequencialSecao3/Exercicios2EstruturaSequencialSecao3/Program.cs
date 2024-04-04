using System;
using System.Globalization; 

namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());
            double area = Math.Pow(raio, 2) * 3.14159;

            Console.WriteLine("Área = {0:F4}", area);
        }
    }
}