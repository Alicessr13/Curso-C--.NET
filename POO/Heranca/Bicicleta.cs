using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Bicicleta : Veiculo // : significa herança em c#
    {

        public void Pedalar()
        {

        }

        public override void Acelerar()  //troca o abstract pr override, sobreescreve o metodo abstrato 
        {
            Console.WriteLine("Acelerou a bicicleta");
        }
    }
}
