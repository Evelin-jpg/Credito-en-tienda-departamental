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

namespace Credito_En_Tienda_Departamental
{
    public partial class Form1 : Form
    {
        //Parte del button_Entrar
        private List<(string Username, string Password)> Formulario2 = new List<(string, string)>();

        private Timer fadeInTimer;
        private int targetY; // Posición final en Y
        private double opacityIncrement = 0.05; // Incremento de opacidad
        private int positionIncrement = 5; // Incremento de posición en Y

        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0; // Inicia invisible

            // Centrar formulario en la pantalla
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formX = (screenWidth - this.Width) / 2;
            int formY = (screenHeight - this.Height) / 2;

            // Guardamos la posición final en Y y ponemos la posición inicial más abajo
            targetY = formY;
            this.Location = new Point(formX, formY + 100); // Empieza centrado, pero más abajo

            // Configuración del Timer para el efecto de entrada
            fadeInTimer = new Timer();
            fadeInTimer.Interval = 50; // Intervalo de actualización en milisegundos
            fadeInTimer.Tick += new EventHandler(FadeIn);
            fadeInTimer.Start();
        }

        private void FadeIn(object sender, EventArgs e)
        {
            // Incrementa la opacidad
            if (this.Opacity < 1)
                this.Opacity += opacityIncrement;

            // Mueve el formulario hacia arriba
            if (this.Location.Y > targetY)
                this.Location = new Point(this.Location.X, this.Location.Y - positionIncrement);

            // Detiene el Timer cuando el formulario está completamente visible y en su posición final
            if (this.Opacity >= 1 && this.Location.Y <= targetY)
                fadeInTimer.Stop();
        }

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {
            form2 Form2 = new form2(Formulario2);
            Form2.Show();
            this.Hide();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            string username = txt_Usuario.Text;
            string password = txt_Password.Text;
            bool loginSuccessful = Formulario2.Exists(user => user.Username == username && user.Password == password);

            if (loginSuccessful)
            {
                MessageBox.Show("Bienvenido! Tienes acceso completo ahora.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Form6 ConsultaForm = new Form6();
                ConsultaForm.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("El usuario o contraseña son incorrectos. Vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
