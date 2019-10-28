using Secao9Enumerações.Entites;
using Secao9Enumerações.Entites.Enums;
using System;

namespace Secao9Enumerações
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.Id = 1080;
            order.Moment = DateTime.Now;
            order.Status = Entites.Enums.OrderStatus.Processing;

            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

        }

    }
}
