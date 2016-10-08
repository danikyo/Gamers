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
    public partial class Menu_Empleado : Form
    {
        public Menu_Empleado()
        {
            InitializeComponent();
            buttonConsultaE.Enabled = false;
        }

        private void buttonConsultaE_Click(object sender, EventArgs e)
        {
            Consulta_Empleado consulta_empleado = new Consulta_Empleado();
            consulta_empleado.ShowDialog();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxIDEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIDEmpleado.Text == "")
            {
                buttonAgregarE.Enabled = true;
                buttonConsultaE.Enabled = false;
            }
            else
            {
                buttonAgregarE.Enabled = false;
                buttonConsultaE.Enabled = true;
            }
        }

        private void buttonAgregarE_Click(object sender, EventArgs e)
        {
            if (textBoxApellidosE.Text == "" || textBoxDireccionE.Text == "" || textBoxEmailE.Text == "" || textBoxFechaNacE.Text == "" || textBoxNombreE.Text == "")
            {
                MessageBox.Show("Favor de llenar\nlos campor requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
