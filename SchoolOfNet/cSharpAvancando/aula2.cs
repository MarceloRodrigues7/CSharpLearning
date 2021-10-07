using System;

namespace cSharpAvancando
{
    class aula2
    {
        static void Metodo()
        {
            var nome = "Marcelo";
            var idade = 23;
            var rendimento = 8000m;
            var dataCadastro = new DateTime(2000,01,01);
            
            string str="o cliente {0} tem {1} anos de idade e tem rendimento de {2:c}";
            str+=" e é cliente desde {3:dd/MM/yyyy}";
            string frase = String.Format(str,nome,idade,rendimento,dataCadastro);
            System.Console.WriteLine(frase);
        }
    }
}
