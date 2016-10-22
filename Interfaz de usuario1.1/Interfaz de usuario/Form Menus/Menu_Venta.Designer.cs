namespace Interfaz_de_usuario
{
    partial class Menu_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Venta));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTipoPago = new System.Windows.Forms.ComboBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelFolio = new System.Windows.Forms.Label();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.IDcliente = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEmpleado = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.textBoxIva = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.groupBoxDatosCliente = new System.Windows.Forms.GroupBox();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsolaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 474);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(623, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de pago";
            // 
            // comboBoxTipoPago
            // 
            this.comboBoxTipoPago.FormattingEnabled = true;
            this.comboBoxTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Electrónico"});
            this.comboBoxTipoPago.Location = new System.Drawing.Point(627, 88);
            this.comboBoxTipoPago.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxTipoPago.Name = "comboBoxTipoPago";
            this.comboBoxTipoPago.Size = new System.Drawing.Size(120, 21);
            this.comboBoxTipoPago.TabIndex = 5;
            this.comboBoxTipoPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(673, 459);
            this.buttonConfirmar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(113, 35);
            this.buttonConfirmar.TabIndex = 7;
            this.buttonConfirmar.Text = "Confirmar Venta";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(667, 412);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Monto: ";
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(731, 414);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(55, 20);
            this.textBoxMonto.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 412);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sub Total: ";
            // 
            // labelFolio
            // 
            this.labelFolio.AutoSize = true;
            this.labelFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFolio.Location = new System.Drawing.Point(12, 9);
            this.labelFolio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFolio.Name = "labelFolio";
            this.labelFolio.Size = new System.Drawing.Size(47, 16);
            this.labelFolio.TabIndex = 0;
            this.labelFolio.Text = "Folio:";
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCliente.Location = new System.Drawing.Point(145, 26);
            this.labelNombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNombreCliente.Size = new System.Drawing.Size(67, 16);
            this.labelNombreCliente.TabIndex = 15;
            this.labelNombreCliente.Text = "Nombre:";
            // 
            // IDcliente
            // 
            this.IDcliente.AutoSize = true;
            this.IDcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDcliente.Location = new System.Drawing.Point(5, 22);
            this.IDcliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDcliente.Name = "IDcliente";
            this.IDcliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IDcliente.Size = new System.Drawing.Size(77, 16);
            this.IDcliente.TabIndex = 16;
            this.IDcliente.Text = "ID cliente:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(87, 22);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(44, 20);
            this.textBoxID.TabIndex = 17;
            this.textBoxID.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(624, 9);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(55, 16);
            this.labelFecha.TabIndex = 18;
            this.labelFecha.Text = "Fecha:";
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(217, 26);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(361, 20);
            this.textBoxNombreCliente.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Empleado:";
            // 
            // comboBoxEmpleado
            // 
            this.comboBoxEmpleado.FormattingEnabled = true;
            this.comboBoxEmpleado.Items.AddRange(new object[] {
            "Daniel Mitchel",
            "Edgar Casillas"});
            this.comboBoxEmpleado.Location = new System.Drawing.Point(102, 135);
            this.comboBoxEmpleado.Name = "comboBoxEmpleado";
            this.comboBoxEmpleado.Size = new System.Drawing.Size(125, 21);
            this.comboBoxEmpleado.TabIndex = 21;
            this.comboBoxEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.NombreProducto,
            this.ConsolaProducto,
            this.CantidadProducto,
            this.PrecioProducto,
            this.ImporteProducto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(773, 228);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(15, 442);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(103, 51);
            this.buttonRegresar.TabIndex = 23;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(124, 442);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(103, 51);
            this.buttonLimpiar.TabIndex = 24;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.Location = new System.Drawing.Point(159, 53);
            this.labelSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSaldo.Size = new System.Drawing.Size(53, 16);
            this.labelSaldo.TabIndex = 25;
            this.labelSaldo.Text = "Saldo:";
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.Location = new System.Drawing.Point(217, 52);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.Size = new System.Drawing.Size(120, 20);
            this.textBoxSaldo.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(505, 442);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Iva: ";
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Location = new System.Drawing.Point(553, 412);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.Size = new System.Drawing.Size(90, 20);
            this.textBoxSubTotal.TabIndex = 28;
            // 
            // textBoxIva
            // 
            this.textBoxIva.Location = new System.Drawing.Point(553, 444);
            this.textBoxIva.Name = "textBoxIva";
            this.textBoxIva.Size = new System.Drawing.Size(90, 20);
            this.textBoxIva.TabIndex = 29;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(553, 474);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(90, 20);
            this.textBoxTotal.TabIndex = 30;
            // 
            // groupBoxDatosCliente
            // 
            this.groupBoxDatosCliente.Controls.Add(this.IDcliente);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxID);
            this.groupBoxDatosCliente.Controls.Add(this.labelNombreCliente);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxNombreCliente);
            this.groupBoxDatosCliente.Controls.Add(this.labelSaldo);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxSaldo);
            this.groupBoxDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosCliente.Location = new System.Drawing.Point(15, 37);
            this.groupBoxDatosCliente.Name = "groupBoxDatosCliente";
            this.groupBoxDatosCliente.Size = new System.Drawing.Size(584, 84);
            this.groupBoxDatosCliente.TabIndex = 31;
            this.groupBoxDatosCliente.TabStop = false;
            this.groupBoxDatosCliente.Text = "Datos de cliente";
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
            // Menu_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(797, 506);
            this.Controls.Add(this.groupBoxDatosCliente);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxIva);
            this.Controls.Add(this.textBoxSubTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.comboBoxTipoPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFolio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Menu_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaccion Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxDatosCliente.ResumeLayout(false);
            this.groupBoxDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTipoPago;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelFolio;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.Label IDcliente;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEmpleado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.TextBox textBoxSaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.TextBox textBoxIva;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.GroupBox groupBoxDatosCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsolaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteProducto;
    }
}