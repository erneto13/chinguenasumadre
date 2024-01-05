using CapaNegocio.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class ModificarPlatillo : Form
    {
        private CN_Platillos cnPlatillos = new CN_Platillos();
        private CN_Ingredientes cnIngredientes = new CN_Ingredientes();
        private Form1 formPrincipal;

        public ModificarPlatillo(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            CargarPlatillosCBOX();
        }

        private void CargarPlatillosCBOX()
        {
            try
            {
                var platillos = cnPlatillos.MostrarPlatillos();

                cboxPlatillos.Items.Clear();

                foreach (DataRow fila in platillos.Rows)
                {
                    string nombrePlatillo = fila["Nombre"].ToString();
                    cboxPlatillos.Items.Add(nombrePlatillo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los platillos: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén el PlatilloID seleccionado en el ComboBox
                int platilloID = ObtenerPlatilloIDSeleccionado();

                // Obtén la cantidad de platillos del TextBox
                int cantidadPlatillos = Convert.ToInt32(tboxPlatillos.Text);

                // Verifica si hay suficientes ingredientes antes de actualizar el stock del platillo
                if (cnIngredientes.VerificarStockSuficiente(platilloID, cantidadPlatillos))
                {
                    // Si hay suficientes ingredientes, actualiza el stock del platillo
                    cnPlatillos.ActualizarStock(platilloID, cantidadPlatillos);
                    MessageBox.Show("Stock actualizado correctamente.");

                    // Llama al método de actualización del formulario principal
                    formPrincipal.ActualizarDatosTablas();
                }
                else
                {
                    // Si no hay suficientes ingredientes, muestra un mensaje específico
                    MessageBox.Show("No se pudo realizar el re-stock debido a la insuficiencia de ingredientes para el platillo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                // Maneja el error de formato al convertir la cantidad de platillos a un entero
                MessageBox.Show("Por favor, ingrese una cantidad válida de platillos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerPlatilloIDSeleccionado()
        {
            string nombrePlatilloSeleccionado = cboxPlatillos.SelectedItem.ToString();

            int platilloID = cnPlatillos.ObtenerPlatilloIDPorNombre(nombrePlatilloSeleccionado);

            return platilloID;
        }

    }
}
