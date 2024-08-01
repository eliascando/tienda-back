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
    public class CategoriaRepository : IBaseRepository<Categoria>
    {
        protected readonly TContext _context;

        public CategoriaRepository(TContext context)
        {
            _context = context;
        }

        public bool Delete(int id)
        {
            var e = _context.Categorias.Find(id) ?? throw new Exception("Entidad no encontrada");
            _context.Remove(e);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Categoria> GetAll()
        {
            return _context.Categorias.ToList();
        }

        public Categoria GetById(int id)
        {
            return _context.Categorias.Find(id) ?? throw new Exception("Entidad no encontrada");
        }

        public Categoria Save(Categoria entity)
        {
            _context.Categorias.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Categoria Update(Categoria entity)
        {
            throw new NotImplementedException();
        }
    }
}
