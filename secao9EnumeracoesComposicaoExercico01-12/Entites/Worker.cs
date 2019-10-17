using secao9EnumeracoesComposicaoExercico01_12.Entites.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace secao9EnumeracoesComposicaoExercico01_12.Entites
{
    class Worker
    {
        public string Name { get; set; }
        public WorkLevel  Level { get; set; }
        public double BaseSalary { get; set; }

        public Departament Departament { get; set; }

        public List<HoursContract> Contracts { get; set; } = new List<HoursContract>();

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

        public void AddContract(HoursContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HoursContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Icome(int month,int year)
        {
            double sum = BaseSalary;
            foreach (HoursContract contract in Contracts)
            {
                if (contract.Date.Year==year && contract.Date.Month==month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
           
        }
    }
}
