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
    public partial class Menu_Compra : Form
    {
        public Menu_Compra()
        {
            InitializeComponent();
            textBoxNombreCliente.Enabled = false;
            textBoxSaldo.Enabled = false;
            textBoxTotal.Enabled = false;
            SetFecha();
        }

        private void SetFecha()
        {
            DateTime Hoy = DateTime.Today;
            string fecha = Hoy.ToString("dd-MM-yyyy");
            labelFecha.Text = "Fecha: " + fecha;
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxNombreCliente.Clear();
            textBoxSaldo.Clear();
            textBoxTotal.Clear();
            comboBoxEmpleado.Text = "";
        }

        private void comboBoxMetodoPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
