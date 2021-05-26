using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraTunes
{
    class LinqToEntity2
    {
        public void Teste()
        {
            using (var contexto = new AluraTunesEntities)
            {
                var textoBusca = "Led";

                var query = from a in contexto.Artistas
                            join alb in contexto.Albuns
                                on a.ArtistaId equals alb.ArtistaId
                            where a.Nome.Contains(textoBusca)
                            select new
                            {
                                NomeArtista = a.Nome,
                                NomeAlbum = alb.Titulo
                            };
                foreach (var item in query)
                {
                    Console.WriteLine("{0}\t{1}", item.NomeArtista, item.NomeAlbum);
                }

                var query2 = contexto.Artitas.Wher(a => a.Nome.Contains(textoBusca));
                Console.WriteLine();
                foreach (var item in query2)
                {
                    Console.WriteLine("{0}\t{1}", item.ArtistaId, item.Nome);
                }

                var query3 = from alb in contexto.Albuns
                             where alb.Artista.Nome.Constains(textoBusca)
                             select new
                             {
                                 NomeArtista = alb.Artista.Nome,
                                 NomeAlbum = alb.Titulo
                             };
                Console.WriteLine();
                foreach (var item in query3)
                {
                    Console.WriteLine("{0}\t{1}", item.ArtistaId, item.Nome);
                }
            }
        }
    }
}
