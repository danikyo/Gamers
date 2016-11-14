using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Interfaz_de_usuario
{
    public partial class Menu_Compra : Form
    {
        private Class_.Connection Connection;
        private Class_.Empleado Empleado;
        private string idProducto2;
        private string fecha;
        private int NoFolio;

        public Menu_Compra(Class_.Connection Connection, Class_.Empleado Empleado)
        {
            InitializeComponent();

            this.Connection = Connection;
            this.Empleado = Empleado;
        }

        private void SetFecha()
        {
            DateTime Hoy = DateTime.Now;
            fecha = Hoy.ToString("yyyy-MM-dd HH:mm:ss");
            string[] fechaHora = fecha.Split(' ');
            labelFecha.Text = fechaHora[0] + "\n" + fechaHora[1];
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxIDcliente.Clear();
            textBoxNombreCliente.Clear();
            textBoxSaldo.Clear();
            textBoxTotal.Clear();
            dataGridView1.Rows.Clear();

            textBoxTotal.Text = "0";
            textBoxBono.Text = "0";
        }

        private void comboBoxMetodoPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Menu_Compra_Load(object sender, EventArgs e)
        {
            SetFecha();

            textBoxNomEmpleado.Text = Empleado.Nombre + " " + Empleado.Apellido;

            NoFolio = MaxId();
            labelFolio.Text = "Folio No. " + NoFolio.ToString();
            textBoxTotal.Text = "0";
        }

        private int MaxId()
        {
            int max = 1;
            Connection.OpenConnection();
            MySqlDataReader reader = Class_.Venta.BuscarMaxId(Connection.myConnection);
            if (reader.Read())
            {
                if (!reader.IsDBNull(0)) { max = reader.GetInt32(0); max++; }
            }
            Connection.CloseConnection();
            return max;
        }

        private void buttonComprobar_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxTipoPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            char validar = '0';

            try
            {
                idProducto2 = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                validar = this.dataGridView1.CurrentRow.Cells[3].Value.ToString()[0];

                if (this.dataGridView1.CurrentRow.Cells[3].Value != null && Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[3].Value) > 0)
                {
                    int Quantity = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[3].Value);
                    Connection.OpenConnection();
                    int Stock = CheckStock(idProducto2);
                    Connection.CloseConnection();

                    if (Quantity > Stock)
                    {
                        MessageBox.Show("No hay suficiente Stock");
                        this.dataGridView1.CurrentRow.Cells[3].Value = 1;
                        UpdateQuantity();
                        Total(comboBoxTipoPago.Text);
                    }
                    else
                    {
                        UpdateQuantity();
                        Total(comboBoxTipoPago.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Especifique un número válido");
                    this.dataGridView1.CurrentRow.Cells[3].Value = "";
                }
            }
            catch (Exception)
            {
                if (!char.IsDigit(Convert.ToChar(validar)))
                {
                    MessageBox.Show("Debe especificar un número para este campo");
                }
                if (this.dataGridView1.CurrentRow.Cells[3].Value != null)
                {
                    MessageBox.Show("No se puede modificar cantidad sin haber seleccionado\nun producto");
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
            }


        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Connection.OpenConnection();

                bool flag = false;

                MySqlDataReader reader = Class_.Producto.BuscarProducto(Connection.myConnection, idProducto2);

                if (reader.Read())
                {
                    if (Duplicate(idProducto2)) { flag = true; }

                    Class_.Producto producto = GetProduct(reader);

                    if (producto.Tipo == "Videojuegos" && producto.Status == "Seminuevo")
                    {
                        double PrecioCompra = producto.Precio * .5;
                        PrecioCompra = Math.Round(PrecioCompra, 1);

                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index - 1);

                        Connection.CloseConnection();
                        Connection.OpenConnection();

                        if (1 > producto.Stock)
                        {
                            MessageBox.Show("No hay suficiente Stock");
                        }
                        else
                        {
                            if (flag)
                            {
                                AddQuantity(idProducto2);
                            }
                            else
                            {
                                dataGridView1.Rows.Add(idProducto2, producto.Nombre, producto.Status, 1, PrecioCompra, PrecioCompra);
                            }
                        }
                    }
                    else
                    {
                        if(producto.Tipo != "Videojuegos") { MessageBox.Show("Solo se pueden comprar Videojuegos"); }
                        else if(producto.Status != "Seminuevo") { MessageBox.Show("ERROR, Solo se pueden comprar juegos usados"); }
                    }
                }
                else
                {
                    MessageBox.Show("Codigo no existe");
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index - 1);
                }
                Connection.CloseConnection();
                Total(comboBoxTipoPago.Text);
            }
        }

        // Regresa un producto dependiendo del query
        private Class_.Producto GetProduct(MySqlDataReader reader)
        {
            Class_.Producto producto = new Class_.Producto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetFloat(6), reader.GetInt32(7),
                    reader.GetString(8), reader.GetBoolean(9));

            return producto;
        }

        //Suma el precio por cada producto y cantidad y da un SubTotal de la venta
        private void Total(string TipoPago)
        {
            decimal total = 0;
            double bono = 0;

            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                total += (Convert.ToDecimal(Row.Cells["Importe"].Value));
            }

            if(TipoPago == "Electrónico")
            {
                bono = Convert.ToDouble(total) * .4;
                bono = Math.Round(bono, 1);
            }

            textBoxBono.Text = bono.ToString();
            textBoxTotal.Text = (Convert.ToDecimal(bono) + total).ToString();
        }

        //Se encarga de notificar si algún detalle de registro está repetido
        private bool Duplicate(string ID)
        {
            bool flag = false;
            int i = 0;

            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                if (ID == Convert.ToString(Row.Cells["IDProducto"].Value))
                {
                    i++;
                }
                if (i >= 2) { flag = true; }
            }

            return flag;
        }

        //Aumenta la cantidad en caso de que se registré un producto ya marcado antes
        private void AddQuantity(string idProducto)
        {
            int currentQuantity = 0;
            decimal price = 0;
            int QuantityProduct = CheckStock(idProducto);
            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                if (idProducto == Convert.ToString(Row.Cells["IDProducto"].Value))
                {
                    currentQuantity = Convert.ToInt32(Row.Cells["Cantidad"].Value);
                    price = Convert.ToDecimal(Row.Cells["Precio"].Value);

                    if (QuantityProduct > currentQuantity)
                    {
                        currentQuantity++;
                        if (currentQuantity > 10)
                        {
                            MessageBox.Show("No se pueden comprar mas de 10 títulos");
                            currentQuantity = 10;
                        }
                        Row.Cells["Cantidad"].Value = currentQuantity;
                        Row.Cells["Importe"].Value = price * currentQuantity;
                    }
                    else
                    {
                        MessageBox.Show("No hay mas stock");
                    }
                }
            }        
        }

        //Actualiza el precio si se modifica la cantidad
        private void UpdateQuantity()
        {
            string idProducto = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int quantity = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[3].Value);
            decimal price = Convert.ToDecimal(this.dataGridView1.CurrentRow.Cells[4].Value);

            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                if (idProducto == Convert.ToString(Row.Cells["IDProducto"].Value))
                {
                    Row.Cells["Importe"].Value = quantity * price;
                }
            }
        }

        //Verifica si el producto cuenta con suficiente stock para ser vendido
        private int CheckStock(string idProducto)
        {
            MySqlDataReader reader = Class_.Producto.BuscarProducto(Connection.myConnection, idProducto);

            if (reader.Read())
            {
                Class_.Producto product = GetProduct(reader);
                return product.Stock;
            }
            return 0;
        }

        //Agrega venta
        private void AddSale()
        {
            Connection.OpenConnection();
            Class_.Venta nVenta = new Class_.Venta(1, fecha, comboBoxTipoPago.Text, "V", true, textBoxSaldo.Text, int.Parse(textBoxIDcliente.Text), Empleado.ID);
            Class_.Venta.AgregarVenta(Connection.myConnection, nVenta);
            MessageBox.Show("Compra exitosa", "GRACIAS POR SU COMPRA", MessageBoxButtons.OK, MessageBoxIcon.None);
            Connection.CloseConnection();
        }

        //Agrega Detalle de venta
        private void AddDetail(int idProduct, int idSale, int quantity, decimal price)
        {
            Class_.SaleDetail newSale = new Class_.SaleDetail(idProduct, idSale, quantity, price);
            Class_.SaleDetail.AddDetail(Connection.myConnection, newSale);
        }

        //Recorre Cada Row del datagridview e inserta los detalles de venta
        private void AddAllDetails()
        {
            int i = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (i == dataGridView1.RowCount - 1)
                    break;

                Connection.OpenConnection();
                AddDetail(Convert.ToInt32(row.Cells[0].Value), NoFolio, Convert.ToInt32(row.Cells["Cantidad"].Value),
                    Convert.ToDecimal(row.Cells["Precio"].Value));
                Connection.CloseConnection();

                i++;
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                Total(comboBoxTipoPago.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un producto para eliminar");
            }
        }

        private void IncreaseStock()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string idProduct = Convert.ToString(row.Cells[0].Value);
                int StockDecrease = Convert.ToInt32(row.Cells["Cantidad"].Value);

                Connection.OpenConnection();
                MySqlDataReader reader = Class_.Producto.BuscarProducto(Connection.myConnection, idProduct);
                if (reader.Read())
                {
                    Class_.Producto product = GetProduct(reader);
                    product.Stock = product.Stock + StockDecrease;

                    Connection.CloseConnection();

                    Connection.OpenConnection();
                    product.Ruta = product.Ruta.Replace(@"\", @"\\");
                    Class_.Producto.ModificarProducto(Connection.myConnection, product);
                }

                Connection.CloseConnection();
            }
        }

        private void AddBuy()
        {
            Connection.OpenConnection();
            Class_.Venta nVenta = new Class_.Venta(1, fecha, comboBoxTipoPago.Text, "C", true, textBoxSaldo.Text, int.Parse(textBoxIDcliente.Text), Empleado.ID);
            Class_.Venta.AgregarVenta(Connection.myConnection, nVenta);
            MessageBox.Show("Compra Exitosa", "GRACIAS POR SU COMPRA", MessageBoxButtons.OK, MessageBoxIcon.None);
            Connection.CloseConnection();
        }

        private void AddDetailB(int idProduct, int idSale, int quantity, decimal price)
        {
            Class_.SaleDetail newSale = new Class_.SaleDetail(idProduct, idSale, quantity, price);
            Class_.SaleDetail.AddDetail(Connection.myConnection, newSale);
        }

        private void AddAllDetailsB()
        {
            int i = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (i == dataGridView1.RowCount - 1)
                    break;

                Connection.OpenConnection();
                AddDetail(Convert.ToInt32(row.Cells[0].Value), NoFolio, Convert.ToInt32(row.Cells["Cantidad"].Value),
                    Convert.ToDecimal(row.Cells["Precio"].Value));
                Connection.CloseConnection();

                i++;
            }
        }

        private void AddSaldo()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string idCliente = textBoxIDcliente.Text;

                Connection.OpenConnection();
                MySqlDataReader reader = Class_.Cliente.BuscarCliente(Connection.myConnection, idCliente);
                if (reader.Read())
                {
                    Class_.Cliente cliente = new Class_.Cliente(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7),
                        reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12),
                        reader.GetString(13), reader.GetFloat(14), reader.GetBoolean(15));

                    cliente.Saldo = cliente.Saldo + float.Parse(textBoxTotal.Text);
                    MessageBox.Show(cliente.Saldo.ToString());
                    Connection.CloseConnection();

                    Connection.OpenConnection();
                    Class_.Cliente.ModifyBenefic(Connection.myConnection, cliente);
                    Connection.CloseConnection();
                    break;
                }

                Connection.CloseConnection();
            }
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if ((textBoxIDcliente.Text == "") || (comboBoxTipoPago.Text == ""))
            {
                MessageBox.Show("Favor de llenar los campos requeridos");
            }
            else
            {
                if(comboBoxTipoPago.Text == "Electrónico") { AddSaldo(); }
                IncreaseStock();
                AddBuy();
                AddAllDetailsB();
                this.Close();
            }
        }

        private void comboBoxTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            Total(comboBoxTipoPago.Text);
        }

        private void buttonComprobar_Click_1(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            MySqlDataReader reader = Class_.Cliente.BuscarCliente(Connection.myConnection, textBoxIDcliente.Text);
            if (reader.Read())
            {
                if (reader.GetBoolean(15))
                {
                    textBoxNombreCliente.Text = reader.GetString(1) + " " + reader.GetString(2);
                    textBoxSaldo.Text = reader.GetFloat(14).ToString();
                    textBoxAdress.Text = reader.GetString(3);
                    textBoxTel.Text = reader.GetString(6);
                    textBoxEmail.Text = reader.GetString(5);
                    comboBoxTipoPago.Enabled = true;
                }
                else
                { MessageBox.Show("No existe ID"); }
            }
            else { MessageBox.Show("No existe ID"); }
            Connection.CloseConnection();
        }
    }
}
