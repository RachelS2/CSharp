using ExeProp01.Enums;

namespace ExeProp01.Entidades
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>(); //uma ordem pode ter vários pedidos diferentes 

        public Client Cliente { get; set; }

        public Order(DateTime moment, OrderStatus status, Client cliente)
        {
            Moment = moment;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem (OrderItem item) //adicionando pedidos na ordem
        {
                Itens.Add(item);
        }

        public void RemoveItem(OrderItem item) //removendo pedidos da ordem
        {
                Itens.Remove(item);

        }




    }
}
