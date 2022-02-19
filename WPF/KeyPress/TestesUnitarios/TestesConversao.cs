using KeyPress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace TestesUnitarios
{
    public class TestesConversao
    {
        private Conversao conversao = new();

        [Fact]
        public void ConverteTextoParaDecimal()
        {
            string texto = "10";
            var teste = 10;

            decimal result = conversao.ConverteTextoParaDecimal(texto);

            Assert.Equal(teste, result);
        }

        [Fact]
        public void ValidaTextoDecimal()
        {
            string textoUm = "10";
            string textoDois = "abc";

            var resultUm = conversao.ValidaTextoDecimal(textoUm);
            var resultDois = conversao.ValidaTextoDecimal(textoDois);
            
            Assert.True(resultUm);
            Assert.False(resultDois);
        }
    }
}
