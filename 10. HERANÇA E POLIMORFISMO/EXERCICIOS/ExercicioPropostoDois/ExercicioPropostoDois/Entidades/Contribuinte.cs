
namespace ExercicioPropostoDois.Entidades
{
    abstract class Contribuinte
    {
        public string Nome {  get; set; }
        public double RendaAnual { get; set; }

        public Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Tax(); //declaração de método abstrato da classe abstrata
    }
}
