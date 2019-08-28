using System;
using System.Collections.Generic;
using System.Text;

namespace classesAtributosObjetosExercicioFixacao01
{
    public class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Largura) + 2 * (Altura);
        }
        public double Diagonal()
        {

            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }
    }
}
