using System;

namespace RetornaTroco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor compra:");
            var valorCompra = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor nota:");
            var valorNota = decimal.Parse(Console.ReadLine());

            var textoValorNota = new Moedas().RetornaTroco(valorNota);
            Console.WriteLine($"Foi pago com: {textoValorNota}");

            var textoTroco = new Moedas().RetornaTroco(valorNota - valorCompra);
            Console.WriteLine($"*Troco*{Environment.NewLine}{textoTroco}");
        }
    }
}
