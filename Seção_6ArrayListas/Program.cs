using System;
using System.Globalization;

namespace Seção_6ArrayListas
{
    class Program
    {
        static void Main(string[] args)
        {
            double media=0,soma=0;
            Console.Write("Digite o numero de pessoas: ");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite a altura da pessoa " + (i + 1) + ":");
                vect[i] = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
                soma += vect[i];
            }
            media = soma / n;
            Console.WriteLine("Average height = "+media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
