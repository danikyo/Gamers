using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Interfaz_de_usuario.Class_
{
    class Producto
    {
        int idProducto;
        string Nombre;
        string Tipo;
        string Consola;
        string Status;
        string Precio;
        int Stock;
        bool Disponible;

        public Producto(int idProducto, string Nombre, string Tipo, string Consola, string Status, string Precio, int Stock, bool disponible)
        {
            this.idProducto = idProducto;
            this.Nombre = Nombre;
            this.Tipo = Tipo;
            this.Consola = Consola;
            this.Status = Status;
            this.Precio = Precio;
            this.Stock = Stock;
            this.Disponible = disponible;
        }

        public static int AgregarProducto(MySqlConnection Connection, Producto producto)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO producto (pNombre, pTipo, pConsola, pStatus, pPrecio, pStock, pDisponible) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',true)", producto.Nombre, producto.Tipo, producto.Consola, producto.Status, producto.Precio, producto.Stock), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }

        public static IList<Producto> MostrarProductos(MySqlConnection Connection)
        {
            List<Producto> Nproducto = new List<Producto>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM producto"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Producto nProducto = new Producto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetBoolean(7));
                Nproducto.Add(nProducto);
            }
            return Nproducto;
        }

        public static MySqlDataReader BuscarProducto(MySqlConnection Connection, int idProducto)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM producto WHERE idProducto = '{0}'", idProducto), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static int ModificarProducto(MySqlConnection Connection, Producto producto)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE producto SET pNombre = '{1}', pTipo = '{2}', pConsola = '{3}', pStatus = '{4}', pPrecio = '{5}', pStock = '{6}'  WHERE idProducto = {0}", producto.idProducto, producto.Nombre, producto.Tipo, producto.Consola, producto.Status, producto.Precio, producto.Stock), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }

        public static int BajaProducto(MySqlConnection Connection, int idProducto)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE producto set pDisponible = 'false' WHERE idProducto = '{0}'",idProducto), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }
    }
}
