using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetornaTroco
{
    public class Moedas
    {
        public string Texto { get; set; }
        public decimal Valor { get; set; }

        public class UmCentavo
        {
            public const decimal Valor = 0.01m;
            public const string Nome = "moeda de 1 centavo";
        }
        public class CincoCentavos
        {
            public const decimal Valor = 0.05m;
            public const string Nome = "moeda de 5 centavos";
        }
        public class DezCentavos
        {
            public const decimal Valor = 0.1m;
            public const string Nome = "moeda de 10 centavos";
        }
        public class VinteECintoCentavos
        {
            public const decimal Valor = 0.25m;
            public const string Nome = "moeda de 25 centavos";
        }
        public class CinquentaCentavos
        {
            public const decimal Valor = 0.5m;
            public const string Nome = "moeda de 50 centavos";
        }
        public class UmReal
        {
            public const decimal Valor = 1m;
            public const string Nome = "moeda de 1 real";
        }
        public class CincoReais
        {
            public const decimal Valor = 5m;
            public const string Nome = "nota de 5 reais";
        }
        public class DezReais
        {
            public const decimal Valor = 10m;
            public const string Nome = "nota de 10 reais";
        }
        public class VinteReais
        {
            public const decimal Valor = 20m;
            public const string Nome = "nota de 20 reais";
        }
        public class CinquentaReais
        {
            public const decimal Valor = 50m;
            public const string Nome = "nota de 50 reais";
        }
        public class CemReais
        {
            public const decimal Valor = 100m;
            public const string Nome = "nota de 100 reais";
        }

        public string RetornaTroco(decimal valor)
        {
            var texto = string.Empty;

            if (valor >= CemReais.Valor)
            {
                var moeda = new Moedas { Texto = CemReais.Nome, Valor = CemReais.Valor };
                var data = CalculaValor(valor, moeda);
                texto += data.Texto + Environment.NewLine;
                valor = data.Valor;
            }
            if (valor >= CinquentaReais.Valor)
            {
                var moeda = new Moedas { Texto = CinquentaReais.Nome, Valor = CinquentaReais.Valor };
                var data = CalculaValor(valor, moeda);
                texto += data.Texto + Environment.NewLine;
                valor = data.Valor;
            }
            if (valor >= VinteReais.Valor)
            {
                var moeda = new Moedas { Texto = VinteReais.Nome, Valor = VinteReais.Valor };
                var data = CalculaValor(valor, moeda);
                texto += data.Texto + Environment.NewLine;
                valor = data.Valor;
            }
            if (valor >= DezReais.Valor)
            {
                var moeda = new Moedas { Texto = DezReais.Nome, Valor = DezReais.Valor };
                var data = CalculaValor(valor, moeda);
                texto += data.Texto + Environment.NewLine;
                valor = data.Valor;
            }
            if (valor >= CincoReais.Valor)
            {
                var moeda = new Moedas { Texto = CincoReais.Nome, Valor = CincoReais.Valor };
                var data = CalculaValor(valor, moeda);
                texto += data.Texto + Environment.NewLine;
                valor = data.Valor;
            }
            if (valor >= UmReal.Valor)
            {
                var moeda = new Moedas { Texto = UmReal.Nome, Valor = UmReal.Valor };
                var data = CalculaValor(valor, moeda);
                texto += data.Texto + Environment.NewLine;
                valor = data.Valor;
            }
            if (valor >= CinquentaCentavos.Valor)
            {
                var moeda = new Moedas { Texto = CinquentaCentavos.Nome, Valor = CinquentaCentavos.Valor };
                var data = CalculaValor(valor, moeda);
                texto += data.Texto + Environment.NewLine;
                valor = data.Valor;
            }
            if (valor >= VinteECintoCentavos.Valor)
            {
                var moeda = new Moedas { Texto = VinteECintoCentavos.Nome, Valor = VinteECintoCentavos.Valor };
                var data = CalculaValor(valor, moeda);
                texto += data.Texto + Environment.NewLine;
                valor = data.Valor;
            }
            if (valor >= DezCentavos.Valor)
            {
                var moeda = new Moedas { Texto = DezCentavos.Nome, Valor = DezCentavos.Valor };
                var data = CalculaValor(valor, moeda);
                texto += data.Texto + Environment.NewLine;
                valor = data.Valor;
            }
            if (valor >= CincoCentavos.Valor)
            {
                var moeda = new Moedas { Texto = CincoCentavos.Nome, Valor = CincoCentavos.Valor };
                var data = CalculaValor(valor, moeda);
                texto += data.Texto + Environment.NewLine;
                valor = data.Valor;
            }
            if (valor >= UmCentavo.Valor)
            {
                var moeda = new Moedas { Texto = UmCentavo.Nome, Valor = UmCentavo.Valor };
                var data = CalculaValor(valor, moeda);
                texto += data.Texto + Environment.NewLine;
                valor = data.Valor;
            }
            return texto;
        }

        public Moedas CalculaValor(decimal valor, Moedas moeda)
        {
            var texto = string.Empty;
            var qtd = (int)(valor / moeda.Valor);
            if (qtd > 1)
            {
                texto += $"{qtd} {moeda.Texto.Replace("nota", "notas")}";
            }
            else
            {
                texto += $"{qtd} {moeda.Texto}";
            }
            valor -= moeda.Valor * qtd;

            return new Moedas
            {
                Texto = texto,
                Valor = valor
            };
        }

    }
}
