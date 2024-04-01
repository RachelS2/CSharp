using System;

namespace ExercicioPropostoUM.Exceptions
{
    internal class DomainException : ApplicationException //subclasse de application exception
    {
        public DomainException(string message) : base(message) //construtor que repassa a mensagem para o construtor de application exception
        {

        }
    }
}
