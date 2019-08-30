using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace secao5ConstrutoresPalavraThisSobrecargaEncapsulamentoExercicio01
{
    class Conta
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public Conta(int numero, string nome, double depInicial)
        {
            Numero = numero;
            Nome = nome;
            Saldo += depInicial;
        }

        public void Deposito(double valorDep)
        {
            Saldo += valorDep;
        }
        public void Saque(double valorSaque)
        {

             Saldo = (-1*(valorSaque + 5)) + Saldo;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
