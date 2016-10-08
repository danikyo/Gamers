namespace Interfaz_de_usuario
{
    partial class Menu_Principal_Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal_Administrador));
            this.buttonVenta = new System.Windows.Forms.Button();
            this.buttonCompra = new System.Windows.Forms.Button();
            this.buttonInventario = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonEmpleado = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonFactura = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVenta
            // 
            this.buttonVenta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVenta.Location = new System.Drawing.Point(66, 148);
            this.buttonVenta.Name = "buttonVenta";
            this.buttonVenta.Size = new System.Drawing.Size(294, 48);
            this.buttonVenta.TabIndex = 0;
            this.buttonVenta.Text = "Venta";
            this.buttonVenta.UseVisualStyleBackColor = true;
            this.buttonVenta.Click += new System.EventHandler(this.buttonVenta_Click);
            // 
            // buttonCompra
            // 
            this.buttonCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompra.Location = new System.Drawing.Point(441, 148);
            this.buttonCompra.Name = "buttonCompra";
            this.buttonCompra.Size = new System.Drawing.Size(294, 48);
            this.buttonCompra.TabIndex = 1;
            this.buttonCompra.Text = "Compra";
            this.buttonCompra.UseVisualStyleBackColor = true;
            this.buttonCompra.Click += new System.EventHandler(this.buttonCompra_Click);
            // 
            // buttonInventario
            // 
            this.buttonInventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventario.Location = new System.Drawing.Point(66, 228);
            this.buttonInventario.Name = "buttonInventario";
            this.buttonInventario.Size = new System.Drawing.Size(294, 48);
            this.buttonInventario.TabIndex = 2;
            this.buttonInventario.Text = "Menu del inventario";
            this.buttonInventario.UseVisualStyleBackColor = true;
            this.buttonInventario.Click += new System.EventHandler(this.buttonInventario_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCliente.Location = new System.Drawing.Point(441, 228);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(294, 48);
            this.buttonCliente.TabIndex = 3;
            this.buttonCliente.Text = "Menu de clientes";
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonEmpleado
            // 
            this.buttonEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpleado.Location = new System.Drawing.Point(66, 307);
            this.buttonEmpleado.Name = "buttonEmpleado";
            this.buttonEmpleado.Size = new System.Drawing.Size(294, 48);
            this.buttonEmpleado.TabIndex = 4;
            this.buttonEmpleado.Text = "Menu de empleados";
            this.buttonEmpleado.UseVisualStyleBackColor = true;
            this.buttonEmpleado.Click += new System.EventHandler(this.buttonEmpleado_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(256, 376);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(294, 48);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonFactura
            // 
            this.buttonFactura.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFactura.Location = new System.Drawing.Point(441, 307);
            this.buttonFactura.Name = "buttonFactura";
            this.buttonFactura.Size = new System.Drawing.Size(294, 48);
            this.buttonFactura.TabIndex = 7;
            this.buttonFactura.Text = "Menu de Factura";
            this.buttonFactura.UseVisualStyleBackColor = true;
            this.buttonFactura.Click += new System.EventHandler(this.buttonFactura_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Interfaz_de_usuario.Properties.Resources.logook;
            this.pictureBox1.Location = new System.Drawing.Point(227, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Menu_Principal_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Interfaz_de_usuario.Properties.Resources.blurry_blue_background_ii_wallpaper_800x480;
            this.ClientSize = new System.Drawing.Size(797, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonFactura);
            this.Controls.Add(this.buttonVenta);
            this.Controls.Add(this.buttonCompra);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonEmpleado);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.buttonInventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_Principal_Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVenta;
        private System.Windows.Forms.Button buttonCompra;
        private System.Windows.Forms.Button buttonInventario;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonEmpleado;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonFactura;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}