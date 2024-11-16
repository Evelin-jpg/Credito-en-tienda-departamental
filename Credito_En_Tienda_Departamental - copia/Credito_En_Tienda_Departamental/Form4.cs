using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Credito_En_Tienda_Departamental
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_ComprobanteDomi_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF Files|*.pdf", // Solo permite seleccionar archivos PDF
                Title = "Seleccione el comprobante de domicilio"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Verifica que el archivo seleccionado sea PDF
                if (Path.GetExtension(openFileDialog.FileName).ToLower() == ".pdf")
                {
                    textBox1.Text = Path.GetFileName(openFileDialog.FileName); // Muestra el nombre del archivo
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un archivo PDF.", "Archivo no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_INE_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Imágenes|*.jpg;*.jpeg;*.png", // Solo permite seleccionar archivos de imagen
                Title = "Seleccione su imagen (INE o fotografía)"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Verifica que el archivo seleccionado sea una imagen
                string extension = Path.GetExtension(openFileDialog.FileName).ToLower();
                if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                {
                    textBox2.Text = Path.GetFileName(openFileDialog.FileName); // Muestra el nombre del archivo
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName); // Muestra la imagen en el PictureBox
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta la imagen al tamaño del PictureBox
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un archivo de imagen (JPG, JPEG, o PNG).", "Archivo no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Favor de ingresar ambos archivos: el comprobante de domicilio y la imagen de INE o fotografía.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("La solicitud en aumento de credito a sido enviado correctamente. Favor de esperar a la confirmación.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(); // Crear una instancia del formulario sin parámetros
            form5.Show(); // Mostrar el nuevo formulario
            this.Hide();
        }
    }
}
