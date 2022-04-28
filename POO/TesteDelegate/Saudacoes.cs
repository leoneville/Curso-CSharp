using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDelegate
{
    internal class Saudacoes
    {
        public void SaudacaoEmPortugues(string nome, int time)
        {
            if (time >= 12 && time < 18)
            {
                Console.WriteLine("Boa tarde, " + nome + ".");
            }
            else if (time >= 18)
            {
                Console.WriteLine("Boa noite, " + nome + ".");
            }
            else
            {
                Console.WriteLine("Bom dia, " + nome + ".");
            }
        }

        public void SaudacaoEmIngles(string nome, int time)
        {
            if (time >= 12 && time < 18)
            {
                Console.WriteLine("Good afternoon, " + nome + ".");
            }
            else if (time >= 18)
            {
                Console.WriteLine("Good evening, " + nome + ".");
            }
            else
            {
                Console.WriteLine("Good morning, " + nome + ".");
            }
        }

        public void SaudacaoEmEspanhol(string nome, int time)
        {
            if (time >= 12 && time < 18)
            {
                Console.WriteLine("Buena tarde, " + nome + ".");
            }
            else if (time >= 18)
            {
                Console.WriteLine("Buenas noches, " + nome + ".");
            }
            else
            {
                Console.WriteLine("Buenos días, " + nome + ".");
            }
        }

        public void SaudacaoEmFrances(string nome, int time)
        {
            if (time >= 12 && time < 18)
            {
                Console.WriteLine("Bon après-midi, " + nome + ".");
            }
            else if (time >= 18)
            {
                Console.WriteLine("Bonsoir, " + nome + ".");
            }
            else
            {
                Console.WriteLine("Bonjour, " + nome + ".");
            }
        }
    }
}
