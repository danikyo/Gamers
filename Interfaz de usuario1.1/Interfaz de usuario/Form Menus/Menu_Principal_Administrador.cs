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
    public partial class Menu_Principal_Administrador : Form
    {
        private Class_.Empleado Empleado;
        private Class_.Connection CConnection;

        public Menu_Principal_Administrador(Class_.Empleado Empleado, Class_.Connection CConnection)
        {
            InitializeComponent();

            this.Empleado = Empleado;
            this.CConnection = CConnection;
        }

        private void Menu_Principal_Administrador_Load(object sender, EventArgs e)
        {
            //Centrar el Panel
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //Captura el Tamaño del Monitor
            Int32 ancho = (this.Height - panelMenu.Height) / 2;
            panelMenu.Location = new Point(panelMenu.Location.X, ancho);

            labelDate.Text = DateTime.Now.ToShortDateString();
            labelName.Text = "Bienvenido\n" + Empleado.Nombre + " " + Empleado.Apellido;
        }

        private void pBsale_Click(object sender, EventArgs e)
        {
            Menu_Venta menu_venta = new Menu_Venta(CConnection, Empleado);
            menu_venta.ShowDialog();
        }

        private void pBbuy_Click(object sender, EventArgs e)
        {
            Menu_Compra menu_compra = new Menu_Compra(CConnection, Empleado);
            menu_compra.ShowDialog();
        }

        private void pBreport_Click(object sender, EventArgs e)
        {
            ReportesVentaCompra reportesventacompra = new ReportesVentaCompra(CConnection);
            reportesventacompra.ShowDialog();
        }

        private void pBcustomer_Click(object sender, EventArgs e)
        {
            Menu_Clientes menu_clientes = new Menu_Clientes(CConnection);
            menu_clientes.ShowDialog();
        }

        private void pBproduct_Click(object sender, EventArgs e)
        {
            Menu_Inventario menu_inventario = new Menu_Inventario(CConnection);
            menu_inventario.ShowDialog();
        }

        private void pBemployee_Click(object sender, EventArgs e)
        {
            Menu_Empleado menu_empleado = new Menu_Empleado(CConnection);
            menu_empleado.ShowDialog();
        }

        private void pBbill_Click(object sender, EventArgs e)
        {
            Menu_Factura menu_factura = new Menu_Factura(CConnection);
            menu_factura.ShowDialog();
        }

        private void pBreturn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea cerrar sesión?", "◄ AVISO ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pBsale_MouseHover(object sender, EventArgs e)
        {
            pBsale.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pBsale_MouseLeave(object sender, EventArgs e)
        {
            pBsale.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pBbuy_MouseHover(object sender, EventArgs e)
        {
            pBbuy.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pBbuy_MouseLeave(object sender, EventArgs e)
        {
            pBbuy.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pBreport_MouseHover(object sender, EventArgs e)
        {
            pBreport.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pBreport_MouseLeave(object sender, EventArgs e)
        {
            pBreport.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pBcustomer_MouseHover(object sender, EventArgs e)
        {
            pBcustomer.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pBcustomer_MouseLeave(object sender, EventArgs e)
        {
            pBcustomer.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pBproduct_MouseHover(object sender, EventArgs e)
        {
            pBproduct.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pBproduct_MouseLeave(object sender, EventArgs e)
        {
            pBproduct.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pBemployee_MouseHover(object sender, EventArgs e)
        {
            pBemployee.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pBemployee_MouseLeave(object sender, EventArgs e)
        {
            pBemployee.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pBbill_MouseHover(object sender, EventArgs e)
        {
            pBbill.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pBbill_MouseLeave(object sender, EventArgs e)
        {
            pBbill.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pBreturn_MouseHover(object sender, EventArgs e)
        {
            pBreturn.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pBreturn_MouseLeave(object sender, EventArgs e)
        {
            pBreturn.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
