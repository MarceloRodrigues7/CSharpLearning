using Gestor.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Context
{
    public class EntityFactory : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(connectionsString);

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }
    }
}
