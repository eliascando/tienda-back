using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda.Domain.Interfaces.Repository
{
    public interface IBaseRepository<T> : IRead<T>, IDelete, ISave<T>, IUpdate<T>
    {

    }
}
