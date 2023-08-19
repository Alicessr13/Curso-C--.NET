using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatica
{
    internal partial class Pessoa //a mesma classe pessoa só que em arquivos diferentes para organizar melhor
    {
        public static int maioridade = 18; //membro estatico, vale para todo o programa

        public string nome; //cada objeto possui o seu 

        public int idade;

        
    }
}
