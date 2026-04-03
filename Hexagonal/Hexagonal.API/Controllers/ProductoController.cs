using Hexagonal.Aplicacion.Puertos.Entrada;
using Hexagonal.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Hexagonal.API.Controllers
{
    [ApiController]
    [Route("api/producto")]
    public class ProductoController : ControllerBase
    {
        private readonly ICrearProductoCasoUso _crearProductoCasoUso;

        public ProductoController(ICrearProductoCasoUso crearProductoCasoUso)
        {
            _crearProductoCasoUso = crearProductoCasoUso;
        }

        [HttpPost]
        public IActionResult CrearProducto([FromBody] Producto request)
        {
            _crearProductoCasoUso.Ejecutar(request.Nombre!, 
                                           request.Descripcion!, 
                                           request.Precio, 
                                           request.Stock);
            return Ok();
        }
    }
}
