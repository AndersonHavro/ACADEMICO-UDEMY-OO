using System;
using System.Globalization;

namespace Seção_6ArrayListasExempo2
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma=0, media = 0;
            Console.Write("Quantidade de produtos: ");
            int qtd = int.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            Product[] vect = new Product[qtd];
            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Digite o nome do produto:");
                string nome = Console.ReadLine();
                Console.Write("Digite o valor:");
                double price = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
                vect[i] = new Product(nome, price);
                soma += vect[i].Price;
            }
            media = soma / qtd;
            Console.WriteLine("AVERAGE PRICE: "+media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
