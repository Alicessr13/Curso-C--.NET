using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Carro : Veiculo // : significa herança em c#
    {
        public int VelocidadeMaxima { get; set; }

        public void LigarMotor()
        {
            Console.WriteLine("Motor ligado");
        }

        public override void Acelerar()  //troca o abstract pr override, sobreescreve o metodo abstrato 
        {
            Console.WriteLine("Acelerou o carro");
        }
    }
}
