using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatica
{
     internal partial class Pessoa //a mesma classe só que em arquivos diferentes para organizar melhor
    {
        public void Apresentar()
        {
            Console.WriteLine("Ola eu sou " + nome); //tem acesso aos atributos da classe pessoa
        }

        public static int CalcularIdade(int anoNasc) //não precisar instanciar a classe para utilizar
        {
            return DateTime.Now.Year - anoNasc;
        }
    }
}
