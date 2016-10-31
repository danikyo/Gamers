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
    public partial class Menu_Factura : Form
    {
        Class_.Connection Connection;

        public Menu_Factura(Class_.Connection Connection)
        {
            InitializeComponent();

            this.Connection = Connection;
        }

        private int MaxId()
        {
            int max = 1;
            Connection.OpenConnection();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT MAX(idFactura) AS idFactura FROM factura"), Connection.myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (!reader.IsDBNull(0)) { max = reader.GetInt32(0); max++; }
            }
            Connection.CloseConnection();
            return max;
        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            MySqlDataReader reader = Class_.Factura.BuscarFactura(Connection.myConnection, textBoxConsulta.Text);
            if(reader.Read())
            {
                Class_.Factura nFactura = new Class_.Factura(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2));
                Consulta_Factura consulta_factura = new Consulta_Factura(Connection, nFactura);
                Connection.CloseConnection();
                consulta_factura.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Folio no existe");
            }
            Connection.CloseConnection();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonComprobarVenta_Click(object sender, EventArgs e)
        {
            Consulta_Venta consulta_venta = new Consulta_Venta(Connection, int.Parse(textBoxNoTicket.Text));
            consulta_venta.ShowDialog();
        }

        private void textBoxNoTicket_TextChanged(object sender, EventArgs e)
        {
            if(textBoxNoTicket.Text != "")
            {
                buttonComprobarVenta.Enabled = true;
            }
            else
            {
                buttonComprobarVenta.Enabled = false;
            }
        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Class_.Factura nFactura = new Class_.Factura(1, fecha, true);
            Class_.Factura.AgregarFactura(Connection.myConnection, nFactura);
            Connection.CloseConnection();
            MessageBox.Show("Factura Generada con exito");
            this.Close();
        }

        private void Menu_Factura_Load(object sender, EventArgs e)
        {
            labelFolio.Text = "Folio No. " + MaxId().ToString();

            Connection.OpenConnection();
            dataGridView1.DataSource = Class_.Factura.MostrarFacturas(Connection.myConnection);
            dataGridView1.Columns[2].Visible = false;
            Connection.CloseConnection();
        }
    }
}
