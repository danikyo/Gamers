namespace Interfaz_de_usuario
{
    partial class Menu_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Empleado));
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.textBoxApellidosE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxCPassword = new System.Windows.Forms.TextBox();
            this.textBoxNombreE = new System.Windows.Forms.TextBox();
            this.buttonAgregarE = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.buttonConsultaE = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxPuesto = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewEmpleado = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelIDempleado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresar.Location = new System.Drawing.Point(405, 352);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(158, 74);
            this.buttonRegresar.TabIndex = 9;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // textBoxApellidosE
            // 
            this.textBoxApellidosE.Location = new System.Drawing.Point(84, 90);
            this.textBoxApellidosE.Name = "textBoxApellidosE";
            this.textBoxApellidosE.Size = new System.Drawing.Size(244, 20);
            this.textBoxApellidosE.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Puesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre/s";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(84, 162);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(208, 20);
            this.textBoxPassword.TabIndex = 4;
            // 
            // textBoxCPassword
            // 
            this.textBoxCPassword.Location = new System.Drawing.Point(84, 196);
            this.textBoxCPassword.Name = "textBoxCPassword";
            this.textBoxCPassword.PasswordChar = '*';
            this.textBoxCPassword.Size = new System.Drawing.Size(208, 20);
            this.textBoxCPassword.TabIndex = 5;
            // 
            // textBoxNombreE
            // 
            this.textBoxNombreE.Location = new System.Drawing.Point(84, 52);
            this.textBoxNombreE.Name = "textBoxNombreE";
            this.textBoxNombreE.Size = new System.Drawing.Size(244, 20);
            this.textBoxNombreE.TabIndex = 1;
            // 
            // buttonAgregarE
            // 
            this.buttonAgregarE.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAgregarE.Location = new System.Drawing.Point(84, 231);
            this.buttonAgregarE.Name = "buttonAgregarE";
            this.buttonAgregarE.Size = new System.Drawing.Size(160, 35);
            this.buttonAgregarE.TabIndex = 6;
            this.buttonAgregarE.Text = "Registrar";
            this.buttonAgregarE.UseVisualStyleBackColor = true;
            this.buttonAgregarE.Click += new System.EventHandler(this.buttonAgregarE_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 30);
            this.label4.TabIndex = 29;
            this.label4.Text = "Confirmar\r\ncontraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Codigo de empleado:";
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Location = new System.Drawing.Point(45, 49);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(136, 20);
            this.textBoxQuery.TabIndex = 7;
            this.textBoxQuery.TextChanged += new System.EventHandler(this.textBoxIDEmpleado_TextChanged);
            // 
            // buttonConsultaE
            // 
            this.buttonConsultaE.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultaE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConsultaE.Location = new System.Drawing.Point(33, 78);
            this.buttonConsultaE.Name = "buttonConsultaE";
            this.buttonConsultaE.Size = new System.Drawing.Size(158, 36);
            this.buttonConsultaE.TabIndex = 8;
            this.buttonConsultaE.Text = "Consultar Empleado";
            this.buttonConsultaE.UseVisualStyleBackColor = true;
            this.buttonConsultaE.Click += new System.EventHandler(this.buttonConsultaE_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelIDempleado);
            this.groupBox1.Controls.Add(this.comboBoxPuesto);
            this.groupBox1.Controls.Add(this.textBoxNombreE);
            this.groupBox1.Controls.Add(this.buttonAgregarE);
            this.groupBox1.Controls.Add(this.textBoxCPassword);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxApellidosE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 274);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Empleado";
            // 
            // comboBoxPuesto
            // 
            this.comboBoxPuesto.FormattingEnabled = true;
            this.comboBoxPuesto.Items.AddRange(new object[] {
            "Gerente",
            "Cajero"});
            this.comboBoxPuesto.Location = new System.Drawing.Point(84, 129);
            this.comboBoxPuesto.Name = "comboBoxPuesto";
            this.comboBoxPuesto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPuesto.TabIndex = 3;
            this.comboBoxPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxPuesto_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonConsultaE);
            this.groupBox2.Controls.Add(this.textBoxQuery);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(368, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 139);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edición Empleado";
            // 
            // dataGridViewEmpleado
            // 
            this.dataGridViewEmpleado.AllowUserToResizeRows = false;
            this.dataGridViewEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleado.Location = new System.Drawing.Point(607, 173);
            this.dataGridViewEmpleado.Name = "dataGridViewEmpleado";
            this.dataGridViewEmpleado.ReadOnly = true;
            this.dataGridViewEmpleado.RowHeadersVisible = false;
            this.dataGridViewEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmpleado.Size = new System.Drawing.Size(441, 251);
            this.dataGridViewEmpleado.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(608, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Registros";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 32);
            this.label8.TabIndex = 37;
            this.label8.Text = "BIENVENIDO AL \r\nMENU DE EMPLEADO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Interfaz_de_usuario.Properties.Resources.logook;
            this.pictureBox2.Location = new System.Drawing.Point(409, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(336, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // labelIDempleado
            // 
            this.labelIDempleado.AutoSize = true;
            this.labelIDempleado.BackColor = System.Drawing.Color.Transparent;
            this.labelIDempleado.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDempleado.Location = new System.Drawing.Point(147, 21);
            this.labelIDempleado.Name = "labelIDempleado";
            this.labelIDempleado.Size = new System.Drawing.Size(48, 18);
            this.labelIDempleado.TabIndex = 30;
            this.labelIDempleado.Text = "ID X";
            // 
            // Menu_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Interfaz_de_usuario.Properties.Resources.WallpaperPacman;
            this.ClientSize = new System.Drawing.Size(1058, 436);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewEmpleado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRegresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Empleado";
            this.Load += new System.EventHandler(this.Menu_Empleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.TextBox textBoxApellidosE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxCPassword;
        private System.Windows.Forms.TextBox textBoxNombreE;
        private System.Windows.Forms.Button buttonAgregarE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Button buttonConsultaE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxPuesto;
        private System.Windows.Forms.DataGridView dataGridViewEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelIDempleado;
    }
}