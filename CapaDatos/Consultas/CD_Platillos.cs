using is_pOSbeta_v23y11m.Utils.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos.Consultas
{
    public class CD_Platillos
    {
        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        public SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Platillos";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public int ObtenerPlatilloIDPorNombre(string nombrePlatillo)
        {
            int platilloID = -1;

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT PlatilloID FROM Platillos WHERE Nombre = @nombrePlatillo";
                comando.Parameters.AddWithValue("@nombrePlatillo", nombrePlatillo);

                object result = comando.ExecuteScalar();

                if (result != null)
                {
                    platilloID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el PlatilloID: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
                comando.Parameters.Clear();
            }

            return platilloID;
        }

        public bool ActualizarStock(int platilloID, int cantidadPlatillos)
        {
            try
            {
                using (SqlConnection connection = conexion.AbrirConexion())
                {
                    // Realiza la actualización del stock en la base de datos
                    string query = "UPDATE Platillos SET Stock = Stock + @cantidadPlatillos WHERE PlatilloID = @platilloID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@platilloID", platilloID);
                        command.Parameters.AddWithValue("@cantidadPlatillos", cantidadPlatillos);

                        // Ejecuta la actualización
                        command.ExecuteNonQuery();

                        // Si llega hasta aquí, la actualización fue exitosa
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                // Maneja cualquier excepción y devuelve false si hay un problema
                return false;
            }
        }
    }
}
