using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tienda.Domain.Models;
using tienda.Infrastructure.Persistence.Config;

namespace tienda.Infrastructure.Persistence.Context
{
    public class TContext : DbContext
    {
        public TContext(DbContextOptions<TContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoDeseado> ProductosDeseados { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductoConfig());
            modelBuilder.ApplyConfiguration(new ProductoDeseadoConfig());
            modelBuilder.ApplyConfiguration(new CategoriaConfig());
        }
    }
}
