using BindingWpf.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingWpf.Database
{
    public class Ado:DbContext
    {
        private readonly string _connectionString = $"Server=ACER;Database=wpftestes;User Id=sa;Password=p@ssword;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(_connectionString);

        public DbSet<Person> Persons { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
