using CapaDatos.Consultas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Consultas
{
    public class CN_Ingredientes
    {
        private CD_Ingredientes objetoCD = new CD_Ingredientes();
        private CD_Platillos objetoCDPlatillos = new CD_Platillos();

        public DataTable MostrarIngredientes()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public bool VerificarStockSuficiente(int platilloID, int cantidadPlatillos)
        {
            // Verifica si hay suficiente stock de ingredientes antes de actualizar
            if (objetoCD.VerificarStockSuficiente(platilloID, cantidadPlatillos))
            {
                // Actualiza el stock solo si hay suficiente stock de ingredientes
                objetoCD.VerificarStockSuficiente(platilloID, cantidadPlatillos);
                return true; // Actualización exitosa
            }
            else
            {
                Console.WriteLine("No hay suficiente stock de ingredientes para realizar el re-stock.");
                return false; // No hay suficiente stock
            }
        }
    }
}
