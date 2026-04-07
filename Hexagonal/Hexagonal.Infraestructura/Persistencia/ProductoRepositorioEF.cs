using Hexagonal.Aplicacion.Puertos.Salida;
using Hexagonal.Dominio.Entidades;
using Hexagonal.Infraestructura.Mappers;

namespace Hexagonal.Infraestructura.Persistencia
{
    public class ProductoRepositorioEF : IProductoRepositorio
    {

        private readonly AppContext _appContext;

        public ProductoRepositorioEF(AppContext appContext)
        {
            _appContext = appContext;
        }

        public void AgregarProducto(string Nombre, string Descripcion, decimal Precio, int Stock)
        {
            var producto = new Producto(Nombre, Descripcion, Precio, Stock);

            var productoEntity = ProductoMapper.ToEntity(producto);

            _appContext.Add(productoEntity);
            _appContext.SaveChanges();
        }
    }
}
