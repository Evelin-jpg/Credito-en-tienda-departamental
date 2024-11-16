namespace Credito_En_Tienda_Departamental
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.listViewCarrito = new System.Windows.Forms.ListView();
            this.btn_ReducirCantidad = new System.Windows.Forms.Button();
            this.btn_EliminarProducto = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btn_Vaciar = new System.Windows.Forms.Button();
            this.btnProducto1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProducto2 = new System.Windows.Forms.Button();
            this.btnProducto3 = new System.Windows.Forms.Button();
            this.btnProducto4 = new System.Windows.Forms.Button();
            this.btnProducto5 = new System.Windows.Forms.Button();
            this.btnProducto10 = new System.Windows.Forms.Button();
            this.btnProducto9 = new System.Windows.Forms.Button();
            this.btnProducto8 = new System.Windows.Forms.Button();
            this.btnProducto7 = new System.Windows.Forms.Button();
            this.btnProducto6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewCarrito
            // 
            this.listViewCarrito.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCarrito.HideSelection = false;
            this.listViewCarrito.Location = new System.Drawing.Point(21, 559);
            this.listViewCarrito.Name = "listViewCarrito";
            this.listViewCarrito.Size = new System.Drawing.Size(434, 178);
            this.listViewCarrito.TabIndex = 1;
            this.listViewCarrito.UseCompatibleStateImageBehavior = false;
            this.listViewCarrito.View = System.Windows.Forms.View.Details;
            // 
            // btn_ReducirCantidad
            // 
            this.btn_ReducirCantidad.BackColor = System.Drawing.Color.Purple;
            this.btn_ReducirCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ReducirCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReducirCantidad.ForeColor = System.Drawing.Color.White;
            this.btn_ReducirCantidad.Location = new System.Drawing.Point(459, 694);
            this.btn_ReducirCantidad.Name = "btn_ReducirCantidad";
            this.btn_ReducirCantidad.Size = new System.Drawing.Size(279, 43);
            this.btn_ReducirCantidad.TabIndex = 30;
            this.btn_ReducirCantidad.Text = "Reducir Cantidad De Productos";
            this.btn_ReducirCantidad.UseVisualStyleBackColor = false;
            this.btn_ReducirCantidad.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_EliminarProducto
            // 
            this.btn_EliminarProducto.BackColor = System.Drawing.Color.Purple;
            this.btn_EliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_EliminarProducto.Location = new System.Drawing.Point(459, 593);
            this.btn_EliminarProducto.Name = "btn_EliminarProducto";
            this.btn_EliminarProducto.Size = new System.Drawing.Size(114, 43);
            this.btn_EliminarProducto.TabIndex = 31;
            this.btn_EliminarProducto.Text = "Eliminar";
            this.btn_EliminarProducto.UseVisualStyleBackColor = false;
            this.btn_EliminarProducto.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.Purple;
            this.btn_Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.btn_Regresar.Location = new System.Drawing.Point(0, 0);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(125, 43);
            this.btn_Regresar.TabIndex = 33;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(284, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(345, 31);
            this.label10.TabIndex = 34;
            this.label10.Text = "CARRITO DE COMPRAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(850, 7);
            this.label4.TabIndex = 35;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(342, 79);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(224, 24);
            this.label27.TabIndex = 36;
            this.label27.Text = "Catalogo De Productos";
            // 
            // btn_Vaciar
            // 
            this.btn_Vaciar.BackColor = System.Drawing.Color.Purple;
            this.btn_Vaciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Vaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vaciar.ForeColor = System.Drawing.Color.White;
            this.btn_Vaciar.Location = new System.Drawing.Point(459, 645);
            this.btn_Vaciar.Name = "btn_Vaciar";
            this.btn_Vaciar.Size = new System.Drawing.Size(139, 43);
            this.btn_Vaciar.TabIndex = 38;
            this.btn_Vaciar.Text = "Vaciar Carrito";
            this.btn_Vaciar.UseVisualStyleBackColor = false;
            this.btn_Vaciar.Click += new System.EventHandler(this.btn_Vaciar_Click);
            // 
            // btnProducto1
            // 
            this.btnProducto1.BackColor = System.Drawing.Color.Transparent;
            this.btnProducto1.BackgroundImage = global::Credito_En_Tienda_Departamental.Properties.Resources.conjunto_femenino;
            this.btnProducto1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto1.ForeColor = System.Drawing.Color.White;
            this.btnProducto1.Location = new System.Drawing.Point(21, 186);
            this.btnProducto1.Name = "btnProducto1";
            this.btnProducto1.Size = new System.Drawing.Size(157, 136);
            this.btnProducto1.TabIndex = 39;
            this.btnProducto1.UseVisualStyleBackColor = false;
            this.btnProducto1.Click += new System.EventHandler(this.btnProducto1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Sección de mujeres";
            // 
            // btnProducto2
            // 
            this.btnProducto2.BackColor = System.Drawing.Color.Transparent;
            this.btnProducto2.BackgroundImage = global::Credito_En_Tienda_Departamental.Properties.Resources.reloj_femenino;
            this.btnProducto2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto2.ForeColor = System.Drawing.Color.White;
            this.btnProducto2.Location = new System.Drawing.Point(193, 186);
            this.btnProducto2.Name = "btnProducto2";
            this.btnProducto2.Size = new System.Drawing.Size(157, 136);
            this.btnProducto2.TabIndex = 41;
            this.btnProducto2.UseVisualStyleBackColor = false;
            this.btnProducto2.Click += new System.EventHandler(this.btnProducto2_Click);
            // 
            // btnProducto3
            // 
            this.btnProducto3.BackColor = System.Drawing.Color.Transparent;
            this.btnProducto3.BackgroundImage = global::Credito_En_Tienda_Departamental.Properties.Resources.bolso_de_mujer;
            this.btnProducto3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto3.ForeColor = System.Drawing.Color.White;
            this.btnProducto3.Location = new System.Drawing.Point(370, 186);
            this.btnProducto3.Name = "btnProducto3";
            this.btnProducto3.Size = new System.Drawing.Size(157, 136);
            this.btnProducto3.TabIndex = 42;
            this.btnProducto3.UseVisualStyleBackColor = false;
            this.btnProducto3.Click += new System.EventHandler(this.btnProducto3_Click);
            // 
            // btnProducto4
            // 
            this.btnProducto4.BackColor = System.Drawing.Color.Transparent;
            this.btnProducto4.BackgroundImage = global::Credito_En_Tienda_Departamental.Properties.Resources.collar_mariposa_mujer;
            this.btnProducto4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto4.ForeColor = System.Drawing.Color.White;
            this.btnProducto4.Location = new System.Drawing.Point(545, 186);
            this.btnProducto4.Name = "btnProducto4";
            this.btnProducto4.Size = new System.Drawing.Size(157, 136);
            this.btnProducto4.TabIndex = 43;
            this.btnProducto4.UseVisualStyleBackColor = false;
            this.btnProducto4.Click += new System.EventHandler(this.btnProducto4_Click);
            // 
            // btnProducto5
            // 
            this.btnProducto5.BackColor = System.Drawing.Color.Transparent;
            this.btnProducto5.BackgroundImage = global::Credito_En_Tienda_Departamental.Properties.Resources.samsung_A15;
            this.btnProducto5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto5.ForeColor = System.Drawing.Color.White;
            this.btnProducto5.Location = new System.Drawing.Point(712, 186);
            this.btnProducto5.Name = "btnProducto5";
            this.btnProducto5.Size = new System.Drawing.Size(157, 136);
            this.btnProducto5.TabIndex = 44;
            this.btnProducto5.UseVisualStyleBackColor = false;
            this.btnProducto5.Click += new System.EventHandler(this.btnProducto5_Click);
            // 
            // btnProducto10
            // 
            this.btnProducto10.BackColor = System.Drawing.Color.Transparent;
            this.btnProducto10.BackgroundImage = global::Credito_En_Tienda_Departamental.Properties.Resources.Motorola_G14;
            this.btnProducto10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto10.ForeColor = System.Drawing.Color.White;
            this.btnProducto10.Location = new System.Drawing.Point(712, 391);
            this.btnProducto10.Name = "btnProducto10";
            this.btnProducto10.Size = new System.Drawing.Size(157, 136);
            this.btnProducto10.TabIndex = 49;
            this.btnProducto10.UseVisualStyleBackColor = false;
            this.btnProducto10.Click += new System.EventHandler(this.btnProducto10_Click);
            // 
            // btnProducto9
            // 
            this.btnProducto9.BackColor = System.Drawing.Color.Transparent;
            this.btnProducto9.BackgroundImage = global::Credito_En_Tienda_Departamental.Properties.Resources.collar_de_hombre_flechas;
            this.btnProducto9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto9.ForeColor = System.Drawing.Color.White;
            this.btnProducto9.Location = new System.Drawing.Point(545, 391);
            this.btnProducto9.Name = "btnProducto9";
            this.btnProducto9.Size = new System.Drawing.Size(157, 136);
            this.btnProducto9.TabIndex = 48;
            this.btnProducto9.UseVisualStyleBackColor = false;
            this.btnProducto9.Click += new System.EventHandler(this.btnProducto9_Click);
            // 
            // btnProducto8
            // 
            this.btnProducto8.BackColor = System.Drawing.Color.Transparent;
            this.btnProducto8.BackgroundImage = global::Credito_En_Tienda_Departamental.Properties.Resources.mochila_para_laptop_hombre;
            this.btnProducto8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto8.ForeColor = System.Drawing.Color.White;
            this.btnProducto8.Location = new System.Drawing.Point(370, 391);
            this.btnProducto8.Name = "btnProducto8";
            this.btnProducto8.Size = new System.Drawing.Size(157, 136);
            this.btnProducto8.TabIndex = 47;
            this.btnProducto8.UseVisualStyleBackColor = false;
            this.btnProducto8.Click += new System.EventHandler(this.btnProducto8_Click);
            // 
            // btnProducto7
            // 
            this.btnProducto7.BackColor = System.Drawing.Color.Transparent;
            this.btnProducto7.BackgroundImage = global::Credito_En_Tienda_Departamental.Properties.Resources.reloj_de_hombre;
            this.btnProducto7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto7.ForeColor = System.Drawing.Color.White;
            this.btnProducto7.Location = new System.Drawing.Point(193, 391);
            this.btnProducto7.Name = "btnProducto7";
            this.btnProducto7.Size = new System.Drawing.Size(157, 136);
            this.btnProducto7.TabIndex = 46;
            this.btnProducto7.UseVisualStyleBackColor = false;
            this.btnProducto7.Click += new System.EventHandler(this.btnProducto7_Click);
            // 
            // btnProducto6
            // 
            this.btnProducto6.BackColor = System.Drawing.Color.Transparent;
            this.btnProducto6.BackgroundImage = global::Credito_En_Tienda_Departamental.Properties.Resources.conjunto_masculino;
            this.btnProducto6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto6.ForeColor = System.Drawing.Color.White;
            this.btnProducto6.Location = new System.Drawing.Point(21, 391);
            this.btnProducto6.Name = "btnProducto6";
            this.btnProducto6.Size = new System.Drawing.Size(157, 136);
            this.btnProducto6.TabIndex = 45;
            this.btnProducto6.UseVisualStyleBackColor = false;
            this.btnProducto6.Click += new System.EventHandler(this.btnProducto6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Sección de hombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(850, 7);
            this.label3.TabIndex = 51;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(141, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Aquí se reflejaran los productos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(576, 605);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "Puedes eliminar el producto no deseado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(601, 659);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Todo lo que este en el carrito se borrara";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Credito_En_Tienda_Departamental.Properties.Resources.carrito2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 749);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProducto10);
            this.Controls.Add(this.btnProducto9);
            this.Controls.Add(this.btnProducto8);
            this.Controls.Add(this.btnProducto7);
            this.Controls.Add(this.btnProducto6);
            this.Controls.Add(this.btnProducto5);
            this.Controls.Add(this.btnProducto4);
            this.Controls.Add(this.btnProducto3);
            this.Controls.Add(this.btnProducto2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProducto1);
            this.Controls.Add(this.btn_Vaciar);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.btn_EliminarProducto);
            this.Controls.Add(this.btn_ReducirCantidad);
            this.Controls.Add(this.listViewCarrito);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewCarrito;
        private System.Windows.Forms.Button btn_ReducirCantidad;
        private System.Windows.Forms.Button btn_EliminarProducto;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btn_Vaciar;
        private System.Windows.Forms.Button btnProducto1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProducto2;
        private System.Windows.Forms.Button btnProducto3;
        private System.Windows.Forms.Button btnProducto4;
        private System.Windows.Forms.Button btnProducto5;
        private System.Windows.Forms.Button btnProducto10;
        private System.Windows.Forms.Button btnProducto9;
        private System.Windows.Forms.Button btnProducto8;
        private System.Windows.Forms.Button btnProducto7;
        private System.Windows.Forms.Button btnProducto6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}