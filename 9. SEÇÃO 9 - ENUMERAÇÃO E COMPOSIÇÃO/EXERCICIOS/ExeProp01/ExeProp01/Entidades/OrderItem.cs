using System.Globalization;

namespace ExeProp01.Entidades
{
    internal class OrderItem //armazena a quantidade e o preço de um produto 
    {
        public OrderItem()
        {
        }

        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Name { get; set; }
        public double subTotal()
        {
            double subTotal = Quantity * Price;
            return subTotal;
        }

        public OrderItem(Product name, double price, int quantity)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: " + Quantity + ", Subtotal: $ " + subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
