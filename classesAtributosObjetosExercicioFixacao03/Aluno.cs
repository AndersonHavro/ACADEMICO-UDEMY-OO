using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace classesAtributosObjetosExercicioFixacao03
{
    class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double Media()
        {
            return (Nota1 + Nota2 + Nota3) ;
        }
        public string Resultado()
        {
            string result = "reprovado";
            if (Media() >= 60)
                result = "aprovado";
            return result;
        }
        public double Resto()
        {
            double resto = 0;
            if (Media() < 60)
                resto = 60 - Media();
            return resto;
        }


    }


}

