namespace Interfaz_de_usuario
{
    partial class Consulta_Compra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomEmpleado = new System.Windows.Forms.TextBox();
            this.groupBoxTipodePago = new System.Windows.Forms.GroupBox();
            this.comboBoxTipoPago = new System.Windows.Forms.ComboBox();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsolaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDatosCliente = new System.Windows.Forms.GroupBox();
            this.buttonComprobar = new System.Windows.Forms.Button();
            this.IDcliente = new System.Windows.Forms.Label();
            this.textBoxIDcliente = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.labelFolio = new System.Windows.Forms.Label();
            this.textBoxFolio = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxTipodePago.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNomEmpleado);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 42);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre:";
            // 
            // textBoxNomEmpleado
            // 
            this.textBoxNomEmpleado.Enabled = false;
            this.textBoxNomEmpleado.Location = new System.Drawing.Point(84, 16);
            this.textBoxNomEmpleado.Name = "textBoxNomEmpleado";
            this.textBoxNomEmpleado.Size = new System.Drawing.Size(187, 20);
            this.textBoxNomEmpleado.TabIndex = 32;
            // 
            // groupBoxTipodePago
            // 
            this.groupBoxTipodePago.Controls.Add(this.comboBoxTipoPago);
            this.groupBoxTipodePago.Location = new System.Drawing.Point(605, 78);
            this.groupBoxTipodePago.Name = "groupBoxTipodePago";
            this.groupBoxTipodePago.Size = new System.Drawing.Size(180, 74);
            this.groupBoxTipodePago.TabIndex = 67;
            this.groupBoxTipodePago.TabStop = false;
            this.groupBoxTipodePago.Text = "Tipo de pago";
            // 
            // comboBoxTipoPago
            // 
            this.comboBoxTipoPago.Enabled = false;
            this.comboBoxTipoPago.FormattingEnabled = true;
            this.comboBoxTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Electrónico"});
            this.comboBoxTipoPago.Location = new System.Drawing.Point(30, 32);
            this.comboBoxTipoPago.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxTipoPago.Name = "comboBoxTipoPago";
            this.comboBoxTipoPago.Size = new System.Drawing.Size(120, 21);
            this.comboBoxTipoPago.TabIndex = 5;
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.labelFecha);
            this.groupBoxDate.Location = new System.Drawing.Point(605, 3);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(180, 74);
            this.groupBoxDate.TabIndex = 66;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Fecha";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(37, 16);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(15, 24);
            this.labelFecha.TabIndex = 18;
            this.labelFecha.Text = ".";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(685, 403);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(574, 404);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "Total Pagado";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(131, 392);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(113, 41);
            this.buttonCancelar.TabIndex = 63;
            this.buttonCancelar.Text = "Cancelar Compra";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.NombreProducto,
            this.ConsolaProducto,
            this.CantidadProducto,
            this.PrecioProducto,
            this.ImporteProducto});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.Location = new System.Drawing.Point(12, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(773, 228);
            this.dataGridView1.TabIndex = 62;
            // 
            // IDProducto
            // 
            this.IDProducto.HeaderText = "ID producto";
            this.IDProducto.Name = "IDProducto";
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 230;
            // 
            // ConsolaProducto
            // 
            this.ConsolaProducto.HeaderText = "Status";
            this.ConsolaProducto.Name = "ConsolaProducto";
            this.ConsolaProducto.ReadOnly = true;
            // 
            // CantidadProducto
            // 
            this.CantidadProducto.HeaderText = "Cantidad";
            this.CantidadProducto.Name = "CantidadProducto";
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.HeaderText = "Precio";
            this.PrecioProducto.Name = "PrecioProducto";
            // 
            // ImporteProducto
            // 
            this.ImporteProducto.HeaderText = "Importe";
            this.ImporteProducto.Name = "ImporteProducto";
            this.ImporteProducto.ReadOnly = true;
            // 
            // groupBoxDatosCliente
            // 
            this.groupBoxDatosCliente.Controls.Add(this.buttonComprobar);
            this.groupBoxDatosCliente.Controls.Add(this.IDcliente);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxIDcliente);
            this.groupBoxDatosCliente.Controls.Add(this.labelNombre);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxNombreCliente);
            this.groupBoxDatosCliente.Controls.Add(this.labelSaldo);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxSaldo);
            this.groupBoxDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosCliente.Location = new System.Drawing.Point(14, 68);
            this.groupBoxDatosCliente.Name = "groupBoxDatosCliente";
            this.groupBoxDatosCliente.Size = new System.Drawing.Size(584, 84);
            this.groupBoxDatosCliente.TabIndex = 61;
            this.groupBoxDatosCliente.TabStop = false;
            this.groupBoxDatosCliente.Text = "Datos de cliente";
            // 
            // buttonComprobar
            // 
            this.buttonComprobar.Location = new System.Drawing.Point(26, 47);
            this.buttonComprobar.Name = "buttonComprobar";
            this.buttonComprobar.Size = new System.Drawing.Size(75, 23);
            this.buttonComprobar.TabIndex = 58;
            this.buttonComprobar.Text = "comprobar";
            this.buttonComprobar.UseVisualStyleBackColor = true;
            // 
            // IDcliente
            // 
            this.IDcliente.AutoSize = true;
            this.IDcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDcliente.Location = new System.Drawing.Point(23, 26);
            this.IDcliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDcliente.Name = "IDcliente";
            this.IDcliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IDcliente.Size = new System.Drawing.Size(20, 13);
            this.IDcliente.TabIndex = 16;
            this.IDcliente.Text = "ID";
            // 
            // textBoxIDcliente
            // 
            this.textBoxIDcliente.Enabled = false;
            this.textBoxIDcliente.Location = new System.Drawing.Point(48, 23);
            this.textBoxIDcliente.Name = "textBoxIDcliente";
            this.textBoxIDcliente.Size = new System.Drawing.Size(44, 20);
            this.textBoxIDcliente.TabIndex = 17;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(129, 29);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNombre.Size = new System.Drawing.Size(50, 13);
            this.labelNombre.TabIndex = 15;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Enabled = false;
            this.textBoxNombreCliente.Location = new System.Drawing.Point(184, 26);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(361, 20);
            this.textBoxNombreCliente.TabIndex = 19;
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.Location = new System.Drawing.Point(140, 52);
            this.labelSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSaldo.Size = new System.Drawing.Size(39, 13);
            this.labelSaldo.TabIndex = 25;
            this.labelSaldo.Text = "Saldo";
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.Enabled = false;
            this.textBoxSaldo.Location = new System.Drawing.Point(184, 49);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.Size = new System.Drawing.Size(120, 20);
            this.textBoxSaldo.TabIndex = 26;
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(14, 392);
            this.buttonRegresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(113, 41);
            this.buttonRegresar.TabIndex = 60;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // labelFolio
            // 
            this.labelFolio.AutoSize = true;
            this.labelFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFolio.Location = new System.Drawing.Point(11, 9);
            this.labelFolio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFolio.Name = "labelFolio";
            this.labelFolio.Size = new System.Drawing.Size(34, 13);
            this.labelFolio.TabIndex = 58;
            this.labelFolio.Text = "Folio";
            // 
            // textBoxFolio
            // 
            this.textBoxFolio.Location = new System.Drawing.Point(50, 4);
            this.textBoxFolio.Name = "textBoxFolio";
            this.textBoxFolio.Size = new System.Drawing.Size(37, 20);
            this.textBoxFolio.TabIndex = 70;
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(93, 7);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(38, 17);
            this.buttonOk.TabIndex = 69;
            this.buttonOk.Text = "ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // Consulta_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 436);
            this.Controls.Add(this.textBoxFolio);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTipodePago);
            this.Controls.Add(this.groupBoxDate);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxDatosCliente);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.labelFolio);
            this.Name = "Consulta_Compra";
            this.Text = "Consulta Compra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTipodePago.ResumeLayout(false);
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxDatosCliente.ResumeLayout(false);
            this.groupBoxDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomEmpleado;
        private System.Windows.Forms.GroupBox groupBoxTipodePago;
        private System.Windows.Forms.ComboBox comboBoxTipoPago;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsolaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteProducto;
        private System.Windows.Forms.GroupBox groupBoxDatosCliente;
        private System.Windows.Forms.Button buttonComprobar;
        private System.Windows.Forms.Label IDcliente;
        private System.Windows.Forms.TextBox textBoxIDcliente;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.TextBox textBoxSaldo;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Label labelFolio;
        private System.Windows.Forms.TextBox textBoxFolio;
        private System.Windows.Forms.Button buttonOk;
    }
}