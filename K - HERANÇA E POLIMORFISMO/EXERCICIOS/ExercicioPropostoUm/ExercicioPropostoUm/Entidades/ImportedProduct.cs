
using System.Collections.Generic;

namespace ExercicioPropostoUm.Entidades
{
    internal class ImportedProduct : Product
    {
        public double customsFee { get; set; }

        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            this.customsFee = customsFee;
        }

        public double totalPrice() //retorna o preço do produto importado com a taxa da alfândega inclusa
        {
            return customsFee + Price; 
        }

        public override string priceTag()
        {
            return Name + " $ " + totalPrice().ToString("F2") + " (Customs fee: $ " + customsFee + ")" + "\n";
        }
    }
}
