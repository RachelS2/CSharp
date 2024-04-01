using System;
/* Fazer um programa para ler dois números inteiros M e N, e depois ler
uma matriz de M linhas por N colunas contendo números inteiros,
podendo haver repetições. Em seguida, ler um número inteiro X que
pertence à matriz. Para cada ocorrência de X, mostrar os valores à
esquerda, acima, à direita e abaixo de X, quando houver, conforme
exemplo.*/

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ordem = Console.ReadLine().Split(' ');

            int linha, coluna;

            linha = int.Parse(ordem[0]);
            coluna = int.Parse(ordem[1]);

            int[,] matriz = new int[linha, coluna];

            for (int l = 0; l < linha; l++)
            {
                string[] elementos = Console.ReadLine().Split(' ');

                for (int c = 0; c < coluna; c++)
                    matriz[l, c] = int.Parse(elementos[c]);

            }

            int num = int.Parse(Console.ReadLine());

            for (int l = 0; l < linha; l++)
            {
                for (int c = 0; c < coluna; c++)
                {
                    if (matriz[l, c] == num)
                    {
                        Console.Write("\nPosition: {0},{1}:", l, c);

                        if (matriz[l, c - 1] != ' ') Console.Write("\nLeft: " + matriz[l, c - 1]);

                        if (matriz[l, c + 1] != ' ') Console.Write("\nRight: " + matriz[l, c + 1]);

                        if (matriz[l + 1, c] != ' ') Console.Write("\nDown: " + matriz[l + 1, c]);

                        Console.WriteLine(); 

                    }
                }
            }
        }
    }
}

            
        
