﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Matematica
    {
        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtração(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
