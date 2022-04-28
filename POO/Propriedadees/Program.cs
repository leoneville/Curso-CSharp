using System;

namespace Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            t.Nome = "Neville";
            t.Idade = DateTime.Now.Year - 1998;

            Console.WriteLine(t.Nome + " " + t.Sobrenome);
            Console.WriteLine(t.Idade);
        }
    }
}
