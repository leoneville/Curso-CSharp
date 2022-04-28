using System;

namespace TesteDelegate
{
    class Program
    {
        delegate void Saudacao(string nome, int time);
        static void Main(string[] args)
        {
            int hora = int.Parse(DateTime.Now.ToString("HH"));

            Saudacoes s = new Saudacoes();
            Saudacao salut = null;

            salut += s.SaudacaoEmPortugues;
            salut += s.SaudacaoEmIngles;
            salut += s.SaudacaoEmEspanhol;
            salut += s.SaudacaoEmFrances;

            salut("Neville", hora);



        }
    }
}