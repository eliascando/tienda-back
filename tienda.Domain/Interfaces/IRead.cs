using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda.Domain.Interfaces
{
    public interface IRead<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
