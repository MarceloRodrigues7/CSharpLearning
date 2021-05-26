using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraTunes
{
    class LinqToEntity
    {
        public void Teste() {
            using (var contexto = new AluraTunesEntities())
            {
                var query = from g in contexto.Generos
                            select g;

                foreach (var genero in query)
                {
                    Console.WriteLine("{0}\t{1}", genero.GeneroId, genero.Nome);
                }

                var faixaEGenero = from g in contexto.Generos
                                   join f in contexto.Faixas
                                    on g.GeneroId equals f.GeneroId
                                   select new { f, g };
                faixaEGenero = faixaEGenero.Take(10);

                contexto.DataBase.Log = Console.WriteLine();

                foreach (var item in faixaEGenero)
                {
                    Console.WriteLine("{0}\t{1}", item.f.Nome, item.g.Nome);
                }
            }
        }
    }
}
