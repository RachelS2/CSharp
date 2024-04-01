/* A dona de um pensionato possui dez quartos para alugar para estudantes,
sendo esses quartos identificados pelos números 0 a 9.
Quando um estudante deseja alugar um quarto, deve-se registrar o nome
e email deste estudante.
Fazer um programa que inicie com todos os dez quartos vazios, e depois
leia uma quantidade N representando o número de estudantes que vão
alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
N estudantes. Para cada registro de aluguel, informar o nome e email do
estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas */

using System;

namespace Pensao
{
    class Aluguel
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int quantidade = int.Parse(Console.ReadLine());

            if (quantidade < 0 || quantidade > 9) Console.Write("\nQuantidade inválida. Tente novamente.");

            Quarto[] estudantes = new Quarto[10];
            
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("\nRent #{0}", i+1);
                Console.Write("\nName: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                estudantes[room] = new Quarto(nome, email); 

            }

            Console.WriteLine("\nBusy rooms: ");
            for (int i = 0; i<10; i++)
            {
                if (estudantes[i] != null)
                {
                    Console.Write(i + ": " + estudantes[i].Nome + ", " + estudantes[i].Email);
                    Console.WriteLine();
                }
            }
                
        }
    }
}