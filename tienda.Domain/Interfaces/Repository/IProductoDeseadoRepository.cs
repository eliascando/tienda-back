using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda.Domain.Interfaces.Repository
{
    public interface IProductoDeseadoRepository<T, TProducto> : IBaseRepository<T>
    {
        int ObtenerCantiadVecesDeseado(int pId);

        IEnumerable<TProducto> ProductoDeseadosPorUsuario(string user);
        IEnumerable<TProducto> ProductoDeseado();
    }
}
