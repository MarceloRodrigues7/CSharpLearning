using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerficacao_csharp_pt2.Aula8___Lidar_com_tipos_dinâmicos.string__var__object_e_dynamic
{
    class stringVarObjectEDynamic : IAulaItem
    {
        public void Executar()
        {
            //tipo é definido na compilação
            string s = "Certificação c#";
            //tipo é definido na compilação (por inferência)
            var v = "Certificação c#";
            //tipo é definido na compilação
            object o = "Certificação c#";

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);

            s = s.ToUpper();
            v = v.ToUpper();
            o = ((string)o).ToUpper();

            Console.WriteLine(o);
            Console.WriteLine(v);
            Console.WriteLine(o);

            //s = 123;
            //v = 123;
            o = 123;

            o = (int)o + 4;
            Console.WriteLine(o);

            //tipo é definido em tempo de execução
            dynamic d = "Certificação c#";
            Console.WriteLine(d);
            d = d.ToUpper();
            Console.WriteLine(d);
            d = 123;
            Console.WriteLine(d);
            d += 4;
            Console.WriteLine(d);
        }
    }
}
