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
    public class CD_Recetas
    {
        private ConexionBD conexion = new ConexionBD();
        SqlDataReader? lector;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        // Muestra los datos de la tabla Productos
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = ("SELECT * FROM Recetas");
            lector = comando.ExecuteReader();
            tabla.Load(lector);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
