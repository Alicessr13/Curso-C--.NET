using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Pessoa
    {
        //atributos ou campos da classe
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        //metodo simples sem retorno
        public void Comprimentar()
        {
            Console.WriteLine("Ola eu sou "+nome+" "+sobrenome);
        }
    }
}
