using Hexagonal.Aplicacion.Puertos.Salida;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Hexagonal.Infraestructura.Persistencia
{
    public class ProductoRepositorio : IProductoRepositorio
    {
        private string connectionString = "Server=Dacanad;Database=Hexagonal;Encrypt=False;User Id=super;Password=Ballena738738..;";


        public void AgregarProducto(string Nombre, string Descripcion, decimal Precio, int Stock)
        {
            const string sql = @"INSERT INTO Producto (nombre, descripcion, precio, stock) 
                                 VALUES (@Nombre, @Descripcion, @Precio, @Stock)";

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(sql, connection))
                {
                    // Añadimos los parámetros para evitar SQL Injection
                    command.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = Nombre;
                    command.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = Descripcion;
                    command.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Precio;
                    command.Parameters.Add("@Stock", SqlDbType.Int).Value = Stock;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
