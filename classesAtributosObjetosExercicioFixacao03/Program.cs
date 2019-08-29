using System;
using System.Globalization;

namespace classesAtributosObjetosExercicioFixacao03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Notas: ");
            aluno.Nota1 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            aluno.Nota2 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            aluno.Nota3 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            Console.WriteLine("Nota Final: "+aluno.Media().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(aluno.Resultado());
            if (aluno.Resultado()=="reprovado")
            {
                Console.WriteLine("Faltam "+aluno.Resto().ToString("F2", CultureInfo.InvariantCulture) 
                    + " pontos");
            }
           
            
        }
    }
}
