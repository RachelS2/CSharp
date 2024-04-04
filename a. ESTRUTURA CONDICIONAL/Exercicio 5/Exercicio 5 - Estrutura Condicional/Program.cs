using System;
using System.Globalization;

//Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
//seguir, calcule e mostre o valor da conta a pagar.

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade; 
            double preco;
            Console.WriteLine("Digite o código do produto (1 à 5) e a quantidade dele que deseja adquirir. ");
            string[] vetor = Console.ReadLine().Split(' ');
            codigo = int.Parse(vetor[0]);
            quantidade = int.Parse(vetor[1], CultureInfo.InvariantCulture);
            if (codigo > 5 || codigo < 1) Console.WriteLine("Código inválido. Tente novamente.");
            else
            {
                if (codigo == 1)
                {
                    preco = quantidade * 4;
                    Console.WriteLine("Total: R$ " + preco.ToString(CultureInfo.InvariantCulture));

                }
                else if (codigo == 2)
                {
                    preco = quantidade * 4.5;
                    Console.WriteLine("Total: R$ " + preco.ToString(CultureInfo.InvariantCulture));
                }
                else if (codigo == 3)
                {
                    preco = quantidade * 5;
                    Console.WriteLine("Total: R$ " + preco.ToString(CultureInfo.InvariantCulture));
                }
                else if (codigo == 4)
                {
                    preco = quantidade * 2;
                    Console.WriteLine("Total: R$ " + preco.ToString(CultureInfo.InvariantCulture));
                }
                else if (codigo == 5)
                {
                    preco = quantidade * 1.5;
                    Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
                }
            }


        }
    }
}