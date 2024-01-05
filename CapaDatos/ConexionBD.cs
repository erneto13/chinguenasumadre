using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace is_pOSbeta_v23y11m.Utils.BD
{
    public class ConexionBD
    {
        private SqlConnection Conexion = new SqlConnection("Server=EQUIPODEERNESTO\\SQLEXPRESS;DataBase= BD_Restaurante;Integrated Security=true");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public void CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
        }
    }
}