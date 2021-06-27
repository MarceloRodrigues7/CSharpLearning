using Alura.LeilaoOnline.Core;
using System;

namespace Alura.LeilaoOnline.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            LeilaoComVariosLances();
            LeilaoComApensUmLance();
        }

        private static void LeilaoComVariosLances()
        {
            //Arrage
            var modalidade = new MaiorValor();
            var leilao = new Leilao("Van Gogh", modalidade);
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(fulano, 1000);
            leilao.RecebeLance(maria, 990);

            //Act
            leilao.TerminaPregao();

            //Assert
            var valorEsperado = 1000;
            var valorObtido = leilao.Ganhador.Valor;

            Verifica(valorEsperado, valorObtido);
        }

        private static void LeilaoComApensUmLance()
        {
            //Arrage
            var modalidade = new MaiorValor();
            var leilao = new Leilao("Van Gogh", modalidade);
            var fulano = new Interessada("Fulano", leilao);

            leilao.RecebeLance(fulano, 800);

            //Act
            leilao.TerminaPregao();

            //Assert
            var valorEsperado = 800;
            var valorObtido = leilao.Ganhador.Valor;
            Verifica(valorEsperado, valorObtido);
        }

        private static void Verifica(int valorEsperado, double valorObtido)
        {
            var padraoConsole = Console.ForegroundColor;
            if (valorEsperado == valorObtido)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("TESTE OK");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"TESTE FALHOU! esperado{valorEsperado}, obtido{valorObtido}");
            }
            Console.ForegroundColor = padraoConsole;
        }
    }
}
