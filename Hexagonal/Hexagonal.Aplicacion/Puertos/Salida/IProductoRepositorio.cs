namespace Hexagonal.Aplicacion.Puertos.Salida
{
    public interface IProductoRepositorio
    {
        void AgregarProducto(string Nombre, string Descripcion, decimal Precio, int Stock);
    }
}
