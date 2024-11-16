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
    public partial class Form7 : Form
    {

        // Diccionario para llevar el conteo de los productos
        private Dictionary<string, int> carrito = new Dictionary<string, int>();

        public Form7()
        {
            InitializeComponent();
            // Configuración inicial del ListView
            listViewCarrito.View = View.Details; // Modo de detalles
            listViewCarrito.Columns.Add("Producto", 180);
            listViewCarrito.Columns.Add("Cantidad", 90);
        }

        private void AgregarProductoAlCarrito(string nombreProducto)
        {
            if (carrito.ContainsKey(nombreProducto))
            {
                carrito[nombreProducto]++;
            }
            else
            {
                carrito[nombreProducto] = 1;
            }
            ActualizarListView();
        }

        private void ActualizarListView()
        {
            listViewCarrito.Items.Clear();
            foreach (var item in carrito)
            {
                var listItem = new ListViewItem(item.Key);
                listItem.SubItems.Add(item.Value.ToString());
                listViewCarrito.Items.Add(listItem);
            }
        }

        private void EliminarProductoSeleccionado()
        {
            if (listViewCarrito.SelectedItems.Count > 0)
            {
                string productoSeleccionado = listViewCarrito.SelectedItems[0].Text; // Obtener el nombre del producto
                carrito.Remove(productoSeleccionado); // Eliminar del diccionario
                ActualizarListView(); // Actualizar la lista
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BorrarTodoElCarrito()
        {
            carrito.Clear(); // Limpiar el diccionario
            ActualizarListView(); // Actualizar el ListView
        }


        private void ReducirCantidadProducto()
        {
            if (listViewCarrito.SelectedItems.Count > 0)
            {
                string productoSeleccionado = listViewCarrito.SelectedItems[0].Text;
                if (carrito.ContainsKey(productoSeleccionado))
                {
                    carrito[productoSeleccionado]--; // Reducir cantidad
                    if (carrito[productoSeleccionado] <= 0)
                    {
                        carrito.Remove(productoSeleccionado); // Eliminar si cantidad es 0
                    }
                    ActualizarListView(); // Actualizar el ListView
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto para reducir su cantidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(); // Crear una instancia del formulario sin parámetros
            form6.Show(); // Mostrar el nuevo formulario
            this.Hide();
        }

        //BUTTONS PARA LISTVIEW PARA FORMAR ACCIONES CON LOS PRODUCTOS
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            ReducirCantidadProducto();

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarProductoSeleccionado();

        }

        private void btn_Vaciar_Click(object sender, EventArgs e)
        {
            BorrarTodoElCarrito();

        }

        //PRODUCTOS FEMENINOS
        private void btnProducto1_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Conjunto De Verano Femenino");

        }

        private void btnProducto2_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Reloj Rosa Pastel");

        }

        private void btnProducto3_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Bolso Color Coral");

        }

        private void btnProducto4_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Collar Mariposa de Plata");

        }

        private void btnProducto5_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Celular Samsung modelo A15");

        }

        //PRODUCTOS MASCULINOS

        private void btnProducto6_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Conjunto de Hombre Invierno");

        }

        private void btnProducto7_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Reloj Color Plateado y Negro");

        }

        private void btnProducto8_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Mochila Para Laptop Color Negra");

        }

        private void btnProducto9_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Collar De Flecha Con Variedad De Colores");

        }

        private void btnProducto10_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Celular Motorola Moto G14");

        }
    }
}
