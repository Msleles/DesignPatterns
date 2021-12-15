using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    public class ICMS : IImpostos
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.5;
        }
    }
}
