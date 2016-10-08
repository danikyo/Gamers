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
    public partial class Login_Cliente : Form
    {
        int valor;
        public Login_Cliente(int valor)
        {
            InitializeComponent();
            this.valor = valor;
            if (valor == 2)
            {
                buttonVP.Visible = false;
            }
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "1")
            {
                if (valor == 1)
                {
                    Menu_Venta menu_venta = new Menu_Venta();
                    this.Close();
                    menu_venta.ShowDialog();
                }
                else if (valor == 2)
                {
                    Menu_Compra menu_compra = new Menu_Compra();
                    this.Close();
                    menu_compra.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("ID Incorrecto","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void buttonVP_Click(object sender, EventArgs e)
        {
            Menu_Venta menu_venta = new Menu_Venta();
            this.Close();
            menu_venta.ShowDialog();
        }
    }
}
