using System;

namespace Secao_6MatrizExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            int cont = 1, comneg = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("digite o elemento " + cont);
                    mat[i, j] = int.Parse(Console.ReadLine());
                    cont++;
                }
            }
            Console.WriteLine("Diagonal principal:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(mat[i, j]);
                        Console.WriteLine();
                    }
                    if (mat[i, j] < 0)
                    {
                        comneg++;
                    }
                }
            }
            Console.WriteLine("Negativos:"+comneg);
        }

    }
}
