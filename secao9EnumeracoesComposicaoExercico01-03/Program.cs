using secao9EnumeracoesComposicaoExercico01_03.Entites;
using secao9EnumeracoesComposicaoExercico01_03.Entites.Enums;
using System;

namespace secao9EnumeracoesComposicaoExercico01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string dptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior):");
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            Departament departament = new Departament(dptName);
            Worker worker = new Worker(name, level, baseSalary, departament);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhours = double.Parse(Console.ReadLine());
                Console.Write("Duration: ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valueperhours, hours);
                worker.addContract(contract);
            }

            Console.WriteLine("Enter month and year to calculate income (MM/YYYY):");
            string monthAndYear = Console.ReadLine();
            int month =int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: "+ worker.Name);
            Console.WriteLine("Departament:"+worker.Departament);
            Console.WriteLine("Income for" + monthAndYear + " :" + worker.Income(year,month));


        }
    }
}
