using System;

namespace RealEmCentavo
{
    class Program
    {
        static void Main(string[] args)
        {
            var loop = true;
            StartConsole();
            // Qualquer formato alem de numero encerra loop
            while (loop == true)
            {
                Console.WriteLine("Infome o valor:");
                try
                {
                    var input = Console.ReadLine().ToString().Replace(".", ",");
                    var valor = decimal.Parse(input) * 100;
                    var centavos = (int)valor;

                    Console.WriteLine($"Real: {input}  Centavos: {centavos}");
                    Console.WriteLine();

                    var _50Centavos = centavos / 50;
                    Console.WriteLine($"Moedas de 50 centavos: {_50Centavos}");
                    var resto = centavos % 50;

                    var _25Centavos = resto / 25;
                    Console.WriteLine($"Moedas de 25 centavos: {_25Centavos}");
                    resto = resto % 25;

                    var _10Centavos = resto / 10;
                    Console.WriteLine($"Moedas de 10 centavos: {_10Centavos}");
                    resto = resto % 10;

                    var _5Centavos = resto / 5;
                    Console.WriteLine($"Moedas de 5 centavos: {_5Centavos}");
                    resto = resto % 5;

                    var _1Centavos = resto;
                    Console.WriteLine($"Moedas de 1 centavos: {_1Centavos}");
                    Console.WriteLine();
                }
                catch (FormatException) 
                {
                    loop = false;
                }
            }
            Console.WriteLine("Finalizando conversor.");
        }

        private static void StartConsole()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("- Iniciando Conversor -");
            Console.WriteLine("- Real para Centavos  -");
            Console.WriteLine("-----------------------");
        }
    }
}
