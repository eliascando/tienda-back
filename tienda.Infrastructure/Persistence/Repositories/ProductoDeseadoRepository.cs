﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tienda.Domain.DTOs;
using tienda.Domain.Interfaces.Repository;
using tienda.Domain.Models;
using tienda.Infrastructure.Persistence.Context;

namespace tienda.Infrastructure.Persistence.Repositories
{
    public class ProductoDeseadoRepository : IProductoDeseadoRepository<ProductoDeseado, ProductoDTO>
    {
        protected readonly TContext _context;

        public ProductoDeseadoRepository(TContext context)
        {
            _context = context;
        }

        public bool Delete(int id)
        {
            var e = _context.ProductosDeseados.Find(id) ?? throw new Exception("Entidad no encontrada");
            _context.Remove(e);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<ProductoDeseado> GetAll()
        {
            return _context.ProductosDeseados.ToList();
        }

        public ProductoDeseado GetById(int id)
        {
            return _context.ProductosDeseados.Find(id) ?? throw new Exception("Entidad no encontrada");
        }

        public int ObtenerCantiadVecesDeseado(int pId)
        {
            return _context.ProductosDeseados.Where(x => x.ProductId == pId).Count();
        }

        public IEnumerable<ProductoDTO> ProductoDeseado()
        {
            var productos = _context.Productos.ToList();

            var p = productos.Select(p => new
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Categoria = _context.Categorias.Find(p.CategoriaId)?.Nombre,
                CantidadFavoritos = _context.ProductosDeseados.Count(x => x.ProductId == p.Id),
                Promedio = _context.Productos.Where(x => x.Id == p.Id).Select(x => x.Stock).Average()
            }).ToList().Where(y => y.CantidadFavoritos > 0);

            return p.Select(x => new ProductoDTO()
            {
                ArribaPromedio = x.Promedio > x.CantidadFavoritos,
                CantidadFavoritos = x.CantidadFavoritos,
                Id = x.Id,
                Nombre = x.Nombre,
                Categoria = x.Categoria
            });
        }


        public IEnumerable<ProductoDTO> ProductoDeseadosPorUsuario(string user)
        {
            var ids =_context.ProductosDeseados.Where(x => x.NombreUsuario == user).Select(x => x.ProductId).ToList();

            return _context.Productos.Where(x => ids.Contains(x.Id)).Select(p => new ProductoDTO()
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Categoria = _context.Categorias.Find(_context.Categorias.Find(p.CategoriaId)).Nombre
            }).ToList();
        }

        public ProductoDeseado Save(ProductoDeseado entity)
        {
            _context.ProductosDeseados.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public ProductoDeseado Update(ProductoDeseado entity)
        {
            throw new NotImplementedException();
        }
    }
}
