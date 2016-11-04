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
using System.Text.RegularExpressions;

namespace Interfaz_de_usuario
{
    public partial class Menu_Clientes : Form
    {
        Class_.Connection CConnection;
        public Menu_Clientes(Class_.Connection Connection)
        {
            InitializeComponent();
            this.CConnection = Connection;
            buttonConsultaC.Enabled = false;
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregarC_Click(object sender, EventArgs e)
        {
            if (textBoxNombreC.Text == "" || textBoxApellidosC.Text == "" || textBoxDireccionC.Text == "" || textBoxEmailC.Text == "" || textBoxTel.Text == "" || textBoxRFC.Text == ""
                || textBoxRazSoc.Text == "" || textBoxDomFisc.Text == "" || textBoxCP.Text == "" || textBoxPais.Text == "" || textBoxEstado.Text == "" || textBoxMunicipio.Text == "")
            {
                MessageBox.Show("Favor de llenar\nlos campos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!email_bien_escrito(textBoxEmailC.Text)) { MessageBox.Show("Email no válido"); }
                else
                {
                    CConnection.OpenConnection();
                    Class_.Cliente nCliente = new Class_.Cliente(1, textBoxNombreC.Text, textBoxApellidosC.Text, textBoxDireccionC.Text, dateTimePickerFechaNac.Text, textBoxEmailC.Text, textBoxTel.Text
                    , textBoxRFC.Text, textBoxDomFisc.Text, textBoxRazSoc.Text, textBoxCP.Text, textBoxPais.Text, textBoxEstado.Text, textBoxMunicipio.Text, 0, true);
                    Class_.Cliente.AgregarCliente(CConnection.myConnection, nCliente);

                    CConnection.CloseConnection();

                    MessageBox.Show("Captura Exitosa");

                    this.Close();
                }
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
            CConnection.OpenConnection();
            MySqlDataReader Reader = Class_.Cliente.BuscarCliente(CConnection.myConnection, textBoxIDCliente.Text);
            if(Reader.Read())
            {
                if(Reader.GetBoolean(15))
                {
                    Class_.Cliente nCliente = new Class_.Cliente(Reader.GetInt32(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(4), Reader.GetString(5), Reader.GetString(6),
                    Reader.GetString(7), Reader.GetString(8), Reader.GetString(9), Reader.GetString(10), Reader.GetString(11), Reader.GetString(12), Reader.GetString(13), Reader.GetFloat(14), Reader.GetBoolean(15));
                    Console.Write(Reader.GetString(1));
                    Consulta_Cliente consulta_cliente = new Consulta_Cliente(nCliente, CConnection);
                    CConnection.CloseConnection();
                    consulta_cliente.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No existe ID de cliente");
                }
                
            }
            else
            {
                MessageBox.Show("no existe ID");
            }
            CConnection.CloseConnection();
        }

        private int MaxId()
        {
            int max = 1;
            CConnection.OpenConnection();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT MAX(idCliente) AS idCliente FROM Cliente"), CConnection.myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (!reader.IsDBNull(0)) { max = reader.GetInt32(0); max++; }
            }
            CConnection.CloseConnection();
            return max;
        }

        private void Menu_Clientes_Load(object sender, EventArgs e)
        {
            CConnection.OpenConnection();
            dataGridView1.DataSource = Class_.Cliente.MostrarClientes(CConnection.myConnection);
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[0].Width = 40;
            CConnection.CloseConnection();

            labelIDCliente.Text = "ID " + MaxId().ToString();
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
    }
}
