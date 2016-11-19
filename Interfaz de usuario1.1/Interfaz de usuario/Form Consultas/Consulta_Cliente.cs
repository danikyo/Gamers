using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
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
            if(!Cliente.Disponible) { buttonBaja.Enabled = false; }
        }

        public void LoadC()
        {
            labelIDCliente.Text = "ID: " + Cliente.ID;
            textBoxApellidos.Text = Cliente.Apellido;
            textBoxNombre.Text = Cliente.Nombre;
            dateTimePicker1.Text = Cliente.FechaNac;
            textBoxDireccion.Text = Cliente.Direccion;
            textBoxEmail.Text = Cliente.E_mail;
            textBoxSaldo.Text = Cliente.Saldo.ToString();
            textBoxTel.Text = Cliente.Tel;
            textBoxCP.Text = Cliente.CP;
            textBoxRFC.Text = Cliente.RFC;
            textBoxRazonSocial.Text = Cliente.RazonSocial;
            textBoxDomFiscal.Text = Cliente.DomFiscal;
            textBoxPais.Text = Cliente.Pais;
            textBoxEstado.Text = Cliente.Estado;
            textBoxMunicipio.Text = Cliente.Municipio;

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
            //textBoxSaldo.Enabled = true;
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

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Desbloquear();
            buttonReturn.Enabled = false;
            buttonBaja.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LoadC();
            buttonBaja.Enabled = true;
            buttonReturn.Enabled = true;
        }

        private void buttonListo_Click(object sender, EventArgs e)
        {
            if (email_bien_escrito(textBoxEmail.Text) && textBoxRFC.Text.Length > 9)
            {
                Connection.OpenConnection();
                Class_.Cliente nCliente = new Class_.Cliente(Cliente.ID, textBoxNombre.Text, textBoxApellidos.Text, textBoxDireccion.Text,
                dateTimePicker1.Text, textBoxEmail.Text, textBoxTel.Text, textBoxRFC.Text, textBoxDomFiscal.Text, textBoxRazonSocial.Text, textBoxCP.Text,
                textBoxPais.Text, textBoxEstado.Text, textBoxMunicipio.Text, float.Parse(textBoxSaldo.Text), true);
                Class_.Cliente.ModificarCliente(Connection.myConnection, nCliente);
                Connection.CloseConnection();

                MessageBox.Show("Datos Modificados");
                this.Close();
            }
            else
            {
                MessageBox.Show("Verifique que los datos esten bien escritos");
            }
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea dar de baja\na este cliente?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Connection.OpenConnection();
                Class_.Cliente.BajaCliente(Connection.myConnection, Cliente.ID);
                Connection.CloseConnection();
                this.Close();
            }
        }

        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void textBoxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(e);
        }

        private void textBoxCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(e);
        }

        private void NumberOnly(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
