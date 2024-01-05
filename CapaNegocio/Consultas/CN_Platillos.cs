using CapaDatos.Consultas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Consultas
{
    public class CN_Platillos
    {
        private CD_Platillos objetoCD = new CD_Platillos();

        public DataTable MostrarPlatillos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public int ObtenerPlatilloIDPorNombre(string nombrePlatillo)
        {
            return objetoCD.ObtenerPlatilloIDPorNombre(nombrePlatillo);
        }

        public void ActualizarStock(int platilloID, int cantidadPlatillos)
        {
            objetoCD.ActualizarStock(platilloID, cantidadPlatillos);
        }
    }
}
