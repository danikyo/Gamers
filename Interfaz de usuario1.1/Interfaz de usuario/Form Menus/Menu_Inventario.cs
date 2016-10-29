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
    public partial class Menu_Inventario : Form
    {
        Class_.Connection Connection;

        public Menu_Inventario(Class_.Connection Connection)
        {
            InitializeComponent();

            this.Connection = Connection;
            buttonConsultaP.Enabled = false;
            buttonGenerar.Enabled = false;
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConsultaP_Click(object sender, EventArgs e)
        {
            Consulta_Producto consulta_producto = new Consulta_Producto(1);
            consulta_producto.ShowDialog();
        }

        private void textBoxIDproducto_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIDproducto.Text == "")
            {
                buttonAgregarP.Enabled = true;
                buttonGenerar.Enabled = true;
                buttonConsultaP.Enabled = false;
            }
            else
            {
                buttonAgregarP.Enabled = false;
                buttonGenerar.Enabled = false;
                buttonConsultaP.Enabled = true;
            }
        }

        private void comboBoxReporteTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGenerar.Enabled = true;
        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            Reporte_Inventario reporte_inventario = new Reporte_Inventario();
            reporte_inventario.ShowDialog();
        }

        private void buttonAgregarP_Click(object sender, EventArgs e)
        {
            if(textBoxNombreP.Text == "" || textBoxPrecio.Text == "" || comboBoxTipo.Text == "" || comboBoxConsola.Text == "" || comboBoxGenero.Text == "" || comboBoxStatus.Text == "")
            {
                MessageBox.Show("Rellenar todos los campos");
            }
            else
            {
                Connection.OpenConnection();
                Class_.Producto nProducto = new Class_.Producto(1, textBoxNombreP.Text, comboBoxTipo.Text, comboBoxConsola.Text, comboBoxStatus.Text, textBoxPrecio.Text, 0, true);
                Class_.Producto.AgregarProducto(Connection.myConnection, nProducto);
                Connection.CloseConnection();
                this.Close();
            }
        }
    }
}
