using is_pOSbeta_v23y11m.Utils.BD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Consultas
{
    public class CD_Ingredientes
    {
        private ConexionBD conexion = new ConexionBD();
        SqlDataReader? lector;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        // Muestra los datos de la tabla Productos
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = ("SELECT * FROM Ingredientes");
            lector = comando.ExecuteReader();
            tabla.Load(lector);
            conexion.CerrarConexion();
            return tabla;
        }

        public bool VerificarStockSuficiente(int platilloID, int cantidadPlatillos)
        {
            using (SqlConnection connection = conexion.AbrirConexion())
            {
                // Realiza una consulta para obtener el stock actual del ingrediente asociado al platillo
                string query = "SELECT Cantidad_Disponible FROM Ingredientes WHERE Ingrediente_ID = (SELECT TOP 1 Ingrediente_ID FROM DetalleRecetas WHERE PlatilloID = @platilloID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@platilloID", platilloID);

                    // Ejecuta la consulta y obtiene el stock actual
                    object resultado = command.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        int stockActual = Convert.ToInt32(resultado);

                        // Verifica si hay suficiente stock
                        return stockActual >= cantidadPlatillos;
                    }
                }
            }

            // Si algo sale mal, asumimos que no hay suficiente stock
            return false;
        }
    }
}
