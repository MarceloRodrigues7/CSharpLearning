using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace curso2.Database
{
    public class ContextEF : DbContext
    {
        public ContextEF(DbContextOptions<ContextEF> options) : base(options)
        {

        }
    }
}