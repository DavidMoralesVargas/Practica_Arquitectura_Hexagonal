namespace Hexagonal.Aplicacion.Puertos.Entrada
{
    public interface ICrearProductoCasoUso
    {
        void Ejecutar(string Nombre, string Descripcion, decimal Precio, int Stock);
    }
}
