namespace Interfaz_de_usuario
{
    partial class Menu_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Compra));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID_Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre_producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio_Unitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad_producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddProducto = new System.Windows.Forms.Button();
            this.buttonDeleteProducto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BackColor = System.Drawing.SystemColors.Menu;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Producto,
            this.nombre_producto,
            this.Precio_Unitario,
            this.Cantidad_producto});
            this.listView1.HoverSelection = true;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView1.Location = new System.Drawing.Point(11, 40);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(570, 352);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID_Producto
            // 
            this.ID_Producto.Text = "ID producto";
            this.ID_Producto.Width = 74;
            // 
            // nombre_producto
            // 
            this.nombre_producto.Text = "Nombre Producto";
            this.nombre_producto.Width = 319;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.Text = "Precio Compra";
            this.Precio_Unitario.Width = 101;
            // 
            // Cantidad_producto
            // 
            this.Cantidad_producto.Text = "Cantidad";
            this.Cantidad_producto.Width = 72;
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCliente.Location = new System.Drawing.Point(11, 9);
            this.labelNombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(51, 16);
            this.labelNombreCliente.TabIndex = 3;
            this.labelNombreCliente.Text = "label1";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(629, 104);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(84, 15);
            this.labelTotal.TabIndex = 19;
            this.labelTotal.Text = "PrecioTotal";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(632, 308);
            this.buttonConfirmar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(113, 41);
            this.buttonConfirmar.TabIndex = 16;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(603, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total a pagar: ";
            // 
            // buttonAddProducto
            // 
            this.buttonAddProducto.Location = new System.Drawing.Point(14, 401);
            this.buttonAddProducto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAddProducto.Name = "buttonAddProducto";
            this.buttonAddProducto.Size = new System.Drawing.Size(101, 23);
            this.buttonAddProducto.TabIndex = 25;
            this.buttonAddProducto.Text = "Agregar producto";
            this.buttonAddProducto.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteProducto
            // 
            this.buttonDeleteProducto.Location = new System.Drawing.Point(117, 401);
            this.buttonDeleteProducto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonDeleteProducto.Name = "buttonDeleteProducto";
            this.buttonDeleteProducto.Size = new System.Drawing.Size(101, 23);
            this.buttonDeleteProducto.TabIndex = 24;
            this.buttonDeleteProducto.Text = "Quitar producto";
            this.buttonDeleteProducto.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 355);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 41);
            this.button1.TabIndex = 26;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Menu_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddProducto);
            this.Controls.Add(this.buttonDeleteProducto);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNombreCliente);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaccion Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID_Producto;
        private System.Windows.Forms.ColumnHeader nombre_producto;
        private System.Windows.Forms.ColumnHeader Precio_Unitario;
        private System.Windows.Forms.ColumnHeader Cantidad_producto;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddProducto;
        private System.Windows.Forms.Button buttonDeleteProducto;
        private System.Windows.Forms.Button button1;
    }
}