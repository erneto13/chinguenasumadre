using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.Consultas;

namespace CapaNegocio.Consultas
{
    public class CN_DetalleRecetas
    {
        private CD_DetalleRecetas objetoCD = new CD_DetalleRecetas();

        public DataTable MostrarDetalleRecetas()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
    }
}
