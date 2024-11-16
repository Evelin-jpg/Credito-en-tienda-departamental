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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(); // Crear una instancia del formulario sin parámetros
            form5.Show(); // Mostrar el nuevo formulario
            this.Hide();
        }

        //Button de solicitar credito
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(); // Crear una instancia del formulario sin parámetros
            form4.Show(); // Mostrar el nuevo formulario
            this.Hide();
        }

        private void btn_Carrito_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(); // Crear una instancia del formulario sin parámetros
            form7.Show(); // Mostrar el nuevo formulario
            this.Hide();
        }
    }
}
