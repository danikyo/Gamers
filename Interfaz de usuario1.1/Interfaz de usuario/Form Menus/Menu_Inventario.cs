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
    public partial class Menu_Inventario : Form
    {
        Class_.Connection Connection;

        public Menu_Inventario(Class_.Connection Connection)
        {
            InitializeComponent();

            this.Connection = Connection;
            buttonConsultaP.Enabled = false;        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConsultaP_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            MySqlDataReader reader = Class_.Producto.BuscarProducto(Connection.myConnection, textBoxIDproducto.Text);
            if(reader.Read())
            {
                if(reader.GetBoolean(9))
                {
                    Class_.Producto nProducto = new Class_.Producto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetFloat(6), reader.GetInt32(7), reader.GetString(8), reader.GetBoolean(9));
                    Consulta_Producto consulta_producto = new Consulta_Producto(nProducto, Connection);
                    Connection.CloseConnection();
                    this.Close();
                    consulta_producto.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ID no existe");
                }
            }
            else
            {
                MessageBox.Show("ID no existe");
            }
            Connection.CloseConnection();
        }

        private void textBoxIDproducto_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIDproducto.Text == "")
            {
                buttonAgregarP.Enabled = true;
                buttonConsultaP.Enabled = false;
            }
            else
            {
                buttonAgregarP.Enabled = false;
                buttonConsultaP.Enabled = true;
            }
        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            Reporte_Inventario reporte_inventario = new Reporte_Inventario();
            reporte_inventario.ShowDialog();
        }

        private void buttonAgregarP_Click(object sender, EventArgs e)
        {
            if (textBoxNombreP.Text == "" || textBoxPrecio.Text == "" || comboBoxTipo.Text == "" || comboBoxConsola.Text == "" || comboBoxGenero.Text == "" || comboBoxStatus.Text == "" || textBoxImagen.Text == "")
            {
                MessageBox.Show("Rellenar todos los campos");
            }
            else
            {
                textBoxImagen.Text = textBoxImagen.Text.Replace(@"\", @"\\");
                Connection.OpenConnection();
                Class_.Producto nProducto = new Class_.Producto(1, textBoxNombreP.Text, comboBoxTipo.Text, comboBoxConsola.Text,comboBoxGenero.Text, comboBoxStatus.Text, float.Parse(textBoxPrecio.Text), 0, textBoxImagen.Text, true);
                Class_.Producto.AgregarProducto(Connection.myConnection, nProducto);
                Connection.CloseConnection();
                MessageBox.Show("Captura Exitosa");
                this.Close();
            }
        }

        private void Menu_Inventario_Load(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            dataGridView1.DataSource = Class_.Producto.MostrarProductos(Connection.myConnection);
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            Connection.CloseConnection();
            string imagen = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            pictureBoxRimage.Image = Image.FromFile(imagen);

            labelIDproducto.Text = "ID " + MaxId().ToString();
        }

        private void buttonExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            try
            {
                if (filedialog.ShowDialog() == DialogResult.OK)
                {
                    string imagen = filedialog.FileName;
                    pictureBoxImage.Image = Image.FromFile(imagen);
                    textBoxImagen.Text = imagen;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private int MaxId()
        {
            int max = 1;
            Connection.OpenConnection();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT MAX(idProducto) AS idProducto FROM producto"), Connection.myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (!reader.IsDBNull(0)) { max = reader.GetInt32(0); max++; }
            }
            Connection.CloseConnection();
            return max;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string imagen = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            pictureBoxRimage.Image = Image.FromFile(imagen);
        }

        private void comboBoxTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxConsola_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
