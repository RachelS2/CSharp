///Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
///hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
///decimais

using System;
using System.Text;
using System.Globalization;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o número do funcionário: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Insira o número de horas trabalhadas do funcionário: ");
            float horas = float.Parse(Console.ReadLine());

            Console.Write("Insira o valor que o funcionário recebe por hora: ");
            float valorHora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float salario = horas * valorHora;

            Console.WriteLine("NUMBER = {0} ", numero);
            Console.WriteLine("SALARY = US$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}