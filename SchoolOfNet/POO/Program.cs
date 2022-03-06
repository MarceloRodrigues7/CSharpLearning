using System;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new();
            cc.SetAgencia(1029);
            Console.WriteLine(cc.Agencia);
            
            ContaPoupanca cp = new();

            Console.ReadKey();
        }
    }
}
