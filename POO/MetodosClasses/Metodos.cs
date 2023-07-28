using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosClasses
{
    internal class Metodos
    {
        //metodo simples sem retorno
        public void Comprimentar()
        {
            Console.WriteLine("Ola seja bem vindo!");
        }

        //metodos com parametros 
        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("A soma é: "+resultado);
        }

        public void Apresentar (string nome, int idade)
        {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos");
        }

        //passagem de parâmetros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor) é: " + valor);
        }

        //passagem de parâmetros por referência
        public void AumentarRef(ref int valor) // referencia a variavel tudo que for feito referente a uma variavel vai afetar a variavel original
        {
            valor += 10;
            Console.WriteLine("Valor final (por referencia) é: " + valor);
        }

        //metodos com retorno de valores
        public string MontaNome(string nome, string sobrenome)
        {
            //string nomeCompleto = nome +" "+ sobrenome;
            //return nomeCompleto;

            return nome + " " + sobrenome;
        }

        public int CodigoChar(char caractere)
        {
            //int codigo = (int)caractere; 
            //return codigo;

            return caractere;
        }

        public double ValorPI()
        {
            return 3.1415;
        }
    }
}
