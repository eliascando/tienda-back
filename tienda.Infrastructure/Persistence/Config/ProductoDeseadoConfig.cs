using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tienda.Domain.Models;

namespace tienda.Infrastructure.Persistence.Config
{
    public class ProductoDeseadoConfig : IEntityTypeConfiguration<ProductoDeseado>
    {

        public void Configure(EntityTypeBuilder<ProductoDeseado> builder)
        {
            builder.ToTable("ProductosDeseados");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
