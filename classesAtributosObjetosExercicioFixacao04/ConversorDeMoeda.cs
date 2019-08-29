using System;
using System.Collections.Generic;
using System.Text;

namespace classesAtributosObjetosExercicioFixacao04
{
    class ConversorDeMoeda
    {
        public static double IOF = 6;

        public static double Conversao(double cotacao, double quant)
        {
            return (((IOF / 100) + 1) * (cotacao * quant));
        }
    }
}
