using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda.Domain.Interfaces.Services
{
    public interface IProductoService<T, TDet, TNew, TDeseado> : IService<T, TDet, TNew>
    {
        TDeseado AgregarDesead(TDeseado entity);
        IEnumerable<T> ConsultarDeseados(string user);
        IEnumerable<T> ConsultarDeseadosTodos();
    }
}
