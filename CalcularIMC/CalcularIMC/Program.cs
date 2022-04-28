using System;

namespace CalcularIMC
{ 
    class Program
    {
        static void Main()
        {
            Console.Write("Informe o peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (Math.Pow(altura, 2));

            if (valorIMC < 20)
            {
                Console.WriteLine("\nIMC = " + valorIMC.ToString("0.##") + " -> Abaixo do peso");
            } 
            else if (valorIMC >= 20 && valorIMC <= 24)
            {
                Console.WriteLine("\nIMC = " + valorIMC.ToString("0.##") + " -> Normal");
            }
            else if (valorIMC >= 25 && valorIMC <= 29)
            {
                Console.WriteLine("\nIMC = " + valorIMC.ToString("0.##") + " -> Acima do peso");
            }
            else if (valorIMC >= 30 && valorIMC <= 34)
            {
                Console.WriteLine("\nIMC = " + valorIMC.ToString("0.##") + " -> Obesa");
            }
            else
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> Muito obesa");
            }

            Console.ReadKey();
        }
    }
}