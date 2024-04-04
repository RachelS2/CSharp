using System.Globalization;
using ExercicioPropostoUM.Exceptions;

namespace ExercicioPropostoUM.Entidades
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double withdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit) //construtor 
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            this.withdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount) //método que adiciona valor ao saldo (Balance)
        {
            Balance = Balance + amount;
        }

        public void Withdraw(double amount) //método de saque (retira valor de Balance)
        {
            if (amount > withdrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit"); //chama a excessão 
            }
            else if (amount > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance"); //chama a excessão 
            }
            else
            {
                Balance = Balance - amount;
                Console.WriteLine("New balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
