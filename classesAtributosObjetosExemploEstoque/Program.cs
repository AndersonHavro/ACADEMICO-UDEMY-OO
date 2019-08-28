using System;

namespace classesAtributosObjetosExemploEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();

            Console.WriteLine("produto: ");
            p1.Name = Console.ReadLine();
            Console.WriteLine("preco: ");
            p1.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("quantidade: ");
            p1.Quantity = int.Parse(Console.ReadLine());

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
