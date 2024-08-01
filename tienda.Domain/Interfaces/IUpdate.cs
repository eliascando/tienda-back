using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda.Domain.Interfaces
{
    public interface IUpdate<T>
    {
        T Update(T entity);
    }
}
