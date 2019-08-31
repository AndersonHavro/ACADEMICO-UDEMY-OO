using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_6ArrayListasExempo2
{
    class Product
    {
        public string Nome { get; set; }
        public double Price { get; set; }

        public Product(string nome, double price)
        {
            Nome = nome;
            Price = price;
        }
    }
}
