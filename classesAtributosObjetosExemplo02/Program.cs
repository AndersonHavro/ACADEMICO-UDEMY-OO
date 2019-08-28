using System;

/*Fazer um programa para ler nome e salário de dois funcionários.Depois, mostrar o salário
  médio dos funcionários.*/

namespace classesAtributosObjetosExemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            double salarioMedio = 0;
            Console.WriteLine("Digite o nome e salario do funcionario 01");
            f1.Nome = Console.ReadLine();
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome e salario do funcionario 02");
            f2.Nome = Console.ReadLine();
            f2.Salario = double.Parse(Console.ReadLine());

            salarioMedio = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("Salario medio =" + salarioMedio);
        }
    }
}

