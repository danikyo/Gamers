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
    public partial class ReportesVentaCompra : Form
    {
        Class_.Connection Connection;

        public ReportesVentaCompra(Class_.Connection Connection)
        {
            InitializeComponent();

            this.Connection = Connection;
        }

        private void ReportesVentaCompra_Load(object sender, EventArgs e)
        {
            LoadDataActive();
            LoadDataBuy();
        }

        private void buttonConsultarVenta_Click(object sender, EventArgs e)
        {
            Consulta_Venta reporte_venta = new Consulta_Venta(Connection, dataGridViewVenta.CurrentRow.Cells[0].Value.ToString());
            reporte_venta.ShowDialog();
            LoadDataActive();
        }

        private void buttonConsultarCompra_Click(object sender, EventArgs e)
        {
            Consulta_Compra reporte_compra = new Consulta_Compra(Connection, dataGridViewCompra.CurrentRow.Cells[0].Value.ToString());
            reporte_compra.ShowDialog();
            LoadDataBuy();
        }

        private void LoadDataBuy()
        {
            Connection.OpenConnection();
            dataGridViewCompra.DataSource = Class_.Venta.MostrarCompras(Connection.myConnection);
            Connection.CloseConnection();

            dataGridViewCompra.Columns[2].Visible = false;
            dataGridViewCompra.Columns[3].Visible = false;
            dataGridViewCompra.Columns[4].Visible = false;
            dataGridViewCompra.Columns[5].Visible = false;
            dataGridViewCompra.Columns[6].Visible = false;
            dataGridViewCompra.Columns[7].Visible = false;
            dataGridViewCompra.Columns[1].Width = 153;
        }

        private void LoadDataActive()
        {
            Connection.OpenConnection();
            dataGridViewVenta.DataSource = Class_.Venta.MostrarVentas(Connection.myConnection);
            Connection.CloseConnection();

            dataGridViewVenta.Columns[2].Visible = false;
            dataGridViewVenta.Columns[3].Visible = false;
            dataGridViewVenta.Columns[4].Visible = false;
            dataGridViewVenta.Columns[5].Visible = false;
            dataGridViewVenta.Columns[6].Visible = false;
            dataGridViewVenta.Columns[7].Visible = false;
            dataGridViewVenta.Columns[1].Width = 153;
        }

        private void LoadDataCancel()
        {
            Connection.OpenConnection();
            dataGridViewVenta.DataSource = Class_.Venta.MostrarVentasCanceladas(Connection.myConnection);
            Connection.CloseConnection();

            dataGridViewVenta.Columns[2].Visible = false;
            dataGridViewVenta.Columns[3].Visible = false;
            dataGridViewVenta.Columns[4].Visible = false;
            dataGridViewVenta.Columns[5].Visible = false;
            dataGridViewVenta.Columns[6].Visible = false;
            dataGridViewVenta.Columns[7].Visible = false;
            dataGridViewVenta.Columns[1].Width = 140;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataActive();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataCancel();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
