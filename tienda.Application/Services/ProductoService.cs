using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tienda.Domain.DTOs;
using tienda.Domain.Interfaces.Repository;
using tienda.Domain.Interfaces.Services;
using tienda.Domain.Models;

namespace tienda.Application.Services
{
    public class ProductoService : IProductoService<ProductoDTO, ProductoDetalleDTO, NewProductoDTO, NewDeseadoDTO>
    {
        private readonly IProductoRepository<Producto> _repo;
        private readonly IBaseRepository<Categoria> _repoC;
        private readonly IProductoDeseadoRepository<ProductoDeseado, ProductoDTO> _repoD;

        public ProductoService(IProductoRepository<Producto> repo, IBaseRepository<Categoria> repoC, IProductoDeseadoRepository<ProductoDeseado, ProductoDTO> repoD)
        {
            _repo = repo;
            _repoC = repoC;
            _repoD = repoD;
        }

        public NewDeseadoDTO AgregarDesead(NewDeseadoDTO entity)
        {
            var e = new ProductoDeseado();

            e.FechaCreacion = DateTime.Now;
            e.NombreUsuario = entity.NombreUsuario;
            e.ProductId = entity.ProductId;

            var x = _repoD.Save(e);

            return new NewDeseadoDTO
            {
                NombreUsuario = x.NombreUsuario,
                ProductId = entity.ProductId
            };
        }

        public IEnumerable<ProductoDTO> Buscar(string param)
        {
            return _repo.BuscarPorParam(param).Select(x => new ProductoDTO()
            {
                Nombre = x.Nombre,
                Categoria = _repoC.GetById(x.CategoriaId).Nombre,
                Id = x.Id
            });
        }

        public IEnumerable<ProductoDTO> ConsultarDeseados(string user)
        {
            return _repoD.ProductoDeseadosPorUsuario(user);
        }

        public IEnumerable<ProductoDTO> ConsultarDeseadosTodos()
        {
            return _repoD.ProductoDeseado();
        }

        public bool Eliminar(int id)
        {
            return _repo.Delete(id);
        }

        public ProductoDTO Guardar(NewProductoDTO entity)
        {
            Producto nuevo = new Producto();
            nuevo.Nombre = entity.Nombre;
            nuevo.Descripcion = entity.Descripcion;
            nuevo.CategoriaId = entity.CategoriaId;
            nuevo.Stock = entity.Stock;

            var n = _repo.Save(nuevo);
            return new ProductoDTO()
            {
                Id = n.Id,
                Nombre = n.Nombre,
                Categoria = _repoC.GetById(n.CategoriaId).Nombre
            };
        }

        public ProductoDetalleDTO ObtenerDetalle(int id)
        {
            var x = _repo.GetById(id);
            return new ProductoDetalleDTO()
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Descripcion = x.Descripcion,
                Stock = x.Stock,
                Categoria = _repoC.GetById(x.CategoriaId).Nombre,
                CantidadDeseados = _repoD.ObtenerCantiadVecesDeseado(x.Id)
            };
        }

        public IEnumerable<ProductoDTO> ObtenerTodos()
        {
            return _repo.GetAll().Select(x => new ProductoDTO()
            {
                Nombre = x.Nombre,
                Categoria = _repoC.GetById(x.CategoriaId).Nombre,
                Id = x.Id
            });
        }
    }
}
