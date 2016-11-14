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
    public partial class Menu_Venta : Form
    {
        private Class_.Connection Connection;
        private Class_.Empleado Empleado;
        private string fecha;
        private string idProducto2;
        private int NoFolio;
        private string CurrentBalance;

        public Menu_Venta(Class_.Connection Connection, Class_.Empleado Empleado)
        {
            InitializeComponent();

            this.Connection = Connection;
            this.Empleado = Empleado;
        }

        //Cargar ventana Venta
        private void Menu_Venta_Load(object sender, EventArgs e)
        {
            SetFecha();

            textBoxNomEmpleado.Text = Empleado.Nombre + " " + Empleado.Apellido;

            NoFolio = MaxId();
            labelFolio.Text = "Folio No. " + NoFolio.ToString();
            textBoxSubTotal.Text = "0";
            textBoxIva.Text = "0";
            textBoxTotal.Text = "0";
            textBoxBalanceTotal.Text = "0";
            textBoxTotalTotal.Text = "0";
        }

        //Función para Conseguir Fecha y Hora actual
        private void SetFecha()
        {
            DateTime Hoy = DateTime.Now;
            fecha = Hoy.ToString("yyyy-MM-dd HH:mm:ss");
            string[] fechaHora = fecha.Split(' ');
            labelFecha.Text = fechaHora[0] + "\n" + fechaHora[1];
        }

        //Función para No escribir en Combobox
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //Boton Salir
        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Valores por defecto
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxIDcliente.Clear();
            textBoxNombreCliente.Clear();
            textBoxSaldo.Clear();

            comboBoxTipoPago.Text = "";
            textBoxSubTotal.Text = "0";
            textBoxIva.Text = "0";
            textBoxTotal.Text = "0";

            dataGridView1.Rows.Clear();
        }

        //Obtiene el Folio Actual
        private int MaxId()
        {
            int max = 1;
            Connection.OpenConnection();
            MySqlDataReader reader = Class_.Venta.BuscarMaxId(Connection.myConnection);
            if(reader.Read())
            {
                if(!reader.IsDBNull(0)) { max = reader.GetInt32(0); max++; }
            }
            Connection.CloseConnection();
            return max;
        }

        //Comprueba que el cliente existe
        private void buttonComprobar_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            MySqlDataReader reader = Class_.Cliente.BuscarCliente(Connection.myConnection, textBoxIDcliente.Text);
            if(reader.Read())
            {
                if (reader.GetBoolean(15))
                {
                    textBoxNombreCliente.Text = reader.GetString(1) + " " + reader.GetString(2);
                    textBoxSaldo.Text = reader.GetFloat(14).ToString();
                    textBoxAdress.Text = reader.GetString(3);
                    textBoxTel.Text = reader.GetString(6);
                    textBoxEmail.Text = reader.GetString(5);
                    dataGridView1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No existe ID");
                }
            }
            else { MessageBox.Show("No existe ID"); }
            Connection.CloseConnection();
        }


        //Notificar si no se llenaron campos antes del registro de un detalle y modifica la cantidad
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            char validar = '0';

            try
            {
                idProducto2 = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                validar = this.dataGridView1.CurrentRow.Cells[3].Value.ToString()[0];

                if (this.dataGridView1.CurrentRow.Cells[3].Value != null && Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[3].Value) > 0)
                {
                    //string idProducto = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
                    int Quantity = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[3].Value);
                    Connection.OpenConnection();
                    int Stock = CheckStock(idProducto2);
                    Connection.CloseConnection();

                    if (Quantity > Stock)
                    {
                        MessageBox.Show("No hay suficiente Stock");
                        this.dataGridView1.CurrentRow.Cells[3].Value = 1;
                        UpdateQuantity();
                        Total();
                    }
                    else
                    {
                        UpdateQuantity();
                        Total();
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
                if(this.dataGridView1.CurrentRow.Cells[3].Value != null)
                {
                    MessageBox.Show("No se puede modificar cantidad sin haber seleccionado\nun producto");
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
            }
        }

        //Agregar detalles con tecla Enter
        private void dataGridView1_KeyPress_1(object sender, KeyPressEventArgs e)
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
                    /*double Resultado = producto.Precio / 1.16;
                    Resultado = Math.Round(Resultado, 1);*/

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
                            comboBoxTipoPago.Enabled = true;
                            dataGridView1.Rows.Add(idProducto2, producto.Nombre, producto.Status, 1, producto.Precio, producto.Precio);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Codigo no existe");
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index - 1);
                }
                Connection.CloseConnection();
                Total();
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
        private void Total()
        {
            decimal total = 0;
            double subTotal = 0;
            double IVA = 0;
            //double totaltotal = 0;

            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                total += (Convert.ToDecimal(Row.Cells["Importe"].Value));
            }

            subTotal = Convert.ToDouble(total) / 1.16;
            subTotal = Math.Round(subTotal, 1);

            IVA = Convert.ToDouble(total) - subTotal;
            IVA = Math.Round(IVA, 1);

            if(comboBoxTipoPago.Text == "Electrónico") { textBoxBalanceTotal.Text = textBoxSaldo.Text; }
            else { textBoxBalanceTotal.Text = "0"; }

            textBoxTotalTotal.Text = (total - decimal.Parse(textBoxBalanceTotal.Text)).ToString();

            textBoxIva.Text = IVA.ToString();
            textBoxSubTotal.Text = subTotal.ToString();
            textBoxTotal.Text = total.ToString();
            
        }

        //Se encarga de notificar si algún detalle de registro está repetido
        private bool Duplicate(string ID)
        {
            bool flag = false;
            int i = 0;

            foreach(DataGridViewRow Row in dataGridView1.Rows)
            {
                if(ID == Convert.ToString(Row.Cells["IDProducto"].Value))
                {
                    i++;
                }
                if(i >= 2) { flag = true; }
            }

            return flag;
        }

        //Aumenta la cantidad en caso de que se registré un producto ya marcado antes
        private int AddQuantity(string idProducto)
        {
            int currentQuantity = 0;
            decimal price = 0;
            int QuantityProduct = CheckStock(idProducto);
            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                if(idProducto == Convert.ToString(Row.Cells["IDProducto"].Value))
                {
                    currentQuantity = Convert.ToInt32(Row.Cells["Cantidad"].Value);
                    price = Convert.ToDecimal(Row.Cells["Precio"].Value);

                    if(QuantityProduct > currentQuantity)
                    {
                        currentQuantity++;
                        Row.Cells["Cantidad"].Value = currentQuantity;
                        Row.Cells["Importe"].Value = price * currentQuantity;
                    }
                    else
                    {
                        MessageBox.Show("No hay mas stock");
                    }
                }
            }
            currentQuantity++;
            return currentQuantity;
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

        //borra un registro del dataGrid
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                Total();
                if(dataGridView1.RowCount <= 1)
                {
                    comboBoxTipoPago.Text = "Efectivo";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un producto para eliminar");
            }            
        }

        //Verifica si el producto cuenta con suficiente stock para ser vendido
        private int CheckStock(string idProducto)
        {
            MySqlDataReader reader = Class_.Producto.BuscarProducto(Connection.myConnection, idProducto);
       
            if(reader.Read())
            {
                Class_.Producto product = GetProduct(reader);
                return product.Stock;
            }
            return 0;
        }

        //Funcion para disminuir el Stock del producto para cada Fila del gridview
        private void DecreaseStock()
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                string idProduct = Convert.ToString(row.Cells[0].Value);
                int StockDecrease = Convert.ToInt32(row.Cells["Cantidad"].Value);

                Connection.OpenConnection();
                MySqlDataReader reader = Class_.Producto.BuscarProducto(Connection.myConnection, idProduct);
                if(reader.Read())
                {
                    Class_.Producto product = GetProduct(reader);
                    product.Stock = product.Stock - StockDecrease;

                    Connection.CloseConnection();

                    Connection.OpenConnection();
                    product.Ruta = product.Ruta.Replace(@"\", @"\\");
                    Class_.Producto.ModificarProducto(Connection.myConnection, product);
                }
                
                Connection.CloseConnection();
            }
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

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(i == dataGridView1.RowCount-1)
                    break;

                Connection.OpenConnection();
                AddDetail(Convert.ToInt32(row.Cells[0].Value), NoFolio, Convert.ToInt32(row.Cells["Cantidad"].Value),
                    Convert.ToDecimal(row.Cells["Precio"].Value));
                Connection.CloseConnection();

                i++;
            }
        }

        private void DecreaseBalance()
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

                    cliente.Saldo = cliente.Saldo - float.Parse(textBoxTotal.Text);
                    if(cliente.Saldo < 0)
                    {
                        cliente.Saldo = 0;
                    }
                    CurrentBalance = cliente.Saldo.ToString();
                    //MessageBox.Show(cliente.Saldo.ToString());
                    Connection.CloseConnection();

                    Connection.OpenConnection();
                    Class_.Cliente.ModifyBenefic(Connection.myConnection, cliente);
                    Connection.CloseConnection();
                    break;
                }

                Connection.CloseConnection();
            }
        }

        //Cuando todo esta verificado, se realiza la venta con el botón confirmar
        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if ((textBoxIDcliente.Text == "") || (comboBoxTipoPago.Text == "") || textBoxNombreCliente.Text == "")
            {
                MessageBox.Show("Favor de llenar los campos requeridos");
            }
            else if (textBoxSubTotal.Text == "0")
            {
                MessageBox.Show("Debe haber almenos un producto para realizar la venta");
            }
            else
            {
                if (comboBoxTipoPago.Text == "Electrónico") { DecreaseBalance(); MessageBox.Show(String.Format("Saldo Restante: {0}", CurrentBalance)); }
                DecreaseStock();
                AddSale();
                AddAllDetails();
                this.Close();
            }
        }

        private void comboBoxTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxSaldo.Text == "0" && comboBoxTipoPago.Text == "Electrónico")
            {
                MessageBox.Show("No se puede realizar pago electrónico\nporque el cliente no tiene saldo");
                comboBoxTipoPago.Text = "Efectivo";
            }
            Total();
        }
    }
}
