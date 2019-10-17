using secao9EnumeracoesComposicaoExercico01_12.Entites;
using secao9EnumeracoesComposicaoExercico01_12.Entites.Enuns;
using System;

namespace secao9EnumeracoesComposicaoExercico01_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());

            Console.Write("Base salary:");
            double baseSalary = double.Parse(Console.ReadLine());

            Console.Write("How many contracts to this worker?");
            int nContracts = int.Parse(Console.ReadLine());

            Departament departament = new Departament();
            Worker worker = new Worker(name,level,baseSalary,departament);

            for (int i = 1; i <= nContracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHours = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HoursContract contract = new HoursContract(date, valuePerHours, hours);
                worker.AddContract(contract);
            }
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string MonthYear = Console.ReadLine();
            int month = int.Parse(MonthYear.Substring(0, 2));
            int year = int.Parse(MonthYear.Substring(3));
            Console.WriteLine("Name: "+worker.Name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine("Income for "+MonthYear+" : "+worker.Icome(month,year));




        }
    }
}
