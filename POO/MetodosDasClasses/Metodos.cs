﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {
        #region Métodos Simples
        public void Cumprimentar()
        {
            Console.WriteLine("Ola, seja bem vindo.");
        }
        #endregion

        #region Métodos com parâmetros
        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("A soma é: " + resultado);
        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos");
        }
        #endregion

        #region Passagem de parâmetros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor) é: " + valor);
        }
        #endregion

        #region Passagem de parâmetros por referência
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por referência) é: " + valor);
        }
        #endregion

        #region Métodos com retorno de valores
        public string MontaNome(string nome, string sobrenome)
        {
            string nomeCompleto = nome + " " + sobrenome;
            return nomeCompleto;
        }

        public int CodigoChar(char caractere)
        {
            //int codigo = (int)caractere;
            return caractere;
        }

        public double ValorPI()
        {
            return 3.1415;
        }
        #endregion

        #region Sobrecarga de metodos
        public void Cumprimentar(string nome)
        {
            Console.WriteLine("Ola " + nome);
        }

        public void Cumprimentar(string nome, int hora)
        {
            string mensagem = hora < 12 ? "Bom dia " + nome : "Boa tarde " + nome;
            Console.WriteLine(mensagem);
        }

        public bool Comparar(int num1, int num2)
        {
            return num1 == num2;
        }
        
        public bool Comparar(string txt1, string txt2)
        {
            return txt1 == txt2;
        }
        #endregion
    }
}
