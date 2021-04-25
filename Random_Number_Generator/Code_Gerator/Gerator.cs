using Code_Gerator.Models;
using System;

namespace Code_Gerator
{
    public class Gerator
    {
        static Random random = new();

        public static int Valor_Int(decimal minimo, decimal maximo)
        {
            return random.Next((int)minimo, (int)maximo);
        }

        public static decimal Valida_Decimal(int res, byte resp)
        {
            if (resp == 1)
            {
                var r = random.NextDouble();
                var v = $"{res},{r.ToString().Substring(2, 2)}";
                return decimal.Parse(v);
            }
            else
            {
                return res;
            }
        }

        public static decimal Valida_Negativo(decimal minimo, byte resp)
        {
            if (resp == 1)
            {
                minimo = Valor_Negativo(minimo);
                return minimo;
            }
            else
            {
                minimo = Valor_Negativo_Remove(minimo);
                return minimo;
            }
        }

        public static decimal Valor_Negativo_Remove(decimal minimo)
        {
            if (minimo.ToString().Substring(0, 1) == "-")
            {
                var novoValor = $"{minimo.ToString().Replace("-","")}";
                minimo = decimal.Parse(novoValor);
            }
            return minimo;
        }

        public static decimal Valor_Negativo(decimal minimo)
        {
            if (minimo.ToString().Substring(0, 1) != "-")
            {
                var novoValor = $"-{minimo}";
                minimo = decimal.Parse(novoValor);
            }
            return minimo;
        }

        public static Valores Valida_Valores(Valores v)
        {
            if (v.Minimo > v.Maximo)
            {
                var t_min = v.Minimo;
                var t_max = v.Maximo;
                v.Minimo = t_max;
                v.Maximo = t_min;
                v.Trocado = 1;
            }
            return v;
        }
    }
}
