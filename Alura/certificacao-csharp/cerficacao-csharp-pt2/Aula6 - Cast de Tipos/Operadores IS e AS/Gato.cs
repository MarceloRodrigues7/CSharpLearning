using System;

namespace cerficacao_csharp_pt2.Aula6___Cast_de_Tipos.Operadores_IS_e_AS
{
    internal class Gato
    {
        public static explicit operator Gato(Animal v)
        {
            throw new NotImplementedException();
        }
    }
}