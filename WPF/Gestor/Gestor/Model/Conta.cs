using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Model
{
    public class Conta
    {
        public long Id { get; set; }
        public decimal Saldo { get; set; }
        public bool Regra { get; set; } //True=Positivo False=Negativo

        public Conta CriaConta(decimal valor) => new Conta { Saldo = valor, Regra = valor > 0 };
    }
}
