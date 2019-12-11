using secao9EnumeracoesComposicaoExercico01.Entites;
using secao9EnumeracoesComposicaoExercico01.Entites.Enums;
using System;

namespace secao9EnumeracoesComposicaoExercico01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the dept name:");
            string deptName = Console.ReadLine();
            Departament dept = new Departament(deptName);//obj departamento

            Console.WriteLine("Enter Worker Data:");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Level (Junior, MidLevel, Senior):");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary:");
            double baseSalary = double.Parse(Console.ReadLine());
            Worker worker = new Worker(name, level, baseSalary, dept);//obj trabalhador

            Console.WriteLine("How many contracts?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #" + 1 + "contract data:");
                Console.Write("Date:");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour:");
                double value = double.Parse(Console.ReadLine());
                Console.Write("Duration:");
                int hours = int.Parse(Console.ReadLine());

                HousContract contract = new HousContract(date, value, hours);
                worker.AddContract(contract);
            }
            Console.Write("Enter month and year to calculate income(mm/yyyy)");
            string MesAno = Console.ReadLine();
            int month = int.Parse(MesAno.Substring(2));
            int year = int.Parse(MesAno.Substring(3, 4));

            Console.Write("Name: "+worker.Name);
            Console.Write("Departament:"+worker.Departament);
            Console.Write("Income for "+MesAno+": "+worker.Icome(year,month));
            



        }
    }
}
