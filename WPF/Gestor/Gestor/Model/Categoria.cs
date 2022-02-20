using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Model
{
    public class Categoria
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public bool? Regra { get; set; } //True=Receita False=Despesa Null=Ambos

        public Categoria CriaObj(string descricao, object categoriaSelecionada)
        {
            var regra = ConverteObjParaEnum(categoriaSelecionada);
            Descricao = descricao;
            Regra = ValidaRegraCategoria(regra);
            return this;
        }

        private bool? ValidaRegraCategoria(RegraCategoria regra)
        {
            switch (regra)
            {
                case RegraCategoria.Receita:
                    return true;
                case RegraCategoria.Despesa:
                    return false;
                default:
                    return null;
            }
        }

        private RegraCategoria ConverteObjParaEnum(object value)
        {
            if (value.ToString() == RegraCategoria.Despesa.ToString())
            {
                return RegraCategoria.Despesa;
            }
            else if (value.ToString() == RegraCategoria.Receita.ToString())
            {
                return RegraCategoria.Receita;
            }
            else
            {
                return RegraCategoria.Ambos;
            }
        }
    }
}
