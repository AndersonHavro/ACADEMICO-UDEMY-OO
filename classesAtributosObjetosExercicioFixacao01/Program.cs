using System;
using System.Globalization;
namespace classesAtributosObjetosExercicioFixacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo rec = new Retangulo();
            Console.WriteLine("digite a Largura e altura!");
            rec.Largura = double.Parse(Console.ReadLine());
            rec.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area: "+rec.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: "+rec.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + rec.Diagonal().ToString("F2",CultureInfo.InvariantCulture));
            
        }
    }
}
