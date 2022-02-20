using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Model
{
    public class Transacao
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public long IdCategoria { get; set; }
        public decimal Valor { get; set; }
        public long IdTipo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataPagamento { get; set; }
        public long IdStatus { get; set; }

        public Categoria Categoria { get; set; }
        public Tipo Tipo { get; set; }
        public Status Status { get; set; }
    }
}
