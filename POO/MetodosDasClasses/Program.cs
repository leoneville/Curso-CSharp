using System;

namespace MetodosDasClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();

            #region Métodos Simples
            //m.Cumprimentar();
            //m.Somar(10, 5);
            //m.Apresentar("Neville", 24);
            #endregion

            #region Métodos com parâmetros
            //int valor1 = 100;
            //int valor2 = 100;
            #endregion

            #region Passagem de parâmetros por valor e por referência
            //m.AumentarValor(valor1);
            //m.AumentarRef(ref valor2);
            //Console.WriteLine("Valor 1: " + valor1);
            //Console.WriteLine("Valor 2: " + valor2);
            #endregion

            #region Métodos com retorno de valores
            //string nomeCompleto = m.MontaNome("Leonardo", "Neville");
            //int codigoChar = m.CodigoChar('a');
            //double pi = m.ValorPI();

            //Console.WriteLine(nomeCompleto);
            //Console.WriteLine(codigoChar);
            //Console.WriteLine(pi);
            #endregion

            var hora = DateTime.Now.ToString("HH");
            int intHora = int.Parse(hora);

            Console.WriteLine(intHora);

            m.Cumprimentar();
            m.Cumprimentar("Neville");
            m.Cumprimentar("Neville", int.Parse(hora));


            bool res1 = m.Comparar(100, 50 * 2);
            bool res2 = m.Comparar("Neville", "neville");
            Console.WriteLine(res1);
            Console.WriteLine(res2);
        }
    }
}