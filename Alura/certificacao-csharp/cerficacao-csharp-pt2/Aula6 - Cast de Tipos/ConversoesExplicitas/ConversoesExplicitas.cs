using cerficacao_csharp_pt2.Aula6___Cast_de_Tipos.Operadores_IS_e_AS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerficacao_csharp_pt2.Aula6___Cast_de_Tipos.ConversoesExplicitas
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
