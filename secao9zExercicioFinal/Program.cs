using System;
using secao9zExercicioFinal.Entites;
using secao9zExercicioFinal.Entites.Enums;

namespace secao9zExercicioFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            #region object cliente
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            #endregion
            Client client1 = new Client();
            #region object order
            Console.WriteLine("Enter cliente data:");
            Console.Write("Status: ");
            OdersStatus status = Enum.Parse<OdersStatus>(Console.ReadLine());
            DateTime momment = DateTime.Now;
            #endregion
            Order order1 = new Order(momment, status, client1);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                #region objetc Product
                Console.WriteLine("Product name: ");                string nameProduct = Console.ReadLine();                Console.WriteLine("Product price: ");                double priceProduct = double.Parse(Console.ReadLine());


                #endregion                Product product1 = new Product(nameProduct, priceProduct);

                #region object OrderItem
                Console.WriteLine("Quantity: ");                int quantity = int.Parse(Console.ReadLine()); 
                #endregion                OrderItem item = new OrderItem(quantity, priceProduct, product1);                order1.AddItem(item);            }

            Console.WriteLine(order1);
        }
    }
}
