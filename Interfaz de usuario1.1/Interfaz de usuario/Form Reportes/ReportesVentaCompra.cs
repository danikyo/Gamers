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
            Connection.OpenConnection();
            dataGridViewCompra.DataSource = Class_.Venta.MostrarCompras(Connection.myConnection);
            Connection.CloseConnection();

            Connection.OpenConnection();
            dataGridViewVenta.DataSource = Class_.Venta.MostrarVentas(Connection.myConnection);
            Connection.CloseConnection();
        }

        private void buttonConsultarVenta_Click(object sender, EventArgs e)
        {
            Consulta_Venta reporte_venta = new Consulta_Venta(Connection, 0);
            reporte_venta.ShowDialog();
            this.Close();
        }

        private void buttonConsultarCompra_Click(object sender, EventArgs e)
        {
            Consulta_Compra reporte_compra = new Consulta_Compra(Connection);
            reporte_compra.ShowDialog();
            this.Close();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
