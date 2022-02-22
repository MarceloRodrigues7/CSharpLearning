using ControleHoras.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleHoras.Context
{
    public class EntityFactory : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(connectionsString);

        public DbSet<Dia> Dias { get; set; }
    }
}
