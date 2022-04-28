using System;

namespace ConversorTemperaturas
{
    class Program
    {
        static void Main()
        {
            double c, f, k;

            Console.WriteLine("### CONVERSOR DE TEMPERATURAS ###");
            Console.Write("Insira a temperatura em Celcius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");
 
            f = (c * 9 / 5) + 32;
            k = c + 273.15;

            Console.WriteLine(c + "° celcius = " + f + "° fahrenheit");
            Console.WriteLine(c + "° celcius = " + k + "° kelvin");
            Console.WriteLine("---------------------------------");
            Console.ReadKey();
        }
    }
}
