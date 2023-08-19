using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatica
{
    internal class Pessoa
    {
        public static int maioridade = 18; //membro estatico, vale para todo o programa

        public string nome; //cada objeto possui o seu 

        public int idade;

        public void Apresentar()
        {
            Console.WriteLine("Ola eu sou " + nome);
        }

        public static int CalcularIdade(int anoNasc) //não precisar instanciar a classe para utilizar
        {
            return DateTime.Now.Year - anoNasc;
        }
    }
}
