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
    public partial class Menu_Principal_Empleado : Form
    {
        public Menu_Principal_Empleado()
        {
            InitializeComponent();
        }

        private void buttonVenta_Click(object sender, EventArgs e)
        {
            Login_Cliente login_cliente = new Login_Cliente(1);
            login_cliente.ShowDialog();
        }

        private void buttonCompra_Click(object sender, EventArgs e)
        {
            Login_Cliente login_cliente = new Login_Cliente(2);
            login_cliente.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consulta_Producto consulta_producto = new Consulta_Producto(2);
            consulta_producto.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
