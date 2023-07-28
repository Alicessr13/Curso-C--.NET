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
    }
}
