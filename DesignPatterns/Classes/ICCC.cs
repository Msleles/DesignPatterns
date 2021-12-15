using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    public class ICCC : IImpostos
    {
        public double Calcula(Orcamento orcamento)
        {
            double orc = orcamento.Valor;
            if (orc < 1000)
            {
                return orc * 0.05;
            }
            else if (orc >= 1000 && orc <= 3000)
            {
                return orc * 0.07;
            }
            else
               {
                return orc * (0.08 + 30);
              }
        }
    }
}
