using System;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            c.Cliente = "Lais";
            //c.Saldo = 100;

            //======= Operação de Deposito ========
            double valor = 100;
            c.Depositar(valor);

            //======= Operação de Saque ========
            double valor2 = 50;
            c.Sacar(valor2);

            //======= Resultado Saldo Atual ========
            Console.WriteLine("Cliente: " + c.Cliente);
            Console.WriteLine("Saldo: " + c.Saldo);
        }
    }
}
