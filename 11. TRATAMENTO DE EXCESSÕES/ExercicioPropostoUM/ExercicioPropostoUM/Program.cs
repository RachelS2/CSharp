/* Fazer um programa para ler os dados de uma conta bancária e depois realizar um
saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de
saque da conta. Implemente a conta bancária conforme projeto abaixo: */
using ExercicioPropostoUM.Entidades;
using System.Globalization;
using ExercicioPropostoUM.Exceptions;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter account data");

                Console.Write("Number: ");
                int Number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string Name = Console.ReadLine();

                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                double Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account Conta = new Account(Number, Name, initialBalance, withdrawLimit);
            try
            {
                Conta.Withdraw(Valor);
            }
            catch (DomainException e) //captura a excessão
            {
                Console.WriteLine(e.Message);
            }
        }   
    } 
}
