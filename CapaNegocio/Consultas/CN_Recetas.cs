using CapaDatos.Consultas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Consultas
{
    public class CN_Recetas
    {
        private CD_Recetas objetoCD = new CD_Recetas();

        public DataTable MostrarRecetas()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
    }
}
