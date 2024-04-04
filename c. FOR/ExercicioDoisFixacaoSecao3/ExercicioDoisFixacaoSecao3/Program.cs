using System;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string vet = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] dados = Console.ReadLine().Split(' ');

            Console.WriteLine(vet);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(dados[1]);
            Console.WriteLine(dados[2]);
            Console.WriteLine(dados[3]);


        }
    }
}