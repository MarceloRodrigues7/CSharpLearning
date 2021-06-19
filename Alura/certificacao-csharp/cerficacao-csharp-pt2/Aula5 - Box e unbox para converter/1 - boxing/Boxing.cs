using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerficacao_csharp_pt2.Aula5___box_unbox_para_converter._1___boxing
{
    class Boxing
    {
        public void teste()
        {
            int numero = 57;
            object caixa = numero;
            Console.WriteLine(string.Concat("Resposta", numero, true));
        }
        
    }
}
