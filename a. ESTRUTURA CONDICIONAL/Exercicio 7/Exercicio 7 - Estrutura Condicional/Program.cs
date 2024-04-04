using System;
using System.Globalization;

//Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
//de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
//ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
//Se o ponto estiver na origem, escreva a mensagem “Origem”.
//Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
//situação

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y;
            Console.Write("Coordenada X e Y: ");
            string[] vetor = Console.ReadLine().Split(' ');
            X = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            Y = double.Parse(vetor[1], CultureInfo.InvariantCulture);

            if (X > 0 && Y > 0) Console.WriteLine("Q1");

            else if (X < 0 && Y > 0) Console.WriteLine("Q2");

            else if (X < 0 && Y < 0) Console.WriteLine("Q3");

            else if (X > 0 && Y < 0) Console.WriteLine("Q4");

            else Console.WriteLine("Origem");
        }
    }
}
