using System;
using System.Collections.Generic;
using System.Text;

namespace secao9EnumeracoesComposicao.Entites
{
    class HourContrat
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContrat()
        {
        }
        public HourContrat(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
