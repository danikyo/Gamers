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
    public partial class Consulta_Compra : Form
    {
        Class_.Connection Connection;
        string idSale;

        Bitmap bmp;
        PrintPreviewDialog VistaPrevia = new PrintPreviewDialog();
        PrintDialog impresora = new PrintDialog();

        public Consulta_Compra(Class_.Connection Connection, string idSale)
        {
            InitializeComponent();
            this.Connection = Connection;
            this.idSale = idSale;
        }

        private void Consulta_Compra_Load(object sender, EventArgs e)
        {
            labelFolio.Text = "Folio No. " + idSale;

            LoadForm();
            LoadDataGrid();
            dataGridView1.ClearSelection();
            LoadTotal();
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
                labelPaymentType.Text = venta.TipoPago;
                labelSaldo.Text = venta.Balance;

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

                Connection.OpenConnection();

                MySqlDataReader readerEmpleado = Class_.Empleado.BuscarEmpleado(Connection.myConnection, venta.ID_Empleado.ToString());

                if (readerEmpleado.Read())
                {
                    labelNombreEmpleado.Text = readerEmpleado.GetString(1) + " " + readerEmpleado.GetString(2);
                }
            }
            Connection.CloseConnection();
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

            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                total += (Convert.ToDecimal(Row.Cells["Importe"].Value));
            }
            labelTotal.Text = String.Format("${0}", total.ToString());
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            buttonPrint.Visible = false;
            buttonPreview.Visible = false;
            buttonRegresar.Visible = false;
            buttonCancelar.Visible = false;

            Capturaformulario();
            buttonPrint.Visible = true;
            buttonPreview.Visible = true;
            buttonRegresar.Visible = true;
            buttonCancelar.Visible = true;

            VistaPrevia.Document = printDocument1;
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

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Capturaformulario();

            impresora.Document = printDocument1;
            DialogResult Result = impresora.ShowDialog();

            if (Result == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings.Landscape = false;
                printDocument1.Print();
            }
        }
    }
}
