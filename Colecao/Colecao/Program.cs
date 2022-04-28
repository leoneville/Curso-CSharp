using System;

namespace Colecao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vetores
            int[] numeros = new int[5];

            numeros[0] = 10;
            numeros[1] = 20;    
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            numeros[2] = 55;

            string[] nomes = 
            { 
                "Neville", 
                "Laís", 
                "Cézar" 
            };

            nomes[0] = "Logan";

            Console.WriteLine(numeros[2]);
            Console.WriteLine(nomes[0]);
            Console.ReadKey();
            #endregion

            int[,] numbers = new int[2,3];

            numbers[0, 0] = 10;
            numbers[0, 1] = 20;
            numbers[0, 2] = 30;

            numbers[1, 0] = 40;
            numbers[1, 1] = 50;
            numbers[1, 2] = 60;

            for (int l = 0; l < 2; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write("[" + numbers[l, c] + "]");
                }
                Console.WriteLine();
            }

            string[,] names =
            {
                { "Neville", "Laís", "Leonardo" },
                { "Flávio", "Gloria", "Bia"}
            };

            Console.WriteLine(names[0, 1]);
            Console.ReadLine();
        }
    }
}