using System;
using System.Collections.Generic;
using System.Linq;

namespace SequenciaFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exibe sequência de Fibonacci!");
            Console.WriteLine("Informe o total a ser exibido:");
            var t = int.Parse(Console.ReadLine());
            var sequencia = SequenciaFibonacci(t);
            Console.WriteLine(sequencia);
        }

        private static string SequenciaFibonacci(int t)
        {
            List<int> list = new();
            var numero = 0;
            var ultimoN = 0;
            var penultimoN = 0;
            for (int i = 0; i < t; i++)
            {
                list.Add(numero);
                ultimoN = list.Last();
                if (list.Count >= 2)
                {
                    penultimoN = list[^2];
                }
                numero = ultimoN + penultimoN;

                if (numero == 0)
                    numero++;
            }
            var txtView = string.Empty;
            foreach (var item in list)
            {
                txtView += string.Concat(item, ";");
            }
            return txtView;
        }
    }
}
