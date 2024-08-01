using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tienda.Domain.Models;

namespace tienda.Domain.Interfaces.Repository
{
    public interface IProductoRepository<T> : IBaseRepository<T>
    {
        IEnumerable<T> BuscarPorParam(string param);
    }
}
