using KeyPress;
using System;
using Xunit;

namespace TestesUnitarios
{
    public class TesteCalculo
    {
        private Calculo calculo = new();

        [Fact]
        public void Adicao()
        {
            decimal valorUm = 5;
            decimal valorDois = 10;
            
            decimal teste = valorUm + valorDois;
            decimal result = calculo.Adicao(valorUm, valorDois);

            Assert.Equal(teste, result);
        }

        [Fact]
        public void Subtracao()
        {
            decimal valorUm = 5;
            decimal valorDois = 10;

            decimal teste = valorUm - valorDois;
            decimal result = calculo.Subtracao(valorUm, valorDois);

            Assert.Equal(teste, result);
        }

        [Fact]
        public void Multiplicacao()
        {
            decimal valorUm = 5;
            decimal valorDois = 10;

            decimal teste = valorUm * valorDois;
            decimal result = calculo.Multiplicacao(valorUm, valorDois);

            Assert.Equal(teste, result);
        }

        [Fact]
        public void Divisao()
        {
            decimal valorUm = 5;
            decimal valorDois = 10;

            decimal teste = valorUm / valorDois;
            decimal result = calculo.Divisao(valorUm, valorDois);

            Assert.Equal(teste, result);
        }
    }
}
