using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tienda.Domain.Models;

namespace tienda.Infrastructure.Persistence.Context
{
    public class TContext : DbContext
    {
        public TContext(DbContextOptions<TContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoDeseado> ProductosDeseados { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
