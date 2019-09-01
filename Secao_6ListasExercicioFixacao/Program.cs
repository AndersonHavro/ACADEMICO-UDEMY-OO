using System;
using System.Collections.Generic;
using System.Globalization;

namespace Secao_6ListasExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            List<Funcionario> funcionario = new List<Funcionario>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + (i + 1) + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
                funcionario.Add(new Funcionario(id, name, salary));
                Console.WriteLine();
            }
            Console.Write("Enter de employee thet will have a salary increase: ");
            int codigo = int.Parse(Console.ReadLine());
            Funcionario emp = funcionario.Find(x => x.Id == codigo);
            if (emp != null)
            {
                Console.Write("Enter de percentage: ");
                double perc = double.Parse(Console.ReadLine());
                emp.AumentoSalario(perc);
            }
            else
            {
                Console.WriteLine("Valor não encontrado");
            }

            Console.WriteLine("Valores atualizados:");
            foreach (Funcionario item in funcionario)
            {
                Console.WriteLine(item);
            }

        }
    }
}
