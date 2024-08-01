using Microsoft.AspNetCore.Mvc;
using tienda.Domain.DTOs;
using tienda.Domain.Interfaces.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tienda.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService<ProductoDTO, ProductoDetalleDTO, NewProductoDTO, NewDeseadoDTO> _serv;

        public ProductoController(IProductoService<ProductoDTO, ProductoDetalleDTO, NewProductoDTO, NewDeseadoDTO> serv)
        {
            _serv = serv;
        }

        // GET: api/<ProductoController>
        [HttpGet]
        public ActionResult<IEnumerable<ProductoDTO>> Get()
        {
            try
            {
                return Ok(_serv.ObtenerTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public ActionResult<ProductoDetalleDTO> Get(int id)
        {
            try
            {
                return Ok(_serv.ObtenerDetalle(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // GET api/<ProductoController>/5
        [HttpGet("deseados/{usuario}")]
        public ActionResult<ProductoDTO> GetUsuario(string usuario)
        {
            try
            {
                return Ok(_serv.ConsultarDeseados(usuario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<ProductoDTO> PostP([FromBody] NewProductoDTO p)
        {
            try
            {
                return _serv.Guardar(p);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // POST api/<ProductoController>
        [HttpPost("deseado")]
        public ActionResult<NewDeseadoDTO> Post([FromBody] NewDeseadoDTO value)
        {
            try
            {
                return _serv.AgregarDesead(value);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("deseados")]
        public ActionResult<IEnumerable<ProductoDTO>> GetDeseados()
        {
            try
            {
                return Ok(_serv.ConsultarDeseadosTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
