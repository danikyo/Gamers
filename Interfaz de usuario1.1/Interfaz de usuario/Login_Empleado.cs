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
    public partial class Menu_Logo : Form
    {
        public Menu_Logo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "admin" && textBoxContraseña.Text == "123")
            {
                Menu_Principal_Administrador menu_principal_administrador = new Menu_Principal_Administrador();
                menu_principal_administrador.ShowDialog();
            }
            else if (textBoxNombre.Text == "empleado" && textBoxContraseña.Text == "123")
            {
                Menu_Principal_Empleado menu_principal_empleado = new Menu_Principal_Empleado();
                menu_principal_empleado.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o Contraseña incorrectos","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
