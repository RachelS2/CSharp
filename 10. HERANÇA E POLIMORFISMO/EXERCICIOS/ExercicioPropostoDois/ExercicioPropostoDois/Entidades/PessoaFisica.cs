
namespace ExercicioPropostoDois.Entidades
{
    internal class PessoaFisica : Contribuinte
    {
        public double Health { get; set; }

        public PessoaFisica(double Saude, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            Health = Saude;
        }

        public override double Tax()
        {
            if (RendaAnual < 20000.00)
            {
                   return (RendaAnual * 0.15) - (Health * 0.50); 
            }
            else
            {
                   return (RendaAnual * 0.25) - (Health * 0.50);
            }
        }
    }

}

