using System;
using System.Linq;

namespace AluraTunes
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new AluraTunesEntities())
            {
                GetFaixas(contexto, "Led Zeppelin", "");
                Console.WriteLine();
                GetFaixas(contexto, "Led Zeppelin", "Graffiti");
            }
        }

        private static void GetFaixas(AluraTunesEntities contexto, string BuscaArtista, string BuscaAlbum)
        {
            var query = from f in contexto.Faixas
                        where f.Album.Artista.Nome.Contains(BuscaArtista)
                        select f;
            
            if (!string.IsNullOrEmpty(BuscaAlbum))
            {
                query = query.Where(q => q.Album.Titulo.Contains(BuscaAlbum));
            }

            foreach (var faixa in query)
            {
                Console.WriteLine("{0}\t{1}", faixa.Album.Titulo, faixa.Nome);
            }
        }
    }
}
