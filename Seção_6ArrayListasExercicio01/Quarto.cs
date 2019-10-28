using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_6ArrayListasExercicio01
{
    class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumeroQuarto { get; set; }

        public Quarto(string nome, string email, int numeroQuarto)
        {
            Nome = nome;
            Email = email;
            NumeroQuarto = numeroQuarto;
        }

        public override string ToString()
        {
            return NumeroQuarto+": " + Nome + ", " + Email ;
        }
    }
}