using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cliente = new ContaBancaria();
            Console.Write("Entre o número da conta: ");
            int NumeroDaConta = int.Parse(Console.ReadLine());
            cliente.NroDaConta = NumeroDaConta;

            Console.Write("Entre o titular da conta: ");
            string Nome = Console.ReadLine();
            cliente.Nome = Nome;

            Console.Write("Haverá depósito inicial (s/n)? ");
            string resposta = Console.ReadLine();

            if (resposta == "S" || resposta == "s")
            {
                Console.Write("Entre o valor do depósito inicial: $ ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cliente.Saldo = depositoInicial;
                Console.WriteLine();
                Console.WriteLine("Dados da conta: " + cliente);

            }

            else if (resposta == "N" || resposta == "n")
            {
                Console.WriteLine("\nDados da conta: " + cliente);
            }

            else { Console.WriteLine("Reinicie o programa e tente novamente."); }

            Console.Write("\nEntre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente.Deposito = deposito;
            Console.WriteLine("Dados da conta atualizados: " + cliente);

            Console.Write("\nEntre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente.Saque = saque;
            Console.WriteLine("Dados da conta atualizados: " + cliente);

        }
    }
}
