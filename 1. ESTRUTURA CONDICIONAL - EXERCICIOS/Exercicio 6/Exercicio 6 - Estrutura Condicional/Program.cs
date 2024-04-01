using System;
using System.Globalization;

//Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
//seguintes intervalos([0,25], (25,50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em 
//nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número qualquer: ");
            string[] vetor = Console.ReadLine().Split(' ');
            double num = double.Parse(vetor[0]);

            if (25 >= num && num >= 0)
                Console.WriteLine("Intervalo [0,25]");

            else if (50 >= num && num > 25)
                Console.WriteLine("Intervalo [25,50]");

            else if (75 >= num && num > 50)
                Console.WriteLine("Intervalo [50, 75]");

            else if (100 >= num && num > 75)
                Console.WriteLine("Intervalo [75,100]");

            else Console.WriteLine("Fora de intervalo");
        }
    }
}