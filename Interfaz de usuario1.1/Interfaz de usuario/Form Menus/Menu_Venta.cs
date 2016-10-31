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
    public partial class Menu_Venta : Form
    {
        Class_.Connection Connection;
        Class_.Empleado Empleado;
        string fecha;

        public Menu_Venta(Class_.Connection Connection, Class_.Empleado Empleado)
        {
            InitializeComponent();

            this.Connection = Connection;
            this.Empleado = Empleado;
        }

        private void SetFecha()
        {
            DateTime Hoy = DateTime.Now;
            fecha = Hoy.ToString("yyyy-MM-dd HH:mm:ss");
            string[] fechaHora = fecha.Split(' ');
            labelFecha.Text = fechaHora[0] + "\n" + fechaHora[1];
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if ((textBoxIDcliente.Text == "") || (comboBoxTipoPago.Text == ""))
            {
                MessageBox.Show("Favor de llenar los campos requeridos");
            }
            else
            {
                Connection.OpenConnection();
                Class_.Venta nVenta = new Class_.Venta(1, fecha, comboBoxTipoPago.Text, "V", Empleado.ID, int.Parse(textBoxIDcliente.Text), true);
                Class_.Venta.AgregarVenta(Connection.myConnection, nVenta);
                MessageBox.Show("Compra exitosa", "GRACIAS POR SU COMPRA", MessageBoxButtons.OK, MessageBoxIcon.None);
                Connection.CloseConnection();
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxIDcliente.Clear();
            textBoxNombreCliente.Clear();
            textBoxSaldo.Clear();
            comboBoxTipoPago.Text = "";
        }

        private void Menu_Venta_Load(object sender, EventArgs e)
        {
            SetFecha();

            textBoxNomEmpleado.Text = Empleado.Nombre + " " + Empleado.Apellido;

            int Nofolio = MaxId();
            labelFolio.Text = "Folio No. " + Nofolio.ToString();
        }

        private int MaxId()
        {
            int max = 1;
            Connection.OpenConnection();
            MySqlDataReader reader = Class_.Venta.BuscarMaxId(Connection.myConnection);
            if(reader.Read())
            {
                if(!reader.IsDBNull(0)) { max = reader.GetInt32(0); max++; }
            }
            Connection.CloseConnection();
            return max;
        }

        private void buttonComprobar_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            MySqlDataReader reader = Class_.Cliente.BuscarCliente(Connection.myConnection, textBoxIDcliente.Text);
            if(reader.Read())
            {
                if (reader.GetBoolean(15))
                {
                    textBoxNombreCliente.Text = reader.GetString(1) + " " + reader.GetString(2);
                    textBoxSaldo.Text = reader.GetFloat(14).ToString();
                }
                else
                {
                    MessageBox.Show("No existe ID");
                }
            }
            else { MessageBox.Show("No existe ID"); }
            Connection.CloseConnection();
        }
    }
}
