using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Model
{
    public class Tipo
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public bool Regra { get; set; } //True=Receita False=Despesa
    }
}
