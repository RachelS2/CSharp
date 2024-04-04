﻿using System;

//Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
//Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
//essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo)

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int IN = 0; int OUT = 0;
            Console.Write("Quantidade de repetições: ");
            N = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < N; i++)
            {
                int numero;
                Console.Write("Número: ");
                numero = int.Parse(Console.ReadLine());
                if (numero <= 20 && numero >= 10)
                    IN++;
                else OUT++;
            }
            Console.WriteLine("{0} in", IN);
            Console.WriteLine("{0} out", OUT);
        }
    }
}