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
    }
}
