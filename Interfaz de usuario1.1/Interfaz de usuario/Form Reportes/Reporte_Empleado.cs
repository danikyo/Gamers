using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_de_usuario.Form_Reportes
{
    public partial class Reporte_Empleado : Form
    {
        Class_.Connection Connection = new Class_.Connection();

        public Reporte_Empleado(Class_.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
        }

        private void Reporte_Empleado_Load(object sender, EventArgs e)
        {
            
        }
    }
}
