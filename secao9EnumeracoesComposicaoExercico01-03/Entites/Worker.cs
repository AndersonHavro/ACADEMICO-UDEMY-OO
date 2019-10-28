using secao9EnumeracoesComposicaoExercico01_03.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace secao9EnumeracoesComposicaoExercico01_03.Entites
{
    class Worker
    {
        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }
        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void revomeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double totalIncome = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    totalIncome += contract.TotalValue();
                }
            }
            return totalIncome;
        }
    }
}
