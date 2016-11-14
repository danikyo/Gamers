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
    public partial class Menu_Logo : Form
    {
        Class_.Connection CConnection = new Class_.Connection();
        public Menu_Logo()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            CConnection.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM empleado WHERE idEmpleado = '" + textBoxNombre.Text + "' AND eContrasena = '" + textBoxContraseña.Text + "'",CConnection.myConnection);
            MySqlDataReader Reader = command.ExecuteReader();
            if(Reader.Read())
            {
                Class_.Empleado nEmpleado = new Class_.Empleado(Reader.GetInt32(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(4), Reader.GetBoolean(5));

                if(nEmpleado.Status)
                {
                    if (nEmpleado.Puesto == "Gerente")
                    {
                        Menu_Principal_Administrador menu_principal_adm = new Menu_Principal_Administrador(nEmpleado, CConnection);
                        CConnection.CloseConnection();
                        menu_principal_adm.ShowDialog();
                    }
                    else if (nEmpleado.Puesto == "Cajero")
                    {
                        Menu_Principal_Empleado menu_principal_emp = new Menu_Principal_Empleado(Reader.GetString(1) + " " + Reader.GetString(2));
                        CConnection.CloseConnection();
                        menu_principal_emp.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Empleado Inactivo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("ID o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CConnection.CloseConnection();
            textBoxNombre.Clear();
            textBoxContraseña.Clear();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buttonEntrar_Click(sender, e);
                //aqui codigo
            }
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
