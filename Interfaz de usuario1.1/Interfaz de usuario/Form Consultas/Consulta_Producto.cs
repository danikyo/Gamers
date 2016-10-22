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
        public Consulta_Producto(int a)
        {
            InitializeComponent();
            if (a == 1)
            {
            }
            else if (a == 2)
            {
                buttonAddstock.Visible = false;
                buttonDeleteStock.Visible = false;
                buttonEliminar.Visible = false;
                buttonModificar.Visible = false;
                radioButtonNuevo.Visible = false;
                radioButtonSeminuevo.Visible = false;
                textBoxCantidad.Visible = false;
                labelCantidad.Visible = false;
            }
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
