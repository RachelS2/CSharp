using aula123enum.Entities;
using aula123enum.Entities.Enums;
using System;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString(); //converte "PendingPayment" pra string

            OrderStatus os = Enum.Parse
        }
    }
}