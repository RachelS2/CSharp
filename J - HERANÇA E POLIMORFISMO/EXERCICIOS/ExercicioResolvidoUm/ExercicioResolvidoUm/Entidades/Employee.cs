namespace ExercicioResolvidoUm.Entidades
{
    internal class Employee
    {
        public string Nome { get; set; }
        public int HorasTrabalhadas { get; set; }
        public double ValorPorHora { get; set; }

        public Employee() { }

        public Employee(string nome, int horasTrabalhadas, double valorPorHora)
        {
            Nome = nome;
            HorasTrabalhadas = horasTrabalhadas;
            ValorPorHora = valorPorHora;
        }

        public virtual double Payment()
        {
            return ValorPorHora * HorasTrabalhadas;
        }
    }
}
