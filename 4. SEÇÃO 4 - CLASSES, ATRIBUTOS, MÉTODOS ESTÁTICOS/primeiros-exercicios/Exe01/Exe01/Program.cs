using Exe01;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados j, m;
            j = new Dados();
            m = new Dados();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            m.nome = Console.ReadLine();
            Console.Write("Idade: ");
            m.idade = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            j.nome = Console.ReadLine();
            Console.Write("Idade: ");
            j.idade = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            if (j.idade > m.idade) Console.WriteLine("Pessoa mais velha: " + j.nome);
            else Console.WriteLine("Pessoa mais velha: " + m.nome);
        }
    }
}
