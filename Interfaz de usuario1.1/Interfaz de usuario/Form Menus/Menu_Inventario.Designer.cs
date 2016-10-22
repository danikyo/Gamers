namespace Interfaz_de_usuario
{
    partial class Menu_Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Inventario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIDproducto = new System.Windows.Forms.TextBox();
            this.buttonConsultaP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxNombreP = new System.Windows.Forms.TextBox();
            this.buttonAgregarP = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxConsola = new System.Windows.Forms.ComboBox();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxReporteTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonGenerar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Interfaz_de_usuario.Properties.Resources.logook;
            this.pictureBox1.Location = new System.Drawing.Point(114, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Codigo de producto:";
            // 
            // textBoxIDproducto
            // 
            this.textBoxIDproducto.Location = new System.Drawing.Point(381, 185);
            this.textBoxIDproducto.Name = "textBoxIDproducto";
            this.textBoxIDproducto.Size = new System.Drawing.Size(136, 20);
            this.textBoxIDproducto.TabIndex = 46;
            this.textBoxIDproducto.TextChanged += new System.EventHandler(this.textBoxIDproducto_TextChanged);
            // 
            // buttonConsultaP
            // 
            this.buttonConsultaP.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultaP.Location = new System.Drawing.Point(369, 214);
            this.buttonConsultaP.Name = "buttonConsultaP";
            this.buttonConsultaP.Size = new System.Drawing.Size(158, 36);
            this.buttonConsultaP.TabIndex = 45;
            this.buttonConsultaP.Text = "Consultar Producto";
            this.buttonConsultaP.UseVisualStyleBackColor = true;
            this.buttonConsultaP.Click += new System.EventHandler(this.buttonConsultaP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Consola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nombre";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(83, 360);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrecio.TabIndex = 38;
            // 
            // textBoxNombreP
            // 
            this.textBoxNombreP.Location = new System.Drawing.Point(83, 175);
            this.textBoxNombreP.Name = "textBoxNombreP";
            this.textBoxNombreP.Size = new System.Drawing.Size(244, 20);
            this.textBoxNombreP.TabIndex = 35;
            // 
            // buttonAgregarP
            // 
            this.buttonAgregarP.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarP.Location = new System.Drawing.Point(83, 396);
            this.buttonAgregarP.Name = "buttonAgregarP";
            this.buttonAgregarP.Size = new System.Drawing.Size(160, 35);
            this.buttonAgregarP.TabIndex = 34;
            this.buttonAgregarP.Text = "Registrar Producto";
            this.buttonAgregarP.UseVisualStyleBackColor = true;
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresar.Location = new System.Drawing.Point(463, 382);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(81, 49);
            this.buttonRegresar.TabIndex = 33;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Consolas",
            "Videojuegos",
            "Accesorios"});
            this.comboBoxTipo.Location = new System.Drawing.Point(83, 209);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "Genero";
            // 
            // comboBoxConsola
            // 
            this.comboBoxConsola.FormattingEnabled = true;
            this.comboBoxConsola.Items.AddRange(new object[] {
            "Xbox",
            "Playstation",
            "Nintendo",
            "PC"});
            this.comboBoxConsola.Location = new System.Drawing.Point(83, 246);
            this.comboBoxConsola.Name = "comboBoxConsola";
            this.comboBoxConsola.Size = new System.Drawing.Size(121, 21);
            this.comboBoxConsola.TabIndex = 51;
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "Accion",
            "RPG",
            "Terror",
            "Carreras",
            "Plataforma",
            "Shooter"});
            this.comboBoxGenero.Location = new System.Drawing.Point(83, 284);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGenero.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(374, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 53;
            this.label7.Text = "Reportes:";
            // 
            // comboBoxReporteTipo
            // 
            this.comboBoxReporteTipo.FormattingEnabled = true;
            this.comboBoxReporteTipo.Items.AddRange(new object[] {
            "Consolas",
            "Videojuegos",
            "Accesorios"});
            this.comboBoxReporteTipo.Location = new System.Drawing.Point(420, 289);
            this.comboBoxReporteTipo.Name = "comboBoxReporteTipo";
            this.comboBoxReporteTipo.Size = new System.Drawing.Size(107, 21);
            this.comboBoxReporteTipo.TabIndex = 54;
            this.comboBoxReporteTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxReporteTipo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(367, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 55;
            this.label8.Text = "Tipo:";
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerar.Location = new System.Drawing.Point(370, 322);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(158, 36);
            this.buttonGenerar.TabIndex = 56;
            this.buttonGenerar.Text = "Generar";
            this.buttonGenerar.UseVisualStyleBackColor = true;
            this.buttonGenerar.Click += new System.EventHandler(this.buttonGenerar_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Nuevo",
            "Seminuevo"});
            this.comboBoxStatus.Location = new System.Drawing.Point(83, 321);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 58;
            this.label9.Text = "Status";
            // 
            // Menu_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Interfaz_de_usuario.Properties.Resources.blurry_blue_background_ii_wallpaper_800x480;
            this.ClientSize = new System.Drawing.Size(556, 443);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonGenerar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxReporteTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.comboBoxConsola);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxIDproducto);
            this.Controls.Add(this.buttonConsultaP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxNombreP);
            this.Controls.Add(this.buttonAgregarP);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_Inventario";
            this.Text = "Menu_Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIDproducto;
        private System.Windows.Forms.Button buttonConsultaP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxNombreP;
        private System.Windows.Forms.Button buttonAgregarP;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxConsola;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxReporteTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonGenerar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label9;
    }
}