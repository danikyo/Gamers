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
    public partial class Consulta_Empleado : Form
    {
        Class_.Connection CConnection;
        Class_.Empleado Nempleado;
        public Consulta_Empleado(Class_.Empleado Nempleado, Class_.Connection CConnection)
        {
            InitializeComponent();
            this.CConnection = CConnection;
            this.Nempleado = Nempleado;
            if(!Nempleado.Status) { buttonBaja.Enabled = false; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consulta_Empleado_Load(object sender, EventArgs e)
        {
            labelIDCliente.Text = "ID: " + Nempleado.ID;
            textBoxApellido.Text = Nempleado.Apellido;
            textBoxContrasena.Text = Nempleado.Contrasena;
            textBoxNombre.Text = Nempleado.Nombre;
            if (Nempleado.Status)
            { textBoxStatus.Text = "Activo"; }
            else
            { textBoxStatus.Text = "Inactivo"; }
            comboBoxPuesto.Text = Nempleado.Puesto;
            textBoxApellido.Enabled = false;
            textBoxContrasena.Enabled = false;
            textBoxNombre.Enabled = false;
            textBoxStatus.Enabled = false;
            comboBoxPuesto.Enabled = false;
            buttonCancelar.Visible = false;
            buttonListo.Visible = false;
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea dar de baja\na este empleado?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                CConnection.OpenConnection();
                Class_.Empleado.BajaEmpleado(CConnection.myConnection, Nempleado.ID);
                CConnection.CloseConnection();
                this.Close();
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            textBoxApellido.Enabled = true;
            textBoxContrasena.Enabled = true;
            textBoxNombre.Enabled = true;
            //textBoxStatus.Enabled = true;
            comboBoxPuesto.Enabled = true;
            buttonCancelar.Visible = true;
            buttonListo.Visible = true;
            buttonModificar.Enabled = false;
            buttonBaja.Enabled = false;
            buttonRegresar.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxApellido.Enabled = false;
            textBoxContrasena.Enabled = false;
            textBoxNombre.Enabled = false;
            textBoxStatus.Enabled = false;
            comboBoxPuesto.Enabled = false;
            buttonCancelar.Visible = false;
            buttonListo.Visible = false;
            buttonModificar.Enabled = true;
            buttonBaja.Enabled = true;
            buttonRegresar.Enabled = true;
            labelIDCliente.Text = "ID: " + Nempleado.ID;
            textBoxApellido.Text = Nempleado.Apellido;
            textBoxContrasena.Text = Nempleado.Contrasena;
            textBoxNombre.Text = Nempleado.Nombre;
            if (Nempleado.Status)
            { textBoxStatus.Text = "Activo"; }
            else
            { textBoxStatus.Text = "Inactivo"; }
            comboBoxPuesto.Text = Nempleado.Puesto;
        }

        private void buttonListo_Click(object sender, EventArgs e)
        {
            CConnection.OpenConnection();
            Class_.Empleado Nuempleado = new Class_.Empleado(Nempleado.ID, textBoxNombre.Text,textBoxApellido.Text,comboBoxPuesto.Text,textBoxContrasena.Text,true);
            int retorno = Class_.Empleado.ModificarEmpleado(CConnection.myConnection, Nuempleado);
            CConnection.CloseConnection();
            this.Close();
        }

        private void comboBoxPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
