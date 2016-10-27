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
            CConnection.OpenConnection();
            MySqlDataReader reader = Class_.Empleado.BuscarEmpleado(CConnection.myConnection, textBoxQuery.Text);
            if(reader.Read())
            {
                Class_.Empleado Nempleado = new Class_.Empleado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(5));
                Consulta_Empleado consulta_empleado = new Consulta_Empleado(Nempleado, CConnection);
                CConnection.CloseConnection();
                consulta_empleado.ShowDialog();
            }
            else
            {
                MessageBox.Show("ID no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CConnection.CloseConnection();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxIDEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (textBoxQuery.Text == "")
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
            CConnection.OpenConnection();
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
            CConnection.CloseConnection();
        }

        private void comboBoxPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
