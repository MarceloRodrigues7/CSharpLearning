using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bin2Dec_Convert
{
    public class Conversor
    {
        public float binInDec(string numBin)
            {
                int expo = 0;
                int numero;
                float soma = 0;
                string numeroInvertido = StrReverse(numBin);

                for (int i = 0; i < numeroInvertido.Length; i++)
                {
                    numero = Convert.ToInt32(numeroInvertido.Substring(i, 1));
                    soma += numero * (int)Math.Pow(2, expo);
                    expo++;
                }
                return soma;
            }
        //function revert to string
        public static string StrReverse(string str)
            {
                return new string(str.Reverse().ToArray());
            }
    }
}
