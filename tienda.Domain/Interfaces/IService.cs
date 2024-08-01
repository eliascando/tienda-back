using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda.Domain.Interfaces
{
    public interface IService<T, TDet, TNew>
    {
        IEnumerable<T> Buscar(string param);
        IEnumerable<T> ObtenerTodos();
        TDet ObtenerDetalle(int id);
        T Guardar(TNew entity);
        bool Eliminar(int id);
    }
}
