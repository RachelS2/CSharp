namespace ExeRes01.Entidades
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double valuePerHour { get; set; }
        public int Hora {get; set; }

        public HourContract() { } //construtor padrão

        public HourContract(DateTime date, double valuePerHour, int hora) //construtor com parâmetros
        {
            Date = date;
            this.valuePerHour = valuePerHour;
            Hora = hora;
        }

        public double totalValue()
        {
            double totalValor = valuePerHour * Hora;
            return totalValor;
        }

    }
}
