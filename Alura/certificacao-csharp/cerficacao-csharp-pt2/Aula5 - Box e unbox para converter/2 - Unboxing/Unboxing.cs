﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerficacao_csharp_pt2.Aula5___box_unbox_para_converter._2___Unboxing
{
    class Unboxing
    {
        public void teste()
        {
            int numero = 57;
            object caixa = numero;
            try
            {
                int unboxed = (int)caixa;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
