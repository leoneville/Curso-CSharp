using System; 

namespace ClassesObjetos
{ 
    class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            /*MinhaClasse mClasse = new MinhaClasse();
            OutraClasse outra = new OutraClasse();
            OutraClasse outra2 = outra;*/
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Neville";
            p1.sobrenome = "Barbosa";
            p1.anoNascimento = 1998;

            Pessoa p2 = new Pessoa()
            {
                nome = "Leonardo",
                sobrenome = "Guimarães",
                anoNascimento = 1998
            };

            p1.nome = "Tayler";

            Console.WriteLine("Pessoa 1: "  + p1.nome);
            Console.WriteLine("Pessoa 1: "  + p1.sobrenome);
            Console.WriteLine("Pessoa 1: "  + p1.anoNascimento);
            p1.Cumprimentar();

            Console.WriteLine();

            Console.WriteLine("Pessoa 2: "  + p2.nome);
            Console.WriteLine("Pessoa 2: "  + p2.sobrenome);
            Console.WriteLine("Pessoa 2: "  + p2.anoNascimento);
            p2.Cumprimentar();
        }
    }

    class MinhaClasse
    {

    }
}
