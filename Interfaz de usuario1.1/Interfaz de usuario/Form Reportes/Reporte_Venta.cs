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
    public partial class Reporte_Venta : Form
    {
        public Reporte_Venta()
        {
            InitializeComponent();
            textBoxID.Enabled = false;
            textBoxIva.Enabled = false;
            textBoxNombreCliente.Enabled = false;
            textBoxSaldo.Enabled = false;
            textBoxSubTotal.Enabled = false;
            textBoxTotal.Enabled = false;
            comboBoxEmpleado.Enabled = false;
            comboBoxTipoPago.Enabled = false;
            dataGridView1.Enabled = false;
        }
    }
}
