namespace ExercicioPropostoDois.Entidades
{
    internal class PessoaJuridica : Contribuinte
    {
        public int numeroDeEmpregados { get; set; }

        public PessoaJuridica(int number_of_employees, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            numeroDeEmpregados = number_of_employees;
        }
        public override double Tax()
        {
            if (numeroDeEmpregados > 10)
                return RendaAnual * 0.14;
            else
                return RendaAnual * 0.16;
        }
    }
}
