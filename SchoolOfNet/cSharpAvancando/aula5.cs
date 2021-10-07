using System;

namespace cSharpAvancando
{
    class aula5
    {
        static void Metodo()
        {
            var dataTexto = "2021-01-01 00:12:45";
            var data = new DateTime(2020,04,02,08,30,0);
            System.Console.WriteLine(data);
            string dataFormatada = DateTime.Parse(dataTexto).ToString("HH:mm");
            System.Console.WriteLine(dataFormatada);
        }
    }
}