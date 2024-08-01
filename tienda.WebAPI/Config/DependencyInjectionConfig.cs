using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using tienda.Application.Services;
using tienda.Domain.DTOs;
using tienda.Domain.Interfaces.Repository;
using tienda.Domain.Interfaces.Services;
using tienda.Domain.Models;
using tienda.Infrastructure.Persistence.Context;
using tienda.Infrastructure.Persistence.Repositories;
namespace tienda.Config 
{ 
    public static class DependencyInjectionConfig 
    { 
        public static IServiceCollection InjectDependencies(this IServiceCollection services, IConfiguration configuration) 
        { 
            services.AddControllers(); 
            services.AddEndpointsApiExplorer(); 
            services.AddSwaggerGen();

            // add cors
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
            });

            // add sqlserver context
            services.AddDbContext<TContext>(
                options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("Master"));
                }
            );

            // add services
            services.AddScoped<ProductoService>();

            // implement services
            services.AddScoped<IProductoService<ProductoDTO, ProductoDetalleDTO, NewProductoDTO, NewDeseadoDTO>, ProductoService>();

            // add repos
            services.AddScoped<ProductoRepository>();
            services.AddScoped<CategoriaRepository>();
            services.AddScoped<ProductoDeseadoRepository>();

            // implement repos
            services.AddScoped<IProductoRepository<Producto>, ProductoRepository>();
            services.AddScoped<IProductoDeseadoRepository<ProductoDeseado, ProductoDTO>, ProductoDeseadoRepository>();
            services.AddScoped<IBaseRepository<Categoria>, CategoriaRepository>();

            return services; 
        } 
    } 
} 
