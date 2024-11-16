using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Credito_En_Tienda_Departamental
{
    public partial class form2 : Form
    {
        private List<(string Username, string Password)> registrar;

        public form2(List<(string, string)> users)
        {
            InitializeComponent();
            registrar = users;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string username = txt_NewUsuario.Text;
            string password = txt_NewPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Favor de completar los campos solicitados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            registrar.Add((username, password));
            MessageBox.Show("Se ha registrado un nuevo usuario", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Regresar al formulario de inicio de sesión sin crear una nueva instancia
            this.Close();
            Application.OpenForms["Form1"].Show(); // Vuelve a mostrar Form1
        }
    }
}