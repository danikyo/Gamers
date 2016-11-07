namespace Interfaz_de_usuario
{
    partial class Consulta_Venta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Venta));
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxIva = new System.Windows.Forms.TextBox();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsolaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxTipodePago = new System.Windows.Forms.GroupBox();
            this.comboBoxTipoPago = new System.Windows.Forms.ComboBox();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomEmpleado = new System.Windows.Forms.TextBox();
            this.groupBoxDatosCliente = new System.Windows.Forms.GroupBox();
            this.IDcliente = new System.Windows.Forms.Label();
            this.textBoxIDcliente = new System.Windows.Forms.TextBox();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.labelFolio = new System.Windows.Forms.Label();
            this.textBoxFolio = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxTipodePago.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(694, 462);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(90, 20);
            this.textBoxTotal.TabIndex = 49;
            // 
            // textBoxIva
            // 
            this.textBoxIva.Enabled = false;
            this.textBoxIva.Location = new System.Drawing.Point(694, 432);
            this.textBoxIva.Name = "textBoxIva";
            this.textBoxIva.Size = new System.Drawing.Size(90, 20);
            this.textBoxIva.TabIndex = 48;
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Enabled = false;
            this.textBoxSubTotal.Location = new System.Drawing.Point(694, 400);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.Size = new System.Drawing.Size(90, 20);
            this.textBoxSubTotal.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(649, 433);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "Iva";
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(14, 432);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(103, 51);
            this.buttonRegresar.TabIndex = 44;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.NombreProducto,
            this.ConsolaProducto,
            this.CantidadProducto,
            this.PrecioProducto,
            this.ImporteProducto});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(11, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(773, 228);
            this.dataGridView1.TabIndex = 43;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(602, 404);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Sub Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(635, 463);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Total";
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(116, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(38, 17);
            this.buttonOk.TabIndex = 52;
            this.buttonOk.Text = "ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBoxTipodePago
            // 
            this.groupBoxTipodePago.Controls.Add(this.comboBoxTipoPago);
            this.groupBoxTipodePago.Location = new System.Drawing.Point(614, 83);
            this.groupBoxTipodePago.Name = "groupBoxTipodePago";
            this.groupBoxTipodePago.Size = new System.Drawing.Size(180, 74);
            this.groupBoxTipodePago.TabIndex = 57;
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
            this.groupBoxDate.Location = new System.Drawing.Point(614, 3);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(180, 74);
            this.groupBoxDate.TabIndex = 56;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxNomEmpleado);
            this.groupBox1.Location = new System.Drawing.Point(11, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 42);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nombre:";
            // 
            // textBoxNomEmpleado
            // 
            this.textBoxNomEmpleado.Enabled = false;
            this.textBoxNomEmpleado.Location = new System.Drawing.Point(84, 16);
            this.textBoxNomEmpleado.Name = "textBoxNomEmpleado";
            this.textBoxNomEmpleado.Size = new System.Drawing.Size(187, 20);
            this.textBoxNomEmpleado.TabIndex = 32;
            // 
            // groupBoxDatosCliente
            // 
            this.groupBoxDatosCliente.Controls.Add(this.IDcliente);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxIDcliente);
            this.groupBoxDatosCliente.Controls.Add(this.labelNombreCliente);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxNombreCliente);
            this.groupBoxDatosCliente.Controls.Add(this.labelSaldo);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxSaldo);
            this.groupBoxDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosCliente.Location = new System.Drawing.Point(11, 73);
            this.groupBoxDatosCliente.Name = "groupBoxDatosCliente";
            this.groupBoxDatosCliente.Size = new System.Drawing.Size(584, 84);
            this.groupBoxDatosCliente.TabIndex = 59;
            this.groupBoxDatosCliente.TabStop = false;
            this.groupBoxDatosCliente.Text = "Datos de Cliente";
            // 
            // IDcliente
            // 
            this.IDcliente.AutoSize = true;
            this.IDcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDcliente.Location = new System.Drawing.Point(16, 25);
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
            this.textBoxIDcliente.Location = new System.Drawing.Point(45, 22);
            this.textBoxIDcliente.Name = "textBoxIDcliente";
            this.textBoxIDcliente.Size = new System.Drawing.Size(58, 20);
            this.textBoxIDcliente.TabIndex = 17;
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCliente.Location = new System.Drawing.Point(158, 25);
            this.labelNombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNombreCliente.Size = new System.Drawing.Size(50, 13);
            this.labelNombreCliente.TabIndex = 15;
            this.labelNombreCliente.Text = "Nombre";
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Enabled = false;
            this.textBoxNombreCliente.Location = new System.Drawing.Point(217, 22);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(206, 20);
            this.textBoxNombreCliente.TabIndex = 19;
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.Location = new System.Drawing.Point(169, 55);
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
            this.textBoxSaldo.Location = new System.Drawing.Point(217, 52);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.Size = new System.Drawing.Size(120, 20);
            this.textBoxSaldo.TabIndex = 26;
            // 
            // labelFolio
            // 
            this.labelFolio.AutoSize = true;
            this.labelFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFolio.Location = new System.Drawing.Point(8, 3);
            this.labelFolio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFolio.Name = "labelFolio";
            this.labelFolio.Size = new System.Drawing.Size(62, 13);
            this.labelFolio.TabIndex = 58;
            this.labelFolio.Text = "Folio No. ";
            // 
            // textBoxFolio
            // 
            this.textBoxFolio.Location = new System.Drawing.Point(73, 2);
            this.textBoxFolio.Name = "textBoxFolio";
            this.textBoxFolio.Size = new System.Drawing.Size(37, 20);
            this.textBoxFolio.TabIndex = 61;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(123, 432);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(103, 51);
            this.buttonCancelar.TabIndex = 62;
            this.buttonCancelar.Text = "Cancelar\r\nVenta";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(232, 459);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 63;
            this.buttonPrint.Text = "Imprimir";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Consulta_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 490);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxFolio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDatosCliente);
            this.Controls.Add(this.labelFolio);
            this.Controls.Add(this.groupBoxTipodePago);
            this.Controls.Add(this.groupBoxDate);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxIva);
            this.Controls.Add(this.textBoxSubTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Consulta_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Venta";
            this.Load += new System.EventHandler(this.Consulta_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxTipodePago.ResumeLayout(false);
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDatosCliente.ResumeLayout(false);
            this.groupBoxDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxIva;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsolaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBoxTipodePago;
        private System.Windows.Forms.ComboBox comboBoxTipoPago;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomEmpleado;
        private System.Windows.Forms.GroupBox groupBoxDatosCliente;
        private System.Windows.Forms.Label IDcliente;
        private System.Windows.Forms.TextBox textBoxIDcliente;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.TextBox textBoxSaldo;
        private System.Windows.Forms.Label labelFolio;
        private System.Windows.Forms.TextBox textBoxFolio;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}