using System;
using System.Collections.Generic;
using System.Text;
using secao9zExercicioFinal.Entites.Enums;
namespace secao9zExercicioFinal.Entites
{
    class Order
    {
        public DateTime Momment { get; set; }
        public OdersStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Order()
        {
        }
        public Order(DateTime momment, OdersStatus status, Client client)
        {
            Momment = momment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            OrderItems.Add(item);
        }
        public double TotalValue()
        {
            double PrecoTotal = 0;
            foreach (OrderItem t in OrderItems)
            {
                PrecoTotal += t.SubTotal();
            }
            return PrecoTotal;
        }
    }
}
