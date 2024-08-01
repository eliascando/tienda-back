using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tienda.Domain.Interfaces.Repository;
using tienda.Domain.Models;
using tienda.Infrastructure.Persistence.Context;

namespace tienda.Infrastructure.Persistence.Repositories
{
    public class ProductoRepository : IProductoRepository<Producto>
    {
        protected readonly TContext _context;

        public ProductoRepository(TContext context)
        {
            _context = context;
        }

        public IEnumerable<Producto> BuscarPorParam(string param)
        {
            return _context.Productos.Where(x => x.Nombre.ToLower().Contains(param.ToLower()) || x.Descripcion.ToLower().Contains(param.ToLower())).ToList();
        }

        public bool Delete(int id)
        {
            var e = _context.Productos.Find(id) ?? throw new Exception("Entidad no encontrada");
            _context.Remove(e);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Producto> GetAll()
        {
            return _context.Productos.ToList();
        }

        public Producto GetById(int id)
        {
            return _context.Productos.Find(id) ?? throw new Exception("Entidad no encontrada");
        }

        public Producto Save(Producto entity)
        {
            _context.Productos.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Producto Update(Producto entity)
        {
            throw new NotImplementedException();
        }
    }
}
