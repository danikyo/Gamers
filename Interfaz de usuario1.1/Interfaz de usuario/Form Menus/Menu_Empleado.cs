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
        Class_.Connection CConnection;
        public Menu_Empleado(Class_.Connection CConnection)
        {
            InitializeComponent();
            buttonConsultaE.Enabled = false;
            this.CConnection = CConnection;
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
            if (textBoxApellidosE.Text == "" || comboBoxPuesto.Text == "" || textBoxCPassword.Text == "" || textBoxPassword.Text == "" || textBoxNombreE.Text == "")
            {
                MessageBox.Show("Favor de llenar\nlos campor requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(textBoxPassword.Text == textBoxCPassword.Text)
                {
                    CConnection.OpenConnection();
                    Class_.Empleado Nempleado = new Class_.Empleado();
                    Nempleado.eNombre = textBoxNombreE.Text;
                    Nempleado.eApellido = textBoxApellidosE.Text;
                    Nempleado.ePuesto = comboBoxPuesto.Text;
                    Nempleado.eContrasena = textBoxPassword.Text;
                    int OK = Class_.Empleado.AgregarEmpleado(CConnection.myConnection, Nempleado);
                    if(OK == 1)
                    {
                        MessageBox.Show("Empleado Capturado\nCon Éxito", "Exito", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("No se Pudo Capturar", "Error", MessageBoxButtons.OK);
                    }
                    CConnection.CloseConnection();
                }
                else
                {
                    MessageBox.Show("La contraseña no coincide", "Error Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
