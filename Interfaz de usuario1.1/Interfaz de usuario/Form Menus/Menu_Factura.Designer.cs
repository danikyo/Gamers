namespace Interfaz_de_usuario
{
    partial class Menu_Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Factura));
            this.buttonGenerar = new System.Windows.Forms.Button();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.textBoxConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.Location = new System.Drawing.Point(25, 166);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(87, 35);
            this.buttonGenerar.TabIndex = 0;
            this.buttonGenerar.Text = "Generar";
            this.buttonGenerar.UseVisualStyleBackColor = true;
            this.buttonGenerar.Click += new System.EventHandler(this.buttonGenerar_Click);
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.Location = new System.Drawing.Point(20, 69);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(87, 22);
            this.buttonConsulta.TabIndex = 2;
            this.buttonConsulta.Text = "Consultar";
            this.buttonConsulta.UseVisualStyleBackColor = true;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(372, 186);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(87, 21);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Regresar";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // textBoxConsulta
            // 
            this.textBoxConsulta.Location = new System.Drawing.Point(20, 43);
            this.textBoxConsulta.Name = "textBoxConsulta";
            this.textBoxConsulta.Size = new System.Drawing.Size(100, 20);
            this.textBoxConsulta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "No. Factura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(22, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "No. Ticket:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(22, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Empleado:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(147, 122);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(120, 20);
            this.textBox7.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Interfaz_de_usuario.Properties.Resources.logook;
            this.pictureBox1.Location = new System.Drawing.Point(170, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonConsulta);
            this.groupBox1.Controls.Add(this.textBoxConsulta);
            this.groupBox1.Location = new System.Drawing.Point(308, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta Factura";
            // 
            // Menu_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(471, 219);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonGenerar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_Factura";
            this.Text = "Menu Factura";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerar;
        private System.Windows.Forms.Button buttonConsulta;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.TextBox textBoxConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}