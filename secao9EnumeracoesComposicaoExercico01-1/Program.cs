using secao9EnumeracoesComposicaoExercico01_1.Entites.Enums;
using System.Globalization;
using System;
using secao9EnumeracoesComposicaoExercico01_1.Entites;

namespace secao9EnumeracoesComposicaoExercico01_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Depertament dept = new Depertament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int ncontracts = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= ncontracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valePerHour = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valePerHour, duration);
                worker.AddContract(contract);
            }
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year =int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: "+worker.Name);
            Console.WriteLine("Departament: "+worker.Depertament.Name);
            Console.WriteLine("Income for "+monthAndYear+": "+worker.Income(year,month)) ;

        }
    }
}
