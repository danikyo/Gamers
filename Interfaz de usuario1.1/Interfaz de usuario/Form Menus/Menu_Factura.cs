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
    public partial class Menu_Factura : Form
    {
        public Menu_Factura()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {

        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            Consulta_Factura consulta_factura = new Consulta_Factura();
            consulta_factura.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
