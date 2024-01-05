using CapaDatos.Consultas;
using CapaNegocio.Consultas;
using CapaPresentacion.Forms;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CN_DetalleRecetas objetoCN = new CN_DetalleRecetas();
        CN_Platillos objetoCNP = new CN_Platillos();
        CN_Ingredientes objetoIG = new CN_Ingredientes();
        CN_Recetas objetoRC = new CN_Recetas();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            MostrarDetalleRecetas();
            MostrarPlatiilos();
            MostrarIngredientes();
            MostrarRecetas();
        }

        private void MostrarRecetas()
        {
            dgvRecetas.DataSource = objetoRC.MostrarRecetas();
        }

        private void MostrarIngredientes()
        {
            dgvIngredientes.DataSource = objetoIG.MostrarIngredientes();
        }

        private void MostrarPlatiilos()
        {
            dgvPlatillos.DataSource = objetoCNP.MostrarPlatillos();
        }

        private void MostrarDetalleRecetas()
        {
            dgvDetalleRecetas.DataSource = objetoCN.MostrarDetalleRecetas();
        }

        private void btnModificarPL_Click(object sender, EventArgs e)
        {
            // Verificar si ya hay una instancia de la ventana abierta
            if (Application.OpenForms.OfType<ModificarPlatillo>().Any())
            {
                MessageBox.Show("No se pudo abrir la ventana puesto que ya hay una abierta", "Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                // Se crea la instancia a la ventana
                ModificarPlatillo formMod = new ModificarPlatillo(this);

                formMod.FormClosed += (s, args) => this.Show();
                formMod.Show();
            }
        }
        
        public void ActualizarDatosTablas()
        {
            DataTable datosIngredientes = ObtenerDatosIngredientesDesdeCapaNegocio();
            dgvIngredientes.DataSource = datosIngredientes;

        }

        private DataTable ObtenerDatosIngredientesDesdeCapaNegocio()
        {
            CN_Ingredientes cnIngredientes = new CN_Ingredientes();
            return cnIngredientes.MostrarIngredientes();
        }
    }
}
