using System;

namespace cSharpAvancando
{
    class aula1
    {
        static void Metodo()
        {
            string frase = "Hoje é sexta-feita, dia de comemorar!";

            System.Console.WriteLine(frase.ToUpper());
            System.Console.WriteLine(frase.ToLower());

            var frase_trocada = frase.Replace("dia","hora");
            System.Console.WriteLine(frase_trocada);

            string subFrase = "sexta";
            System.Console.WriteLine(frase.Length);
            System.Console.WriteLine(frase.Contains(subFrase));

            var posInicial = frase.IndexOf(subFrase);
            var posFinal = posInicial+10;
            var sub = frase.Substring(posInicial,posFinal);
            System.Console.WriteLine(sub);

            var partes = frase.Split(",");
            for(var i=0;i<partes.Length;i++){
                System.Console.WriteLine(partes[i]);
            }
        }
    }
}
