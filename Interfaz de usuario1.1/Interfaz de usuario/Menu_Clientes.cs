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
    public partial class Menu_Clientes : Form
    {
        public Menu_Clientes()
        {
            InitializeComponent();
            buttonConsultaC.Enabled = false;
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregarC_Click(object sender, EventArgs e)
        {
            if (textBoxNombreC.Text == "" || textBoxApellidosC.Text == "" || textBoxDireccionC.Text == "" || textBoxFechaNacC.Text == "" || textBoxEmailC.Text == "")
            {
                MessageBox.Show("Favor de llenar\nlos campos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxIDCliente_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIDCliente.Text != "")
            {
                buttonAgregarC.Enabled = false;
                buttonConsultaC.Enabled = true;
            }
            else
            {
                buttonAgregarC.Enabled = true;
                buttonConsultaC.Enabled = false;
            }
        }

        private void buttonConsultaC_Click(object sender, EventArgs e)
        {
            Consulta_Cliente consulta_cliente = new Consulta_Cliente();
            consulta_cliente.ShowDialog();
        }
    }
}
