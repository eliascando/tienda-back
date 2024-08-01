using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda.Domain.Interfaces
{
    public interface ISave<T>
    {
        T Save(T entity);
    }
}
