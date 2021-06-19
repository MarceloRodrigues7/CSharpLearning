using cerficacao_csharp_pt2.Aula6___Cast_de_Tipos.Operadores_IS_e_AS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerficacao_csharp_pt2.Aula6___Cast_de_Tipos.ConversoesImplicitas
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
            IAnimal ianimal = (IAnimal)gato;
            Console.WriteLine(ianimal.GetType());
            //gato = animal;
        }
    }
}
