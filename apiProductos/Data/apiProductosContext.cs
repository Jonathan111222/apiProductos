using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apiProductos.Model;

namespace apiProductos.Data
{
    public class apiProductosContext : DbContext
    {
        public apiProductosContext (DbContextOptions<apiProductosContext> options)
            : base(options)
        {
        }

        public DbSet<apiProductos.Model.Productos> Productos { get; set; }
    }
}
