using System;
using System.Globalization;

//Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida".
//Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha_certa = 2002;
            int senha;
            Console.Write("Insira a senha: ");
            senha = int.Parse(Console.ReadLine());
            while (senha != senha_certa)
            {
                Console.WriteLine("Senha Inválida");
                Console.Write("Insira a senha: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}