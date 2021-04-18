using System;
using System.Linq;


namespace Bin2Dec_Convert
{
    static class Program
    {
        static void Main()
        {
            int calculo = 0;
            Conversor convert = new Conversor();
            string valor = null;

            Console.WriteLine("Iniciando conversor binario para decimal! (para finalizar digite x)");

            //Condição Loop
            while (valor != "x")
            {
                Console.WriteLine("Informe o numero binário:");
                valor = Console.ReadLine();
            
                //Validação
                if(valor == "x")
                {
                    Console.WriteLine($"Finalizando... Calculos:{calculo}");
                }
                else
                {
                    //Calculo
                    float result = convert.binInDec(valor);
                    Console.WriteLine($"Numero Binario: {valor}. Resultado Decimal: {result}");
                    calculo++;
                }
            }
        }
    }
}
