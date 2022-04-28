using System;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            //Carro c = new Carro();
            //Bicicleta b = new Bicicleta();

            //c.Acelerar();
            //b.Acelerar();
            #endregion

            Humano hu = new Humano();
            Pessoa p = new Pessoa();
            Homem ho = new Homem();

            Console.WriteLine("\nHumano");
            hu.Olhos();
            hu.Cabelos();

            Console.WriteLine("\nPessoa");
            p.Olhos();
            p.Cabelos();

            Console.WriteLine("\nHomem");
            ho.Olhos();
            ho.Cabelos();
        }
    }
}
