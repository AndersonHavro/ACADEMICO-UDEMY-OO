using System;

namespace classesAtributosInstancias
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite o nome e a idade da primeira pessoa: ");
            p1.nome = Console.ReadLine();
            p1.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome e a idade da segunda pessoa: ");
            p2.nome = Console.ReadLine();
            p2.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pessoa 01:");
            Console.WriteLine("Nome: " + p1.nome);
            Console.WriteLine("Idade: " + p1.idade);

            Console.WriteLine("Pessoa 02:");
            Console.WriteLine("Nome: " + p2.nome);
            Console.WriteLine("Idade: " + p2.idade);

            string maisVelho = p1.nome;

            if (p1.idade >= 0 && p2.idade >= 0)
            {
                if (p1.idade < p2.idade)
                {
                    maisVelho = p2.nome;
                }
                else if (p1.idade == p2.idade)
                {
                    maisVelho = "idades iguais";
                }

                Console.WriteLine("Pessoa mais velha: " + maisVelho);
            }
            else
            {
                Console.WriteLine("Impossivel");
            }

        }
    }
}

