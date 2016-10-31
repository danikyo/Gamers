using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            labelFolioD.Text = Factura.ID.ToString();
            labelFecha.Text = Factura.Fecha;
        }
    }
}
