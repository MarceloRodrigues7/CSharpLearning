using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Alura.LeilaoOnline.Core;

namespace Alura.LeilaoOnline.Tests
{
    public class LeilaoRecebeOferta
    {
        [Fact]
        public void NaoAceitaProximoLanceDadoMesmoClienteRealizouUltimoLance()
        {
            //Arrage
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            leilao.IniciaPregao();
            leilao.RecebeLance(fulano, 800);

            leilao.TerminaPregao();

            leilao.RecebeLance(fulano, 1000);

            var qtdeEsperada = 1;
            var qtdeObtida = leilao.Lances.Count();
            Assert.Equal(qtdeEsperada, qtdeObtida);
        }



        [Theory]
        [InlineData(4, new double[] { 800, 900, 1000, 1100 })]
        [InlineData(2, new double[] { 800, 900 })]
        public void NaoPermiteNovosLancesDadoLeilaoFinalizado(int qtdeEsperada, double[] ofertas)
        {
            //Arrage
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);
            leilao.IniciaPregao();

            for(int i = 0; i < ofertas.Length; i++)
            {
                var valor = ofertas[i];
                if ((i%2)==0)
                {
                    leilao.RecebeLance(fulano, valor);
                }
                else
                {
                    leilao.RecebeLance(maria, valor);
                }
            }
            leilao.TerminaPregao();

            //Act
            leilao.RecebeLance(fulano, 1000);

            //Assert
            var valorObtido = leilao.Lances.Count();

            Assert.Equal(qtdeEsperada, valorObtido);
        }

    }
}
