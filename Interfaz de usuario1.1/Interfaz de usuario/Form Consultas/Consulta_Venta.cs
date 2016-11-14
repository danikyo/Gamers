using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;

namespace Interfaz_de_usuario
{
    public partial class Consulta_Venta : Form
    { 
        string idSale;
        string saldo;

        Bitmap bmp;
        Class_.Connection Connection;
        PrintPreviewDialog VistaPrevia = new PrintPreviewDialog();
        PrintDialog impresora = new PrintDialog();

        public Consulta_Venta(Class_.Connection Connection, string idSale)
        {
            InitializeComponent();
            this.Connection = Connection;
            this.idSale = idSale;
        }

        private void Consulta_Venta_Load(object sender, EventArgs e)
        {
            labelFolio.Text = "Folio No. " + idSale;

            LoadForm();
            LoadDataGrid();
            dataGridView1.ClearSelection();
            LoadTotal();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show("Seguro que desea cancelar\nesta venta?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Connection.OpenConnection();
                    Class_.Venta.CancelarVenta(Connection.myConnection, idSale);
                    Connection.CloseConnection();
                    this.Close();
                }
        }

        private void LoadDataGrid()
        {
            Connection.OpenConnection();
            MySqlDataAdapter adapter = Class_.SaleDetail.ShowDetail(Connection.myConnection, idSale);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "detalleventa");
            dataGridView1.DataSource = dataset;
            dataGridView1.DataMember = "detalleventa";
            dataGridView1.Columns[1].Width = 270;
            Connection.CloseConnection();
        }

        private void LoadTotal()
        {
            decimal total = 0;
            double subTotal = 0;
            double IVA = 0;

            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                total += (Convert.ToDecimal(Row.Cells["Importe"].Value));
            }

            subTotal = Convert.ToDouble(total) / 1.16;
            subTotal = Math.Round(subTotal, 1);

            IVA = Convert.ToDouble(total) - subTotal;
            IVA = Math.Round(IVA, 1);
        
            labelIva.Text = "$" + IVA.ToString();
            labelSubTotal.Text = "$" + subTotal.ToString();
            labelTotal.Text = "$"+total.ToString();
            labelSaldoUsado.Text = "$" + saldo;
            labelTotalTotal.Text = "$" + (total - decimal.Parse(saldo));
        }

        private void LoadForm()
        {
            Connection.OpenConnection();
            MySqlDataReader readerVenta = Class_.Venta.BuscarVenta(Connection.myConnection, idSale);
            if (readerVenta.Read())
            {
                Class_.Venta venta = new Class_.Venta(readerVenta.GetInt32(0), readerVenta.GetString(1), readerVenta.GetString(2), readerVenta.GetString(3), readerVenta.GetBoolean(4), readerVenta.GetString(5), readerVenta.GetInt32(6), readerVenta.GetInt32(7));

                string[] fecha = venta.Fecha.Split(' ');
                labelFecha.Text = fecha[0] + "\n" + fecha[1];

                labelIDcliente.Text = venta.ID_Cliente.ToString();
                labelTipoPago.Text = venta.TipoPago;
                labelSaldo.Text = venta.Balance;
                saldo = venta.Balance;

                Connection.CloseConnection();
                Connection.OpenConnection();

                MySqlDataReader readerCliente = Class_.Cliente.BuscarCliente(Connection.myConnection, venta.ID_Cliente.ToString());

                if (readerCliente.Read())
                {
                    labelNombreCliente.Text = readerCliente.GetString(1) + " " + readerCliente.GetString(2);
                    labelAdress.Text = readerCliente.GetString(3);
                    labelTel.Text = readerCliente.GetString(6);
                    labelEmail.Text = readerCliente.GetString(5);

                    Connection.CloseConnection();
                }
                Connection.CloseConnection();

                Connection.OpenConnection();

                MySqlDataReader readerEmpleado = Class_.Empleado.BuscarEmpleado(Connection.myConnection, venta.ID_Empleado.ToString());

                if (readerEmpleado.Read())
                {
                    labelNombreEmpleado.Text = readerEmpleado.GetString(1) + " " + readerEmpleado.GetString(2);
                }
            }
            Connection.CloseConnection();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            buttonPrint.Visible = false;
            buttonPrint2.Visible = false;
            buttonRegresar.Visible = false;
            buttonCancelar.Visible = false;

            Capturaformulario();
            buttonPrint.Visible = true;
            buttonPrint2.Visible = true;
            buttonRegresar.Visible = true;
            buttonCancelar.Visible = true;

            VistaPrevia.Document = printDocument2;
            VistaPrevia.ShowDialog();
        }

        private void Capturaformulario()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size sz = this.ClientRectangle.Size;
            bmp = new Bitmap(sz.Width, sz.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(bmp);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width,
                   this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest,
            int nXDest,
            int nYDest,
            int nWidth,
            int nHeight,
            IntPtr hdcSrc,
            int nXSrc,
            int nYSrc,
            int dwRop);

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);
        }

        private void buttonPrint2_Click(object sender, EventArgs e)
        {
            Capturaformulario();

            impresora.Document = printDocument2;
            DialogResult Result = impresora.ShowDialog();

            if (Result == DialogResult.OK)
            {
                printDocument2.DefaultPageSettings.Landscape = false;
                printDocument2.Print();
            }
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
