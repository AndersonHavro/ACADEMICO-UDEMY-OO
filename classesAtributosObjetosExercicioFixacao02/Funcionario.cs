using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace classesAtributosObjetosExercicioFixacao02
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {

            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double aumento)
        {
            SalarioBruto = SalarioBruto*((aumento/100)+1); 
        }


        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
