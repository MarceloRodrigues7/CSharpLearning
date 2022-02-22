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
        private readonly string connectionsString = @"Data Source=143.244.190.244;Initial Catalog=ControleHoras;User ID='sa';Password='P@ssword';Connect Timeout=999899999";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(connectionsString);

        public DbSet<Dia> Dias { get; set; }
    }
}
