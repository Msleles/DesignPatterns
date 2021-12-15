using DesignPatterns.Classes;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)

        {
            // Instanciado as classes de impostos (ISS,ICMS)
            ISS iss = new ISS();
            ICMS iCMS = new ICMS();
            ICCC iCCC = new ICCC();

            //Instamciando a classe de Orçamento com valor total de R$ 500,00
            Orcamento orcamento = new Orcamento(50);
            Orcamento orcamento1 = new Orcamento(4000);

            CalculadorDeImpostos calcula = new CalculadorDeImpostos();

          

            calcula.RealizaCalculo(orcamento, iss);
            calcula.RealizaCalculo(orcamento, iCMS);


            
            calcula.RealizaCalculo(orcamento1, iCCC);

            Console.ReadKey();
        }
    }
}
