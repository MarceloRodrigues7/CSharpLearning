using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_pt3
{
    class Propriedades_e_Acessadores
    {
        public static void Teste()
        {
            Funcionario funcionario = new Funcionario
            {

                //funcionario.salario = 1000;
                //Console.WriteLine(funcionario.salario);
                //funcionario.salario = -1200;
                //Console.WriteLine(funcionario.salario);

                //funcionario.Salario = -1200;

                Salario = 1200
            };

            Console.WriteLine(funcionario.Salario);

            Console.ReadKey();
        }

        class Funcionario
        {
            decimal salario;

            public decimal Salario // encapsulamento do campo salario
            {
                get
                {
                    return salario;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("salario não pode ser negativo");
                    }
                    salario = value;
                }
            }
        }
    }
}
