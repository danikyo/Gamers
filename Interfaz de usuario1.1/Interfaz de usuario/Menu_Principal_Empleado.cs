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
            Menu_Venta menu_venta = new Menu_Venta();
            menu_venta.ShowDialog();
        }

        private void buttonCompra_Click(object sender, EventArgs e)
        {
            Menu_Compra menu_compra = new Menu_Compra();
            menu_compra.ShowDialog();
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
