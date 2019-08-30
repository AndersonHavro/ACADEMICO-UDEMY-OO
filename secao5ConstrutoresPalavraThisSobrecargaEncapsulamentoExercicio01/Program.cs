using System;
using System.Globalization;

namespace secao5ConstrutoresPalavraThisSobrecargaEncapsulamentoExercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial(s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            Conta conta;
            if (resposta == 'n')
                conta = new Conta(numero, nome);
            else
            {
                Console.Write("Infomre o valor do depósito: ");
                double depInicial = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
                conta = new Conta(numero, nome, depInicial);
            }
            Console.WriteLine("Dados da conta: \n" + conta);
            Console.WriteLine("");
            Console.Write("Digite um valor para depósito: ");
            double valorDep = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            conta.Deposito(valorDep);
            Console.WriteLine("Dados atualzados: \n" + conta);
            Console.WriteLine("");
            Console.Write("Digite um valor do saque: ");
            double valorSaque = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            conta.Saque(valorSaque);
            Console.WriteLine("Dados atualzados: \n" + conta);

        }
    }
}
