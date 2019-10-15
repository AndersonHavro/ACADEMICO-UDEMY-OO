using secao9EnumeracoesComposicao.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace secao9EnumeracoesComposicao.Entites
{
    class Worker
    {
        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContrat> Contrats { get; set; } = new List<HourContrat>();

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

        public void AddContract(HourContrat contrat)
        {
            Contrats.Add(contrat);
        }
        public void RemoveContract(HourContrat contract)
        {
            Contrats.Remove(contract);
        }
       public double Income(int year,int month)
        {
            double sum = BaseSalary;
            foreach (HourContrat contract in Contrats)
            {
                if (contract.Date.Year == year && contract.Date.Month==month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
