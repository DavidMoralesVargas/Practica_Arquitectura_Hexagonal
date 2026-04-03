namespace Hexagonal.Dominio.Entidades
{
    public class Producto
    {
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public Producto(string Nombre, string Descripcion, decimal Precio, int Stock)
        {
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Precio = Precio < 0 ? 0 : Precio;
            this.Stock = Stock < 0 ? 0 : Stock;
        }
    }
}
