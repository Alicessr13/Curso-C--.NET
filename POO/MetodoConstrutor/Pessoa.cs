using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    internal class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int anoNasc;
        public int idade;

        public Pessoa() //colocamos dentro do construtor tudo que queremos que seja executado ao instanciar a classe
        {
            nome = "Desconhecido";
            sobrenome = "Nenhum";
            anoNasc = 0;
            idade = 0;
        }

        public Pessoa(string nome, string sobrenome, int anoNasc)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoNasc = anoNasc;
            idade = Idade();
        }

        private int Idade ()
        {
            return 2023 - anoNasc;
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoNasc = 2002; 
            idade = Idade();
        }
    }
}
