using Code_Gerator;
using Code_Gerator.Models;
using System;
using Xunit;

namespace Testes_Random_Number_Generator
{
    public class Testes
    {
        [Fact]
        public void Valor_Int()
        {
            var minimo = -1;
            var maximo = 10;
            var res = Gerator.Valor_Int(minimo, maximo);
            Assert.IsType<int>(res);
        }

        [Fact]
        public void Valida_Valores()
        {
            Valores v = new()
            {
                Minimo = 1123,
                Maximo = -10
            };
            var res = Gerator.Valida_Valores(v);
            Assert.Equal(-10, res.Minimo);
            Assert.Equal(1123, res.Maximo);
        }

        [Fact]
        public void ValidValor_Negativo_Remove()
        {
            var minimo = -10;
            var res = Gerator.Valor_Negativo_Remove(minimo);
            Assert.Equal(10, res);
        }

        [Fact]
        public void Valor_Negativo()
        {
            var minimo = 10;
            var res = Gerator.Valor_Negativo(minimo);
            Assert.Equal(-10, res);
        }

        [Fact]
        public void Valida_Decimal()
        {
            var valor = 12;
            byte resp = 1;
            var res = Gerator.Valida_Decimal(valor, resp);
            Assert.IsType<decimal>(res);
        }

        [Fact]
        public void Valida_Negativo()
        {
            var minimo = 10;
            byte resp = 1;
            var res = Gerator.Valida_Negativo(minimo, resp);

            var minimo2 = 10;
            byte resp2 = 0;
            var res2 = Gerator.Valida_Negativo(minimo2, resp2);

            Assert.Equal(-10, res);
            Assert.Equal(10, res2);
        }
    }
}
