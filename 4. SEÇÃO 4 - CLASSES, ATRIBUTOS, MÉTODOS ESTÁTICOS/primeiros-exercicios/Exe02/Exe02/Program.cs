using Exe02;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados A, B;
            A = new Dados();
            B = new Dados();

            Console.WriteLine("Dados do primeiro funcionário: ");
            
            Console.Write("Nome: ");
            A.nome = Console.ReadLine();

            Console.Write("Salário: ");
            A.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" ");

            Console.WriteLine("Dados do segundo funcionário: ");

            Console.Write("Nome: ");
            B.nome = Console.ReadLine();

            Console.Write("Salário: ");
            B.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (A.salario + B.salario) / 2;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}