using System;

namespace MultiplicarMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[3, 2];
            int[,] resultado = new int[2, 2];

            Console.WriteLine("Preencher a matriz #1");

            for (int l = 0; l < 2; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write("#1. Posição [" + l + "][" + c + "]: ");
                    matriz1[l, c] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nPreencher a matriz #2");

            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Console.Write("#2. Posição [" + l + "][" + c + "]: ");
                    matriz2[l, c] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nResultado de matriz #1 x matriz #2");
            resultado[0, 0] = (matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]);
            resultado[1, 0] = (matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]);
            resultado[0, 1] = (matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]);
            resultado[1, 1] = (matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]);

            for (int l = 0; l < 2; l++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Console.Write("[" + resultado[l,c] + "]");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
