using System;
using System.Collections.Generic;
using System.Text;

namespace secao9EnumeracoesComposicaoExercico01_12.Entites
{
    class Departament
    {
        public string  Name { get; set; }

        public Departament()
        {
        }

        public Departament(string deptName)
        {
            Name = deptName;
        }
    }
}
