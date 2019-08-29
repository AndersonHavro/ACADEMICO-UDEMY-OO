using System;
using System.Globalization;

/*
 * Fazer um programa para ler os dados de um funcionário (nome,
salário bruto e imposto). Em seguida, mostrar os dados do
funcionário (nome e salário líquido). Em seguida, aumentar o salário
do funcionário com base em uma porcentagem dada (somente o
salário bruto é afetado pela porcentagem) e mostrar novamente os
dados do funcionário. Use a classe projetada abaixo.
*/
namespace classesAtributosObjetosExercicioFixacao02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.WriteLine("Nome: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Salario: ");
            f.SalarioBruto = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            Console.WriteLine("Funcionario: "+f);

            Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
            double aumento = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            f.AumentarSalario(aumento);
            Console.WriteLine("Dados atualizados: " + f);


        }
    }
}
