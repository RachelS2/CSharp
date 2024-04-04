///Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
///mostre:

using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            Console.WriteLine("Valor de A, B e C: ");

            string[] vetor = Console.ReadLine().Split(' ');

            A = double.Parse(vetor[0], CultureInfo.InvariantCulture);

            B = double.Parse(vetor[1], CultureInfo.InvariantCulture);

            C = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            //questão A: a área do triângulo retângulo que tem A por base e C por altura.
            double area_do_triangulo = A * C / 2;

            //b) a área do círculo de raio C. (pi = 3.14159) 
            double area_do_circulo = 3.14159 * C * C;

            //c) a área do trapézio que tem A e B por bases e C por altura. 
            double area_do_trapezio = (A + B) * C / 2;

            //d) a área do quadrado que tem lado B. 
            double area_do_quadrado = B * B;

            //e) a área do retângulo que tem lados A e B
            double area_do_retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + area_do_triangulo.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("CIRCULO: " + area_do_circulo.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("TRAPEZIO: " + area_do_trapezio.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("QUADRADO: " + area_do_quadrado.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("RETANGULO: " + area_do_retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}