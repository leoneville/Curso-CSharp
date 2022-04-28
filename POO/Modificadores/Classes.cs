using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    internal class Teste
    {
        private string nome;
        public string sobrenome;

        private void Metodo1() { }
        public void Executar() { }
    }

    class Humano
    {
        protected string nome; // fica disponivel pra classe declarada e pra que foi herdada
        private string sobrenome; //particular da classe em que foi declarada
        internal int idade; //somente está acessivel dentro deste programa, sendo impossibilitado de ser usado em outro... dll
    }

    class Homem : Humano
    {
        public void Metodo()
        {
            nome = "";
            idade = 0;
        }
    }
}
