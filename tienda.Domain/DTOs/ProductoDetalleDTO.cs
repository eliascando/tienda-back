using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda.Domain.DTOs
{
    public class ProductoDetalleDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public string Stock { get; set; }
        public int CantidadDeseados { get; set; }

    }
}
