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
            LoadData();
            labelIDproducto.Text = "ID " + MaxId().ToString();
        }

        private void LoadData()
        {
            Connection.OpenConnection();
            dataGridView1.DataSource = Class_.Producto.MostrarProductos(Connection.myConnection);
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            Connection.CloseConnection();
            if (dataGridView1.RowCount > 0)
            {
                string imagen = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                pictureBoxRimage.Image = Image.FromFile(imagen);
            }
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

        private void buttonConsultaC_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            MySqlDataReader reader = Class_.Producto.BuscarProducto(Connection.myConnection, dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (reader.Read())
            {
                if (reader.GetBoolean(9))
                {
                    Class_.Producto nProducto = new Class_.Producto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetFloat(6), reader.GetInt32(7), reader.GetString(8), reader.GetBoolean(9));
                    Consulta_Producto consulta_producto = new Consulta_Producto(nProducto, Connection);
                    Connection.CloseConnection();

                    consulta_producto.ShowDialog();
                    LoadData();
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

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregarC_Click(object sender, EventArgs e)
        {
            if (textBoxNombreP.Text == "" || textBoxPrecio.Text == "" || comboBoxTipo.Text == "" || comboBoxConsola.Text == "" || comboBoxGenero.Text == "" || comboBoxStatus.Text == "" || textBoxImagen.Text == "")
            {
                MessageBox.Show("Rellenar todos los campos");
            }
            else
            {
                textBoxImagen.Text = textBoxImagen.Text.Replace(@"\", @"\\");
                Connection.OpenConnection();
                Class_.Producto nProducto = new Class_.Producto(1, textBoxNombreP.Text, comboBoxTipo.Text, comboBoxConsola.Text, comboBoxGenero.Text, comboBoxStatus.Text, float.Parse(textBoxPrecio.Text), 0, textBoxImagen.Text, true);
                Class_.Producto.AgregarProducto(Connection.myConnection, nProducto);
                Connection.CloseConnection();
                MessageBox.Show("Captura Exitosa");
                LoadData();

                textBoxImagen.Clear();
                textBoxNombreP.Clear();
                textBoxPrecio.Clear();
                comboBoxTipo.Text = "";
                comboBoxConsola.Text = "";
                comboBoxGenero.Text = "";
                comboBoxStatus.Text = "";
                pictureBoxImage.Image = Image.FromFile("C:\\Users\\kyo_9\\Documents\\GitHub\\Gamers\\Interfaz de usuario1.1\\Interfaz de usuario\\Resources\\Question.png");
            }
        }
    }
}
