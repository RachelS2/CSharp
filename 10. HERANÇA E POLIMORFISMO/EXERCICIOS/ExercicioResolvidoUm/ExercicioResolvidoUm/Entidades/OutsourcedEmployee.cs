
namespace ExercicioResolvidoUm.Entidades
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public override double Payment() //Reaproveitando o método "Payment" da classe "Employee"
        {
            return base.Payment() + 1.1 * AdditionalCharge ;
        }

        public OutsourcedEmployee(string nome, int horasTrabalhadas, double valorPorHora, double additionalCharge) 
            : base(nome, horasTrabalhadas, valorPorHora)
        {
            AdditionalCharge = additionalCharge;
        }
    }
}
