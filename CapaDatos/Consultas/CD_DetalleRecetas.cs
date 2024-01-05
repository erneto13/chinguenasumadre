using System;
using System.Data;
using System.Data.SqlClient;
using is_pOSbeta_v23y11m.Utils.BD;

namespace CapaDatos.Consultas
{
    public class CD_DetalleRecetas
    {
        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        public SqlCommand comando = new SqlCommand();
        
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ObtenerDetallesRecetas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
    }
}
