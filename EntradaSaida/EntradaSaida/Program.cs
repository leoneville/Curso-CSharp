using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSaida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");

            // Console.Write("Leonardo Neville");

            //int codigo = Console.Read();
            //Console.WriteLine(codigo);

            string nome = Console.ReadLine();

            Console.WriteLine("Bem vindo Sr " + nome);

            Console.ReadKey();
        }
    }
}
