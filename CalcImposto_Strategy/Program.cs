using System;

namespace CalcImposto_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            IImposto iccc = new ICCC();
            Orcamento orcamento = new(500.0);
            CalculadorDeImpostos calculador = new();

            // Calculando o ISS
            calculador.RealizaCalculo(orcamento, iss);

            // Calculando o ICMS        
            calculador.RealizaCalculo(orcamento, icms);

            // Calculando o ICCC
            calculador.RealizaCalculo(orcamento, iccc);
        }
    }
}
