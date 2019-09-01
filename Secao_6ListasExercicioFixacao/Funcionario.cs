using System;

using System.Text;
using System.Globalization;     

namespace Secao_6ListasExercicioFixacao
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get;private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario(double valorAumentado)
        {
            double aumento = 1 + (valorAumentado / 100);
            Salario *= aumento; 
        }
        public override string ToString()
        {
            return +Id
                   + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
