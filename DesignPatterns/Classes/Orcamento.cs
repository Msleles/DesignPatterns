﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    public class Orcamento
    {
        public double Valor { get; private set; }


        public Orcamento(double valor)
        {
            this.Valor = valor;
        }
    }
}
