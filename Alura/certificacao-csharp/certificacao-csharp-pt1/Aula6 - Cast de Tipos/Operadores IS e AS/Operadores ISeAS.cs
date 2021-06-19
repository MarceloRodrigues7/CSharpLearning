using certificacao_csharp_roteiro.antes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.Aula6___Cast_de_Tipos.Operadores_IS_e_AS
{
    class Operadores_ISeAS
    {
        public void Executar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            Cliente cliente = new Cliente("José da Silva", 30);

            Alimentar(animal);
            Alimentar(gato);
            Alimentar(cliente);

        }

        public void Alimentar(object obj)
        {
            //var animas = obj as Animal; s->obj & n->null
            if(obj is Animal animal)
            {
                animal.Beber();
                animal.Comer();
                return;
            }
            Console.WriteLine("obj não é um animal");
        }
    }
}
