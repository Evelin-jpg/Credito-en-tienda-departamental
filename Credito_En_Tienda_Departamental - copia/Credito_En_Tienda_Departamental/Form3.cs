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
    public partial class Form3 : Form
    {
        private List<(DateTime FechaPago, bool Pagado)> historialPagos;
        private decimal creditoDisponible = 3000;
        private List<decimal> historialCompras = new List<decimal>();

        public Form3()
        {
            InitializeComponent();
            historialPagos = new List<(DateTime, bool)>
            {
                (new DateTime(2024, 10, 1), true),
                (new DateTime(2024, 11, 1), false),
                (new DateTime(2024, 12, 1), false)
            };

            historialCompras = new List<decimal>
        {
            500,
            150,
            300
        };

            MostrarHistorial();
            ActualizarCredito();


        }

        private void ActualizarCredito()
        {
            label2.Text = $"Crédito disponible: {creditoDisponible:C}";
            listBox1.Items.Clear();
            foreach (var compra in historialCompras)
            {
                listBox1.Items.Add($"Compra: {compra:C}");
            }
        }

        private void MostrarHistorial()
        {
            listBoxHistorial.Items.Clear();
            foreach (var pago in historialPagos)
            {
                string estado = pago.Pagado ? "Pagado" : "Pendiente";
                listBoxHistorial.Items.Add($"Fecha: {pago.FechaPago.ToShortDateString()} - Estado: {estado}");
            }


            DateTime proximoPago = historialPagos.Find(p => !p.Pagado).FechaPago;
            label1.Text = $"Próximo pago: {proximoPago.ToShortDateString()}";
            label3.Text = $"Fecha de corte: {new DateTime(proximoPago.Year, proximoPago.Month, DateTime.DaysInMonth(proximoPago.Year, proximoPago.Month)).ToShortDateString()}";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(); // Crear una instancia del formulario sin parámetros
            form4.Show(); // Mostrar el nuevo formulario
            this.Hide();
        }

        
    }
    
}
