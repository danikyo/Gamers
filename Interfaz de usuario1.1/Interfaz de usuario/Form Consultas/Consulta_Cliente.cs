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
    public partial class Consulta_Cliente : Form
    {
        Class_.Connection Connection;
        Class_.Cliente Cliente;

        public Consulta_Cliente(Class_.Cliente Cliente, Class_.Connection Connection)
        {
            InitializeComponent();

            this.Cliente = Cliente;
            this.Connection = Connection;

            LoadC();
            if(!Cliente.cDisponible) { buttonBaja.Enabled = false; }
        }

        public void LoadC()
        {
            labelIDCliente.Text = "ID " + Cliente.cidcliente;
            textBoxApellidos.Text = Cliente.cApellido;
            textBoxNombre.Text = Cliente.cNombre;
            dateTimePicker1.Text = Cliente.cFechaNac;
            textBoxDireccion.Text = Cliente.cDireccion;
            textBoxEmail.Text = Cliente.cE_mail;
            textBoxSaldo.Text = Cliente.cSaldo.ToString();
            textBoxTel.Text = Cliente.cTel;
            textBoxCP.Text = Cliente.cCP;
            textBoxRFC.Text = Cliente.cRFC;
            textBoxRazonSocial.Text = Cliente.cRazonSocial;
            textBoxDomFiscal.Text = Cliente.cDomFiscal;
            textBoxPais.Text = Cliente.cPais;
            textBoxEstado.Text = Cliente.cEstado;
            textBoxMunicipio.Text = Cliente.cMunicipio;

            textBoxApellidos.Enabled = false;
            textBoxNombre.Enabled = false;
            dateTimePicker1.Enabled = false;
            textBoxDireccion.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxSaldo.Enabled = false;
            textBoxTel.Enabled = false;
            textBoxCP.Enabled = false;
            textBoxRFC.Enabled = false;
            textBoxRazonSocial.Enabled = false;
            textBoxDomFiscal.Enabled = false;
            textBoxPais.Enabled = false;
            textBoxEstado.Enabled = false;
            textBoxMunicipio.Enabled = false;

            buttonListo.Visible = false;
            buttonCancelar.Visible = false;
        }

        public void Desbloquear()
        {
            textBoxApellidos.Enabled = true;
            textBoxNombre.Enabled = true;
            dateTimePicker1.Enabled = true;
            textBoxDireccion.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxSaldo.Enabled = true;
            textBoxTel.Enabled = true;
            textBoxCP.Enabled = true;
            textBoxRFC.Enabled = true;
            textBoxRazonSocial.Enabled = true;
            textBoxDomFiscal.Enabled = true;
            textBoxPais.Enabled = true;
            textBoxEstado.Enabled = true;
            textBoxMunicipio.Enabled = true;

            buttonListo.Visible = true;
            buttonCancelar.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Desbloquear();
            buttonRegresar.Enabled = false;
            buttonBaja.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LoadC();
            buttonBaja.Enabled = true;
            buttonRegresar.Enabled = true;
        }

        private void buttonListo_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            Class_.Cliente nCliente = new Class_.Cliente(Cliente.cidcliente, textBoxNombre.Text, textBoxApellidos.Text, textBoxDireccion.Text,
            dateTimePicker1.Text, textBoxEmail.Text, textBoxTel.Text, textBoxRFC.Text, textBoxDomFiscal.Text, textBoxRazonSocial.Text, textBoxCP.Text,
            textBoxPais.Text, textBoxEstado.Text, textBoxMunicipio.Text, float.Parse(textBoxSaldo.Text), true);
            Class_.Cliente.ModificarCliente(Connection.myConnection, nCliente);
            Connection.CloseConnection();
            this.Close();
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea dar de baja\na este cliente?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Connection.OpenConnection();
                Class_.Cliente.BajaCliente(Connection.myConnection, Cliente.cidcliente);
                Connection.CloseConnection();
                this.Close();
            }
        }
    }
}
