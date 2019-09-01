using System;
using System.Globalization;


namespace Seção_6ArrayListasExercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a qunatidade de alunos que irão se hospedar: ");
            int n = int.Parse(Console.ReadLine());
            Quarto[] quarto = new Quarto[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.Write("Digite o nome do" + (i + 1) + "Aluno: ");
                string nome = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Digite o Email do" + (i + 1) + "Aluno: ");
                string email = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Digite o numero do quarto do" + (i + 1) + "Aluno: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                quarto[i] = new Quarto(nome, email, numeroQuarto);
            }

            for (int i = 0; i < 10; i++)
            {
                if (quarto[i].NumeroQuarto != 0)

                    Console.WriteLine(quarto[i]);



            }

        }
    }
}
