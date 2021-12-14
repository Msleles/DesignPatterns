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

            //Instamciando a classe de Orçamento com valor total de R$ 500,00
            Orcamento orcamento = new Orcamento(500);

            CalculadorDeImpostos calcula = new CalculadorDeImpostos();

          

            calcula.RealizaCalculo(orcamento, iss);
            calcula.RealizaCalculo(orcamento, iCMS);

            Console.ReadKey();
        }
    }
}
