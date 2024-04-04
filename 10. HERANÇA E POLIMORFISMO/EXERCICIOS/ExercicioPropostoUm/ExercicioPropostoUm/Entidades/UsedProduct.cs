using System.Globalization;
using System.Collections.Generic;

namespace ExercicioPropostoUm.Entidades
{
    internal class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }
        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public override string priceTag() 
        {
            return Name + "(used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + "(Manufacture date: " + manufactureDate.ToString("dd/MM/yyyy") + ")"; 
        }
    }
}
