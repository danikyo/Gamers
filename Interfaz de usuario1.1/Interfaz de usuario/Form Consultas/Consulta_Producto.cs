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
        Class_.Producto Producto;
        Class_.Connection Connection;

        public Consulta_Producto(Class_.Producto Producto, Class_.Connection Connection)
        {
            InitializeComponent();

            /* if (a == 1)
             {
             }
             else if (a == 2)
             {
                 buttonAddstock.Visible = false;
                 buttonDeleteStock.Visible = false;
                 buttonEliminar.Visible = false;
                 buttonModificar.Visible = false;
                 textBoxCantidad.Visible = false;
                 labelCantidad.Visible = false;
             }*/

            /// Se quitaran los add Stock y Delete Stock para optimizar el programa
            buttonAddstock.Visible = false;
            buttonDeleteStock.Visible = false;
            textBoxCantidad.Visible = false;
            labelCantidad.Visible = false;
            ///

            this.Producto = Producto;
            this.Connection = Connection;
            LoadP();
        }

        public void LoadP()
        {
            labelIDProducto.Text = "ID: " + Producto.ID;
            textBoxNom.Text = Producto.Nombre;
            comboBoxTipo.Text = Producto.Tipo;
            comboBoxConsola.Text = Producto.Consola;
            comboBoxGenero.Text = Producto.Genero;
            comboBoxStatus.Text = Producto.Status;
            textBoxPrec.Text = Producto.Precio.ToString();
            textBoxStock.Text = Producto.Stock.ToString();

            textBoxNom.Enabled = false;
            comboBoxTipo.Enabled = false;
            comboBoxConsola.Enabled = false;
            comboBoxGenero.Enabled = false;
            comboBoxStatus.Enabled = false;
            textBoxPrec.Enabled = false;
            textBoxStock.Enabled = false;
            textBoxPrecioCompra.Enabled = false;

            buttonListo.Visible = false;
            buttonCancelar.Visible = false;
        }

        public void desbloquear()
        {
            textBoxNom.Enabled = true;
            comboBoxTipo.Enabled = true;
            comboBoxConsola.Enabled = true;
            comboBoxGenero.Enabled = true;
            comboBoxStatus.Enabled = true;
            textBoxPrec.Enabled = true;
            textBoxStock.Enabled = true;

            buttonListo.Visible = true;
            buttonCancelar.Visible = true;

            buttonModificar.Enabled = false;
            buttonAddstock.Enabled = false;
            buttonDeleteStock.Enabled = false;
            buttonRegresar.Enabled = false;
            buttonEliminar.Enabled = false;
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            desbloquear();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LoadP();
            buttonModificar.Enabled = true;
            buttonAddstock.Enabled = true;
            buttonDeleteStock.Enabled = true;
            buttonRegresar.Enabled = true;
            buttonEliminar.Enabled = true;
        }

        private void buttonListo_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            Class_.Producto nProducto = new Class_.Producto(Producto.ID, textBoxNom.Text, comboBoxTipo.Text, comboBoxConsola.Text, comboBoxGenero.Text, comboBoxStatus.Text, float.Parse(textBoxPrec.Text), int.Parse(textBoxStock.Text), true);
            Class_.Producto.ModificarProducto(Connection.myConnection, nProducto);
            Connection.CloseConnection();
            this.Close();
        }

        private void buttonAddstock_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea dar de baja\na este cliente?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Connection.OpenConnection();
                Class_.Producto.BajaProducto(Connection.myConnection, Producto.ID);
                Connection.CloseConnection();
                this.Close();
            }
        }
    }
}
