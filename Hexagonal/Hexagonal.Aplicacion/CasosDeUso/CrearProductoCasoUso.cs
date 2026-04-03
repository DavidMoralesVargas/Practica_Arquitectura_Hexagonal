using Hexagonal.Aplicacion.Puertos.Entrada;
using Hexagonal.Aplicacion.Puertos.Salida;
using Hexagonal.Dominio.Entidades;

namespace Hexagonal.Aplicacion.CasosDeUso
{
    public class CrearProductoCasoUso : ICrearProductoCasoUso
    {
        private readonly IProductoRepositorio _productoRepositorio;

        public CrearProductoCasoUso(IProductoRepositorio productoRepositorio)
        {
            _productoRepositorio = productoRepositorio;
        }

        public void Ejecutar(string Nombre, string Descripcion, decimal Precio, int Stock)
        {
            var producto = new Producto(Nombre, Descripcion, Precio, Stock);

            _productoRepositorio.AgregarProducto(producto.Nombre!, 
                                                 producto.Descripcion!, 
                                                 producto.Precio, 
                                                 producto.Stock);
        }
    }
}
