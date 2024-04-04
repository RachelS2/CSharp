using System;
using System.Globalization;

//Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
//começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora_inicial, hora_final, duracao;
            Console.WriteLine("Insira a hora inicial e a hora final do jogo: ");
            string[] vetor = Console.ReadLine().Split(' ');

            hora_inicial = int.Parse(vetor[0]);
            hora_final = int.Parse(vetor[1]);

            if (hora_final > hora_inicial)
            {
                duracao = hora_final - hora_inicial;
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
            }

            else if (hora_inicial > hora_final)
            {
                int PM = 24 - hora_inicial;
                duracao = PM + hora_final;
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
            }
            else Console.WriteLine("O JOGO DUROU 24 HORA(S)");
        }
    }
}