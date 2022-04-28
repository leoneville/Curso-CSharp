using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "### Média Geral dos Alunos ###";

            Console.Write("Quantidade de alunos: ");
            int nAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] alunos = new Aluno[nAlunos];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write("Nome do {0}º Aluno: ", i+1);
                string nome = Console.ReadLine();

                Console.Write("Quantidade de provas do aluno {0}: ", nome);
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                Console.WriteLine("\n\nInsira as notas do aluno {0}", nome);
                alunos[i].InserirNotas();
            }

            Console.Clear();

            double mediaGeral = 0;

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("Aluno: {0}", aluno.Nome);
                Console.WriteLine("Média: {0}", aluno.Media);
                Console.WriteLine();
                
                mediaGeral += aluno.Media;
            }

            double resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine("\nMédia geral dos alunos: {0}", resultadoFinal.ToString("F2"));

            Console.ReadKey();
        }
    }
}
