using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }

        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Leonardo Neville";
            p1.idade = 24;
            p1.altura = 1.81;
            
            Pessoa p2 = new Pessoa() 
            { 
                nome = "Tayler",
                idade = 28,
                altura = 1.97
            };

            p1.nome = "Logan";

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.altura);

            Console.WriteLine();

            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.idade);
            Console.WriteLine(p2.altura);

            Console.ReadKey();
        }
    }
}
