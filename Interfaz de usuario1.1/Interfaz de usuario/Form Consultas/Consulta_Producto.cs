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
    public partial class Consulta_Producto : Form
    {
        private Class_.Producto Producto;
        private Class_.Connection Connection;
        private string imagen;

        public Consulta_Producto(Class_.Producto Producto, Class_.Connection Connection)
        {
            InitializeComponent();

            this.Producto = Producto;
            this.Connection = Connection;
        }

        private void Consulta_Producto_Load(object sender, EventArgs e)
        {
            LoadP();
        }

        private void buttonExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            try
            {
                if (filedialog.ShowDialog() == DialogResult.OK)
                {
                    imagen = filedialog.FileName;
                    pictureBoxImage.Image = Image.FromFile(imagen);
                    textBoxImage.Text = imagen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex);
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            unlock();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            imagen = imagen.Replace(@"\", @"\\");

            Connection.OpenConnection();
            Class_.Producto nProducto = new Class_.Producto(Producto.ID, textBoxNom.Text, comboBoxTipo.Text, comboBoxConsola.Text, comboBoxGenero.Text, comboBoxStatus.Text, float.Parse(textBoxPrec.Text), int.Parse(textBoxStock.Text), imagen, true);
            Class_.Producto.ModificarProducto(Connection.myConnection, nProducto);
            Connection.CloseConnection();

            MessageBox.Show("Datos Modificados");
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            LoadP();
            buttonReturn.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar\neste producto?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Connection.OpenConnection();
                Class_.Producto.BajaProducto(Connection.myConnection, Producto.ID);
                Connection.CloseConnection();
                this.Close();
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadP()
        {
            labelIDProducto.Text = "ID: " + Producto.ID;
            textBoxNom.Text = Producto.Nombre;
            comboBoxTipo.Text = Producto.Tipo;
            comboBoxConsola.Text = Producto.Consola;
            comboBoxGenero.Text = Producto.Genero;
            comboBoxStatus.Text = Producto.Status;
            textBoxPrec.Text = Producto.Precio.ToString();
            textBoxStock.Text = Producto.Stock.ToString();
            imagen = Producto.Ruta;
            textBoxImage.Text = imagen;
            if (Producto.Status == "Seminuevo") { textBoxPrecioCompra.Text = (Producto.Precio * .5).ToString(); }
            else { textBoxPrecioCompra.Text = "No se compra"; }

            textBoxNom.Enabled = false;
            comboBoxTipo.Enabled = false;
            comboBoxConsola.Enabled = false;
            comboBoxGenero.Enabled = false;
            comboBoxStatus.Enabled = false;
            textBoxPrec.Enabled = false;
            textBoxStock.Enabled = false;
            textBoxPrecioCompra.Enabled = false;
            textBoxImage.Visible = false;
            buttonExaminar.Enabled = false;

            buttonCancel.Visible = false;
            buttonAccept.Visible = false;

            try
            {
                pictureBoxImage.Image = Image.FromFile(imagen);
            }
            catch(Exception)
            {
            }
        }

        public void unlock()
        {
            textBoxNom.Enabled = true;
            comboBoxTipo.Enabled = true;
            comboBoxConsola.Enabled = true;
            comboBoxGenero.Enabled = true;
            comboBoxStatus.Enabled = true;
            textBoxPrec.Enabled = true;
            textBoxStock.Enabled = true;

            buttonAccept.Visible = true;
            buttonCancel.Visible = true;
            buttonDelete.Enabled = false;
            buttonExaminar.Enabled = true;
        }

        private void textBoxPrec_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(e);
        }

        private void textBoxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(e);
        }

        private void textBoxPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(e);
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
