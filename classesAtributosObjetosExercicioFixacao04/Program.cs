using System;
using System.Globalization;

namespace classesAtributosObjetosExercicioFixacao04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação em dolar? ");
            double cotacao = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            Console.Write("Quantos dolares voce vai comprar? ");
            double quant = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("Valor a ser pago em reais: "
                                       +ConversorDeMoeda.Conversao(cotacao,quant).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
