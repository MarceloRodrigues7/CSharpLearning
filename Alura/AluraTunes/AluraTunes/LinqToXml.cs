using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AluraTunes
{
    class LinqToXml
    {
        public void Teste()
        {
            XElement root = XElement.Load("Automoveis.xml");

            var queryXML = from g in root.Element("Generos").Elements("Genero") select g;

            foreach (var genero in queryXML)
            {
                Console.WriteLine("{0}\t{1}", genero.Element("GeneroId").Value, genero.Element("Nome").Value);
            }

            var query = from g in root.Element("Generos").Elements("Genero")
                        join m in root.Element("Musicas").Elements("Musica")
                            on g.Element("GeneroId").Value equals m.Element("GeneroId").Value
                        select new
                        {
                            Musica = m.Element("Nome").Value,
                            Genero = g.Element("Nome").Value
                        };
            Console.WriteLine();
            foreach (var musicaGenero in query)
            {
                Console.WriteLine("{0}\t{1}", musicaGenero.Musica, musicaGenero.Genero);
            }
        }
    }
}
