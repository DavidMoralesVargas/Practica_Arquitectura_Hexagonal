
using Hexagonal.Dominio.Entidades;
using Hexagonal.Infraestructura.Entidades;

namespace Hexagonal.Infraestructura.Mappers
{
    public static class ProductoMapper
    {
        public static ProductoEntidad ToEntity(Producto dominio)
        {
            return new ProductoEntidad
            {
                Nombre = dominio.Nombre,
                Descripcion = dominio.Descripcion,
                Precio = dominio.Precio,
                Stock = dominio.Stock
            };
        }
    }
}
