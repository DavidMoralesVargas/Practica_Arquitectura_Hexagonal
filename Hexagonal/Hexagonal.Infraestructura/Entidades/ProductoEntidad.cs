using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hexagonal.Infraestructura.Entidades
{
    public class ProductoEntidad
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [Description("Nombre del producto.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "La descripción del producto es obligatorio.")]
        [Description("Descripcíón del producto.")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "El precio del producto es obligatorio.")]
        [Description("Precio del producto.")]
        [MinLength(1, ErrorMessage = "El precio del producto no puede ser negativo")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El precio del producto es obligatorio.")]
        [Description("Precio del producto.")]
        [MinLength(1, ErrorMessage = "El stock del producto no puede ser negativo")]
        public int Stock { get; set; }
    }
}
