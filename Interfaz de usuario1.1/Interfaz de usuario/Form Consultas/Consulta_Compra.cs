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
    public partial class Consulta_Compra : Form
    {
        Class_.Connection Connection;

        public Consulta_Compra(Class_.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            MySqlDataReader readerVenta = Class_.Venta.BuscarVenta(Connection.myConnection, textBoxFolio.Text);
            if (readerVenta.Read())
            {
                Class_.Venta venta = new Class_.Venta(readerVenta.GetInt32(0), readerVenta.GetString(1), readerVenta.GetString(2), readerVenta.GetString(3), readerVenta.GetInt32(4), readerVenta.GetInt32(5), readerVenta.GetBoolean(6));

                if (venta.vc == "C" && venta.Disponible)
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
                    else if (venta.vc == "V") { MessageBox.Show("Folio no es de tipo compra"); }
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

        private void limpiar()
        {
            textBoxFolio.Clear();
            textBoxIDcliente.Clear();
            textBoxNombreCliente.Clear();
            textBoxNomEmpleado.Clear();
            textBoxSaldo.Clear();
            textBoxTotal.Clear();
            comboBoxTipoPago.Text = "";
            labelFecha.Text = "";
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (textBoxIDcliente.Text == "")
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
    }
}
