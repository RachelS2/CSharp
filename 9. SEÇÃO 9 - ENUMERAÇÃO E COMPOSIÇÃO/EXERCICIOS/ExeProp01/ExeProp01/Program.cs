/*Ler os dados de um pedido com N itens (N fornecido pelo usuário). Depois, mostrar um
sumário do pedido conforme exemplo (próxima página). Nota: o instante do pedido deve ser
o instante do sistema: DateTime.Now*/

using ExeProp01.Entidades;
using ExeProp01.Enums;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");

            Console.Write("Name: ");
            string nomeCliente = Console.ReadLine();

            Console.Write("Email: ");
            string emailCliente = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime aniversarioCliente = DateTime.Parse(Console.ReadLine());

            Client Cliente = new Client(nomeCliente, emailCliente, aniversarioCliente); //instanciando cliente

            Console.WriteLine("Enter order data: ");

            Console.Write("Status: ");
            OrderStatus Status = Enum.Parse<OrderStatus>(Console.ReadLine());

            DateTime agora = DateTime.Now;

            Order Ordem = new Order(agora, Status, Cliente); //instanciando a Ordem, passando o momento, status e o cliente que a fez

            Console.Write("How many items to this order? ");
            int quantidadeDeItens = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeDeItens; i++)
            {
                Console.WriteLine("Enter #{0} item data: ", i+1);
                Console.Write("Product name: ");
                string nomeProduto = Console.ReadLine();

                Console.Write("Product price: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int quantidadeProduto = int.Parse(Console.ReadLine());

                Product nomeProdutoDoPedido = new Product(nomeProduto);

                OrderItem Pedido = new OrderItem(nomeProdutoDoPedido, precoProduto, quantidadeProduto);

                Product precoAtual = new Product(nomeProduto, precoProduto);

                Ordem.AddItem(Pedido); //adicionando o pedido na ordem

                Console.WriteLine(); 
            }

            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine("Order moment: " + Ordem.Moment);
            Console.WriteLine("Order status: " + Ordem.Status);
            Console.WriteLine("Client: " + Ordem.Cliente.Name + " (" + Ordem.Cliente.BirthDate.ToString("D") + ") - " + Ordem.Cliente.Email);
            
            Console.WriteLine("Order items: ");

            double soma = 0;
            foreach (OrderItem pedido in Ordem.Itens)
            {
                Console.WriteLine(pedido);
                soma = soma + pedido.subTotal();
            }

            Console.Write("Total price: $" + soma);
            Console.WriteLine();

        }
    }
}