namespace Interfaz_de_usuario
{
    partial class Reporte_Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_Inventario));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID_Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre_producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad_Nuevo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad_Seminuevo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio_Nuevo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio_Seminuevo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BackColor = System.Drawing.SystemColors.Menu;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Producto,
            this.nombre_producto,
            this.Tipo,
            this.Precio_Nuevo,
            this.Cantidad_Nuevo,
            this.Precio_Seminuevo,
            this.Cantidad_Seminuevo});
            this.listView1.HoverSelection = true;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView1.Location = new System.Drawing.Point(11, 12);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(775, 369);
            this.listView1.TabIndex = 3;
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
            this.nombre_producto.Width = 218;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            this.Tipo.Width = 79;
            // 
            // Cantidad_Nuevo
            // 
            this.Cantidad_Nuevo.Text = "Cantidad Nuevo";
            this.Cantidad_Nuevo.Width = 101;
            // 
            // Cantidad_Seminuevo
            // 
            this.Cantidad_Seminuevo.Text = "Cantidad Seminuevo";
            this.Cantidad_Seminuevo.Width = 101;
            // 
            // Precio_Nuevo
            // 
            this.Precio_Nuevo.Text = "Precio Nuevo";
            this.Precio_Nuevo.Width = 93;
            // 
            // Precio_Seminuevo
            // 
            this.Precio_Seminuevo.Text = "Precio Seminuevo";
            this.Precio_Seminuevo.Width = 104;
            // 
            // Reporte_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interfaz_de_usuario.Properties.Resources.blurry_blue_background_ii_wallpaper_800x480;
            this.ClientSize = new System.Drawing.Size(797, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte_Inventario";
            this.Text = "Reporte Inventario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID_Producto;
        private System.Windows.Forms.ColumnHeader nombre_producto;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Precio_Nuevo;
        private System.Windows.Forms.ColumnHeader Cantidad_Nuevo;
        private System.Windows.Forms.ColumnHeader Precio_Seminuevo;
        private System.Windows.Forms.ColumnHeader Cantidad_Seminuevo;
        private System.Windows.Forms.Button button1;
    }
}