using secao9EnumeracoesComposicaoExercico01.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace secao9EnumeracoesComposicaoExercico01.Entites
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HousContract> Contracts { get; set; } = new List<HousContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HousContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HousContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Icome(int year, int month)
        {
            double Ic = 0;

            foreach (HousContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    Ic = Ic + contract.TotalValue();
                }
            }
            return Ic;
        }
    }
}




