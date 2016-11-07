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

namespace Interfaz_de_usuario
{
    public partial class Consulta_Venta : Form
    {
        int comprobar;
        Bitmap bmp;
        Class_.Connection Connection;
        private PrintPreviewDialog VistaPrevia = new PrintPreviewDialog();

        public Consulta_Venta(Class_.Connection Connection, int comprobar)
        {
            InitializeComponent();
            this.comprobar = comprobar;
            this.Connection = Connection;
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar()
        {
            textBoxFolio.Clear();
            textBoxIDcliente.Clear();
            textBoxIva.Clear();
            textBoxNombreCliente.Clear();
            textBoxNomEmpleado.Clear();
            textBoxSaldo.Clear();
            textBoxSubTotal.Clear();
            textBoxTotal.Clear();
            comboBoxTipoPago.Text = "";
            labelFecha.Text = "";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            MySqlDataReader readerVenta = Class_.Venta.BuscarVenta(Connection.myConnection, textBoxFolio.Text);
            if (readerVenta.Read())
            {
                Class_.Venta venta = new Class_.Venta(readerVenta.GetInt32(0), readerVenta.GetString(1), readerVenta.GetString(2), readerVenta.GetString(3), readerVenta.GetInt32(4), readerVenta.GetInt32(5), readerVenta.GetBoolean(6));

                if(venta.vc == "V" && venta.Disponible)
                {
                    string[] fecha = venta.Fecha.Split(' ');
                    labelFecha.Text = fecha[0] + "\n" + fecha[1];
                    textBoxIDcliente.Text = venta.ID_Cliente.ToString();
                    comboBoxTipoPago.Text = venta.TipoPago;
                    Connection.CloseConnection();
                    Connection.OpenConnection();

                    MySqlDataReader readerCliente = Class_.Cliente.BuscarCliente(Connection.myConnection, venta.ID_Cliente.ToString());

                    if (readerCliente.Read())
                    {
                        textBoxNombreCliente.Text = readerCliente.GetString(1) + " " + readerCliente.GetString(2);
                        textBoxSaldo.Text = readerCliente.GetString(14);
                        Connection.CloseConnection();
                    }

                    Connection.OpenConnection();

                    MySqlDataReader readerEmpleado = Class_.Empleado.BuscarEmpleado(Connection.myConnection, venta.ID_Empleado.ToString());

                    if (readerEmpleado.Read())
                    {
                        textBoxNomEmpleado.Text = readerEmpleado.GetString(1) + " " + readerEmpleado.GetString(2);
                    }
                }
                else
                {
                    if (!venta.Disponible) { MessageBox.Show("No se encontro folio"); }
                    else if (venta.vc == "C") { MessageBox.Show("Folio no es de tipo venta"); }
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Folio no encontrado");
                limpiar();
            }
            Connection.CloseConnection();
        }

        private void Consulta_Venta_Load(object sender, EventArgs e)
        {
            if(comprobar > 0)
            {
                Connection.OpenConnection();
                textBoxFolio.Text = comprobar.ToString();
                MySqlDataReader readerVenta = Class_.Venta.BuscarVenta(Connection.myConnection, textBoxFolio.Text);
                if (readerVenta.Read())
                {
                    Class_.Venta venta = new Class_.Venta(readerVenta.GetInt32(0), readerVenta.GetString(1), readerVenta.GetString(2), readerVenta.GetString(3), readerVenta.GetInt32(4), readerVenta.GetInt32(5), readerVenta.GetBoolean(6));

                    if (venta.vc == "V" && venta.Disponible)
                    {
                        string[] fecha = venta.Fecha.Split(' ');
                        labelFecha.Text = fecha[0] + "\n" + fecha[1];
                        textBoxIDcliente.Text = venta.ID_Cliente.ToString();
                        comboBoxTipoPago.Text = venta.TipoPago;
                        Connection.CloseConnection();
                        Connection.OpenConnection();

                        MySqlDataReader readerCliente = Class_.Cliente.BuscarCliente(Connection.myConnection, venta.ID_Cliente.ToString());

                        if (readerCliente.Read())
                        {
                            textBoxNombreCliente.Text = readerCliente.GetString(1) + " " + readerCliente.GetString(2);
                            textBoxSaldo.Text = readerCliente.GetString(14);
                            Connection.CloseConnection();
                        }

                        Connection.OpenConnection();

                        MySqlDataReader readerEmpleado = Class_.Empleado.BuscarEmpleado(Connection.myConnection, venta.ID_Empleado.ToString());

                        if (readerEmpleado.Read())
                        {
                            textBoxNomEmpleado.Text = readerEmpleado.GetString(1) + " " + readerEmpleado.GetString(2);
                        }
                    }
                    else
                    {
                        if (!venta.Disponible) { MessageBox.Show("No se encontro folio"); }
                        else if (venta.vc == "C") { MessageBox.Show("Folio no es de tipo venta"); }
                        limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Folio no encontrado");
                    limpiar();
                }
                Connection.CloseConnection();

                textBoxFolio.Enabled = false;
                buttonCancelar.Visible = false;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if(textBoxIDcliente.Text == "")
            {
                MessageBox.Show("Debe seleccionar un folio a eliminar");
            }
            else
            {
                DialogResult result = MessageBox.Show("Seguro que desea cancelar\nesta venta?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Connection.OpenConnection();
                    Class_.Venta.CancelarVenta(Connection.myConnection, textBoxFolio.Text);
                    Connection.CloseConnection();
                    this.Close();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Capturaformulario();

            VistaPrevia.Document = printDocument1;
            VistaPrevia.ShowDialog();
        }

        /* Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog(); */

        private void Capturaformulario()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size sz = this.ClientRectangle.Size;
            bmp = new Bitmap(sz.Width, sz.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(bmp);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            //BitBlt(dc2, 0, 0, this.ClientRectangle.Width,
                 //  this.ClientRectangle.Height, dc1, 0, 0, 13369376);
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
    }
}
