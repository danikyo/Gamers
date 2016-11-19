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
    public partial class Menu_Principal_Empleado : Form
    {
        Class_.Connection Connection;
        Class_.Empleado empleado;

        public Menu_Principal_Empleado(Class_.Connection Connection, Class_.Empleado empleado)
        {
            InitializeComponent();
            this.Connection = Connection;
            this.empleado = empleado;
        }

        private void buttonVenta_Click(object sender, EventArgs e)
        {
           Menu_Venta menu_venta = new Menu_Venta(Connection, empleado);
           menu_venta.ShowDialog();
        }

        private void buttonCompra_Click(object sender, EventArgs e)
        {
            Menu_Compra menu_compra = new Menu_Compra(Connection, empleado);
            menu_compra.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            MySqlDataReader reader = Class_.Producto.BuscarProducto(Connection.myConnection, textBox1.Text);
            if (reader.Read())
            {
                if (reader.GetBoolean(9))
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

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
