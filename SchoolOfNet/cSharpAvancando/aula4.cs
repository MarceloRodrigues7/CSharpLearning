using System;

namespace cSharpAvancando
{
    class aula4
    {
        static void Metodo()
        {
            System.Console.WriteLine("{1}", DateTime.Now);
            System.Console.WriteLine("{1}", DateTime.Now.AddDays(2));
            System.Console.WriteLine("{1}", DateTime.Now.AddMinutes(-2));
        }
    }
}
