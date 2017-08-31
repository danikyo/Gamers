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
            MySqlDataReader reader = Class_.Factura.BuscarFactura(Connection.myConnection, dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if(reader.Read())
            {
                Class_.Factura nFactura = new Class_.Factura(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2), reader.GetInt32(3));
                Consulta_Factura consulta_factura = new Consulta_Factura(Connection, nFactura);
                Connection.CloseConnection();
                consulta_factura.ShowDialog();
                LoadDataActive();
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
            Consulta_Venta consulta_venta = new Consulta_Venta(Connection, dataGridViewVenta.CurrentRow.Cells[0].Value.ToString());
            consulta_venta.ShowDialog();
        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            if (!Repetido(dataGridViewVenta.CurrentRow.Cells[0].Value.ToString()))
            {
                Connection.OpenConnection();
                string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                Class_.Factura nFactura = new Class_.Factura(1, fecha, true, Convert.ToInt32(dataGridViewVenta.CurrentRow.Cells[0].Value));
                Class_.Factura.AgregarFactura(Connection.myConnection, nFactura);
                Connection.CloseConnection();
                MessageBox.Show("Factura Generada con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ya se ha facturado esta venta");
            }
        }

        private bool Repetido(string idSale)
        {
            bool flag = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells[3].Value.ToString() == idSale)
                {
                    flag = true;
                }
            }

            return flag;
        }

        private void Menu_Factura_Load(object sender, EventArgs e)
        {
            labelFolio.Text = "Folio No. " + MaxId().ToString();

            LoadDataSale();
            LoadDataActive();
        }

        private void LoadDataSale()
        {
            Connection.OpenConnection();
            dataGridViewVenta.DataSource = Class_.Venta.MostrarVentas(Connection.myConnection);
            Connection.CloseConnection();
        }

        private void LoadDataActive()
        {
            Connection.OpenConnection();
            dataGridView1.DataSource = Class_.Factura.MostrarFacturas(Connection.myConnection);
            dataGridView1.Columns[2].Visible = false;
            Connection.CloseConnection();
        }

        private void LoadDataCancel()
        {
            Connection.OpenConnection();
            dataGridView1.DataSource = Class_.Factura.MostrarFacturasCancel(Connection.myConnection);
            dataGridView1.Columns[2].Visible = false;
            Connection.CloseConnection();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataCancel();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataActive();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
