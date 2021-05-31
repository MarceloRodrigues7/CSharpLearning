using certificacao_csharp_roteiro.antes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.Aula6___Cast_de_Tipos.ConversoesImplicitas
{
    class ConversoesImplicitas
    {
        public void teste()
        {
            int numero = 2_123_456_789;
            long inteiroLongo = numero;
            Console.WriteLine(inteiroLongo);

            //numero = inteiroLongo;

            Gato gato = new Gato();
            Animal animal = gato;
            Console.WriteLine(animal.GetType());
            IAnimal ianimal = gato;
            Console.WriteLine(ianimal.GetType());
            //gato = animal;
        }
    }
}
