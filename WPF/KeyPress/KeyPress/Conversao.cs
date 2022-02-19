using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPress
{
    public class Conversao
    {
        private readonly EnumOperadores _operadores;
        public decimal ConverteTextoParaDecimal(string texto) => decimal.Parse(texto);

        public bool ValidaTextoDecimal(string texto) => decimal.TryParse(texto, out decimal val);

        public EnumOperadores ConverteTextoParaOperador(string texto)
        {
            return texto switch
            {
                "+" => EnumOperadores.Somar,
                "-" => EnumOperadores.Subtrair,
                "*" => EnumOperadores.Multiplicar,
                "/" => EnumOperadores.Dividir,
                _ => EnumOperadores.Erro,
            };
        }
    }
}
