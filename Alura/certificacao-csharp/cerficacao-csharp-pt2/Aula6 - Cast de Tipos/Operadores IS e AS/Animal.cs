using System;

namespace cerficacao_csharp_pt2.Aula6___Cast_de_Tipos.Operadores_IS_e_AS
{
    internal class Animal
    {
        internal void Beber()
        {
            throw new NotImplementedException();
        }

        internal void Comer()
        {
            throw new NotImplementedException();
        }

        public static implicit operator Animal(Gato v)
        {
            throw new NotImplementedException();
        }
    }
}