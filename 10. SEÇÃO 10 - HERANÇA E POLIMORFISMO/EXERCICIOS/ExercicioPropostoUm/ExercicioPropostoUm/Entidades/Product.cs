using System.Globalization;
using System.Collections.Generic;

namespace ExercicioPropostoUm.Entidades
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product() { }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual string priceTag() //etiqueta de preço do produto. se comporta diferentemente dependendo se o produto é usado ou importado.
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
