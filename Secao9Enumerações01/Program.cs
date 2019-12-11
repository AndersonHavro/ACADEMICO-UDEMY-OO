using Secao9Enumerações01.Enums;
using System;

namespace Secao9Enumerações01
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                ID = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered
            };

            Console.WriteLine(order);

        }
    }
}
