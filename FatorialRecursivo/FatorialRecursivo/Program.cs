using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Calcular fatorial de qual número: ");
            int numero = int.Parse(Console.ReadLine());
            long result = Fatorial(numero);
            Console.WriteLine("O fatorial de {0} é {1}", numero, result);
            Console.ReadKey();
        }

        static int Fatorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * Fatorial(num - 1);
        }
    }
}
