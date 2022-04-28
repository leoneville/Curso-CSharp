using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterNomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[4];
            string aux;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º nome: ");
                nomes[i] = Console.ReadLine();
            }

            // Mecanismo para inverter os nomes
            aux = nomes[0];
            nomes[0] = nomes[3];
            nomes[3] = aux;
            aux = nomes[1];
            nomes[1] = nomes[2];
            nomes[2] = aux;

            Console.WriteLine();
            Console.WriteLine("Nomes inseridos na sequência invertida");
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            Console.ReadKey();
        }
    }
}
