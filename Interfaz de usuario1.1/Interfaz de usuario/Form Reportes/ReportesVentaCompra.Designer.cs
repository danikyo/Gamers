namespace Interfaz_de_usuario
{
    partial class ReportesVentaCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCompra = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewVenta = new System.Windows.Forms.DataGridView();
            this.groupBoxCompra = new System.Windows.Forms.GroupBox();
            this.buttonConsultarVenta = new System.Windows.Forms.Button();
            this.buttonConsultarCompra = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).BeginInit();
            this.groupBoxCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCompra
            // 
            this.dataGridViewCompra.AllowUserToResizeRows = false;
            this.dataGridViewCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCompra.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCompra.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewCompra.Name = "dataGridViewCompra";
            this.dataGridViewCompra.ReadOnly = true;
            this.dataGridViewCompra.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewCompra.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCompra.Size = new System.Drawing.Size(409, 237);
            this.dataGridViewCompra.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewVenta);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 262);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registros de Venta";
            // 
            // dataGridViewVenta
            // 
            this.dataGridViewVenta.AllowUserToResizeRows = false;
            this.dataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewVenta.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewVenta.Name = "dataGridViewVenta";
            this.dataGridViewVenta.ReadOnly = true;
            this.dataGridViewVenta.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewVenta.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVenta.Size = new System.Drawing.Size(409, 237);
            this.dataGridViewVenta.TabIndex = 1;
            // 
            // groupBoxCompra
            // 
            this.groupBoxCompra.BackColor = System.Drawing.Color.Black;
            this.groupBoxCompra.Controls.Add(this.dataGridViewCompra);
            this.groupBoxCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxCompra.Location = new System.Drawing.Point(473, 115);
            this.groupBoxCompra.Name = "groupBoxCompra";
            this.groupBoxCompra.Size = new System.Drawing.Size(421, 262);
            this.groupBoxCompra.TabIndex = 2;
            this.groupBoxCompra.TabStop = false;
            this.groupBoxCompra.Text = "Registros de Compra";
            // 
            // buttonConsultarVenta
            // 
            this.buttonConsultarVenta.Location = new System.Drawing.Point(135, 86);
            this.buttonConsultarVenta.Name = "buttonConsultarVenta";
            this.buttonConsultarVenta.Size = new System.Drawing.Size(182, 23);
            this.buttonConsultarVenta.TabIndex = 3;
            this.buttonConsultarVenta.Text = "Consultar Venta";
            this.buttonConsultarVenta.UseVisualStyleBackColor = true;
            this.buttonConsultarVenta.Click += new System.EventHandler(this.buttonConsultarVenta_Click);
            // 
            // buttonConsultarCompra
            // 
            this.buttonConsultarCompra.Location = new System.Drawing.Point(597, 86);
            this.buttonConsultarCompra.Name = "buttonConsultarCompra";
            this.buttonConsultarCompra.Size = new System.Drawing.Size(182, 23);
            this.buttonConsultarCompra.TabIndex = 4;
            this.buttonConsultarCompra.Text = "Consultar Compra";
            this.buttonConsultarCompra.UseVisualStyleBackColor = true;
            this.buttonConsultarCompra.Click += new System.EventHandler(this.buttonConsultarCompra_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Interfaz_de_usuario.Properties.Resources.logook;
            this.pictureBox2.Location = new System.Drawing.Point(329, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(259, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(819, 12);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegresar.TabIndex = 40;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // ReportesVentaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(906, 389);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonConsultarCompra);
            this.Controls.Add(this.buttonConsultarVenta);
            this.Controls.Add(this.groupBoxCompra);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportesVentaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.ReportesVentaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).EndInit();
            this.groupBoxCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCompra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewVenta;
        private System.Windows.Forms.GroupBox groupBoxCompra;
        private System.Windows.Forms.Button buttonConsultarVenta;
        private System.Windows.Forms.Button buttonConsultarCompra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonRegresar;
    }
}