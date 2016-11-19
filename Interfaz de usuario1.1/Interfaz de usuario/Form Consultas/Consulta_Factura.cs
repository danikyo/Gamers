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
    public partial class Consulta_Factura : Form
    {
        Class_.Connection Connection;
        Class_.Factura Factura;

        public Consulta_Factura(Class_.Connection Connection, Class_.Factura Factura)
        {
            InitializeComponent();

            this.Connection = Connection;
            this.Factura = Factura;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar\neste producto?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Connection.OpenConnection();
                Class_.Factura.CancelarFactura(Connection.myConnection, labelFolioD.Text);
                Connection.CloseConnection();
                this.Close();
            }
        }

        private void Consulta_Factura_Load(object sender, EventArgs e)
        {
            if(Factura.Disponible) {
                labelCancel.Visible = false;
            }
            labelFolioD.Text = Factura.ID.ToString();
            labelFecha.Text = Factura.Fecha;
            Class_.Venta sale = LoadSale();
            LoadCustomer(sale.ID_Cliente.ToString());
            LoadDetail(sale.ID.ToString());
            dataGridView1.ClearSelection();
        }

        private Class_.Venta LoadSale()
        {
            Connection.OpenConnection();
            MySqlDataReader reader  = Class_.Venta.BuscarVenta(Connection.myConnection, Factura.ID_Venta.ToString());
            if (reader.Read())
            {
                Class_.Venta sale = new Class_.Venta(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetBoolean(4), reader.GetString(5), reader.GetInt32(6), reader.GetInt32(7));
                Connection.CloseConnection();
                return sale;
            }
            Connection.CloseConnection();
            Class_.Venta sale2 = null;
            return sale2;
        }

        private void LoadEmployee(string idEmployee)
        {
            Connection.OpenConnection();
            MySqlDataReader reader = Class_.Empleado.BuscarEmpleado(Connection.myConnection, idEmployee);
            Class_.Empleado employee = new Class_.Empleado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                reader.GetString(3), reader.GetString(4), reader.GetBoolean(5));
            labelNombreEmpleado.Text = employee.Nombre;
            Connection.CloseConnection();
        }

        private void LoadDetail(string idSale)
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

        private void LoadCustomer(string idCustomer)
        {
            Connection.OpenConnection();
            MySqlDataReader reader = Class_.Cliente.BuscarCliente(Connection.myConnection, idCustomer);
            if (reader.Read())
            {
                Class_.Cliente customer = new Class_.Cliente(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9),
                    reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetFloat(14), reader.GetBoolean(15));
                Connection.CloseConnection();
                labelNombreD.Text = customer.Nombre;
                labelApellidoD.Text = customer.Apellido;
                labelDireccionD.Text = customer.Direccion;
                string[] fecha = customer.FechaNac.Split(' ');
                labelFechaNacD.Text = fecha[0];
                labelEmailD.Text = customer.E_mail;
                labelTelD.Text = customer.Tel;
                labelRFCD.Text = customer.RFC;
                labelRazonSocD.Text = customer.RazonSocial;
                labelDomicilioFiscD.Text = customer.DomFiscal;
                labelCPD.Text = customer.CP;
                labelPaisD.Text = customer.Pais;
                labelEstadoD.Text = customer.Estado;
                labelMunicipioD.Text = customer.Municipio;
            }
        }
    }
}
