using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcImposto_Strategy
{
    public class ICCC : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor switch
            {
                double v when (v >= 3000) => (orcamento.Valor * 0.08) + 30,
                double v when (v < 3000 & v >= 1000) => orcamento.Valor * 0.07,
                double v when (v < 1000) => orcamento.Valor * 0.05,
                _ => 0,
            };
        }
    }
}
