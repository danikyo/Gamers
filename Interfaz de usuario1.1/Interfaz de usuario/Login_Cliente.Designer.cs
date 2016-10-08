namespace Interfaz_de_usuario
{
    partial class Login_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Cliente));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.buttonVP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código del cliente";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonAceptar.Location = new System.Drawing.Point(48, 95);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(82, 23);
            this.buttonAceptar.TabIndex = 1;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(141, 30);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(138, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonRegresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRegresar.Location = new System.Drawing.Point(178, 95);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(82, 23);
            this.buttonRegresar.TabIndex = 3;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = false;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // buttonVP
            // 
            this.buttonVP.Location = new System.Drawing.Point(73, 61);
            this.buttonVP.Name = "buttonVP";
            this.buttonVP.Size = new System.Drawing.Size(167, 23);
            this.buttonVP.TabIndex = 4;
            this.buttonVP.Text = "Venta al publico";
            this.buttonVP.UseVisualStyleBackColor = true;
            this.buttonVP.Click += new System.EventHandler(this.buttonVP_Click);
            // 
            // Login_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(310, 130);
            this.Controls.Add(this.buttonVP);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Button buttonVP;
    }
}