using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPress
{
    public class Conversao
    {
        public decimal ConverteTextoParaDecimal(string texto) => decimal.Parse(texto);

        public bool ValidaTextoDecimal(string texto) => decimal.TryParse(texto, out decimal val);
    }
}
