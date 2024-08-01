using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda.Domain.Models
{
    public class ProductoDeseado
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string NombreUsuario {  get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
