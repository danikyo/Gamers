using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Interfaz_de_usuario.Class_
{
    class SaleDetail
    {
        int idProduct;
        int idSale;
        int quantity;
        decimal price;

        public SaleDetail(int idProduct, int idSale, int quantity, decimal price)
        {
            this.idProduct = idProduct;
            this.idSale = idSale;
            this.quantity = quantity;
            this.price = price;
        }

        public int ID_Product
        {
            get { return idProduct; }
            set { idProduct = value; }
        }

        public int ID_Sale
        {
            get { return idSale; }
            set { idSale = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public static int AddDetail(MySqlConnection Connection, SaleDetail saleDetail)
        {
            string Query = "INSERT INTO detalleventa (Producto_idProducto, Venta_idVenta, Cantidad, Precio) VALUES({0}, {1}, {2}, {3})";
            MySqlCommand command = new MySqlCommand(String.Format(Query, saleDetail.idProduct, saleDetail.idSale, saleDetail.quantity, saleDetail.price), Connection);
            int Confirmation = command.ExecuteNonQuery();
            return Confirmation;
        }

        public static SaleDetail SearchDetail(MySqlConnection Connection, string idSale)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM detalleventa WHERE Venta_idVenta = '{0}'", idSale), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            SaleDetail newSale = new SaleDetail(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetDecimal(3));
            return newSale;
        }

        public static MySqlDataAdapter ShowDetail(MySqlConnection Connection, string idSale)
        {
            string Query = ("select producto.idProducto as ID_Producto, producto.pNombre as Nombre, producto.pStatus as Status, detalleventa.Cantidad, detalleventa.Precio as Precio, Round(detalleventa.Cantidad * detalleventa.Precio, 1) as Importe from detalleventa INNER JOIN producto ON detalleventa.Producto_idProducto = producto.idProducto WHERE detalleventa.Venta_idVenta = {0}");
            MySqlDataAdapter da = new MySqlDataAdapter(String.Format(Query,idSale), Connection);
            return da;
        }
    }
}
