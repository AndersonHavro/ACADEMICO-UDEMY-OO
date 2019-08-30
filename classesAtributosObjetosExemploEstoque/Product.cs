using System;
using System.Globalization;

namespace classesAtributosObjetosExemploEstoque
{
    class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public double Price { get; set; }

        public Product(string name, int quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public double ValorTotalEmEstoque()
        {
            return Quantity * Price;
        }
        public void AddProduct(int quantity)
        {
            Quantity += quantity;
        }
        public void RemoveProduct(int quantity)
        {
            Quantity -= quantity;
        }
        public override string ToString()
        {
            return Name + ", $ " + Price.ToString("f2", CultureInfo.InvariantCulture) +
                   " , " +Quantity + " unidades, Total: " + ValorTotalEmEstoque();
        }
    }
}
