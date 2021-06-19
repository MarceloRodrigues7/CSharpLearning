using certificacao_csharp_roteiro.antes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.Aula6___Cast_de_Tipos.ConversoesExplicitas
{
    class ConversoesExplicitas
    {
        public void teste()
        {
            double divida = 1_234_567_890.132;
            //long copia = divida;

            double salario = 1_237.89;
            long copiaSalario = (long)salario;
            Console.WriteLine(copiaSalario);

            Animal animal = new Gato();
            Gato gato = (Gato)animal; //cast = conversão explicita
            Console.WriteLine(gato.GetType());

        }
    }
}
