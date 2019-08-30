using System;

namespace classesAtributosObjetosExemploEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("produto: ");
            string name = Console.ReadLine();
            Console.WriteLine("preco: ");
           double price = double.Parse(Console.ReadLine());
            Console.WriteLine("quantidade: ");
            int quantity = int.Parse(Console.ReadLine());

            Product p1 = new Product(name,quantity,price);

            Console.WriteLine("Dados do produto: " + p1.ToString());

            Console.Write("Digite o numero de produtos a ser adicionado: ");
            int qtd = int.Parse(Console.ReadLine());
            p1.AddProduct(qtd);
            Console.WriteLine("Dados atualizados: " + p1.ToString());

            Console.Write("Digite o numero de produtos a serem removidos: ");
            int remover = int.Parse(Console.ReadLine());
            p1.RemoveProduct(remover);
            Console.WriteLine("Dados atualizados: " + p1.ToString());
                                                                    
        }
    }
}
