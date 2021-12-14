using DesignPatterns.Classes;
using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
   public class CalculadorDeImpostos
    {

        public void  RealizaCalculo(Orcamento orcamento , IImpostos imposto)
        {
            double imp = imposto.Calcula(orcamento);
            Console.WriteLine(imp);
        }
    }
}
