﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Carro : Veiculo 
    {
        public int VelocidadeMaxima { get; set; }

        public void LigarMotos()
        {
            Console.WriteLine("Motor ligado");
        }

        
    }
}
