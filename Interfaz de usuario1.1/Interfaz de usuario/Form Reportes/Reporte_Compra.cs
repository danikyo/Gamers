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
    public partial class Reporte_Compra : Form
    {
        public Reporte_Compra()
        {
            InitializeComponent();
            textBoxID.Enabled = false;
            textBoxSaldo.Enabled = false;
            textBoxTotal.Enabled = false;
            comboBoxEmpleado.Enabled = false;
            comboBoxMetodoPago.Enabled = false;
            dataGridView1.Enabled = false;
        }
    }
}
