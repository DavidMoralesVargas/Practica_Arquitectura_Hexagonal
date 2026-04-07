using Hexagonal.Aplicacion.CasosDeUso;
using Hexagonal.Aplicacion.Puertos.Entrada;
using Hexagonal.Dominio.Entidades;
using Hexagonal.Infraestructura.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Hexagonal.API.Controllers
{
    [ApiController]
    [Route("/productos-ef")]
    public class ProductoEFController : ControllerBase
    {
        private readonly ICrearProductoCasoUso _crearProductoCasoUso;

        public ProductoEFController(ICrearProductoCasoUso crearProductoCasoUso)
        {
            _crearProductoCasoUso = crearProductoCasoUso;
        }

        [HttpPost]
        public IActionResult Crear(Producto producto)
        {
            _crearProductoCasoUso.Ejecutar(producto.Nombre!, producto.Descripcion!, producto.Precio, producto.Stock);
            return Ok("Producto creado con Entity Framework");
        }
    }
}
