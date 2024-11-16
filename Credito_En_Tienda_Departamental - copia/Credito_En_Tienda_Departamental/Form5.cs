using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credito_En_Tienda_Departamental
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_VolverInicioSesion_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Crear una instancia del formulario sin parámetros
            form1.Show(); // Mostrar el nuevo formulario
            this.Hide();
        }

        private void btn_VolverConsulta_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(); // Crear una instancia del formulario sin parámetros
            form6.Show(); // Mostrar el nuevo formulario
            this.Hide();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            // Mostrar mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario selecciona "Sí", cerrar la aplicación
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //button de carrito de compras
        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(); // Crear una instancia del formulario sin parámetros
            form7.Show(); // Mostrar el nuevo formulario
            this.Hide();
        }

        private void btn_Volversolicitarcredito_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(); // Crear una instancia del formulario sin parámetros
            form4.Show(); // Mostrar el nuevo formulario
            this.Hide();
        }
    }
}
