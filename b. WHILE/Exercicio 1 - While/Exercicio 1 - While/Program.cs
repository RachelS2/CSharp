using System;
using System.Globalization;

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