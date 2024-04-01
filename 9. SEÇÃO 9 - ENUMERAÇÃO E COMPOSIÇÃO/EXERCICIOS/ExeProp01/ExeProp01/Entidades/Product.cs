namespace ExeProp01.Entidades
{
    internal class Product
    {
        public string NomeProduto { get; set; }
        private double PrecoProduto { get; set; } = 0;

        public Product (string nomeProduto)
        {
            NomeProduto = nomeProduto;
        }

        public Product(string nomeProduto, double precoProduto)
        {
            NomeProduto = nomeProduto;
            if (PrecoProduto != precoProduto) PrecoProduto = precoProduto;
        }

        public override string ToString()
        {
            return NomeProduto.ToString();
        }
    }
}
