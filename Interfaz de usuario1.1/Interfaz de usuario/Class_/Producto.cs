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
        string pNombre;
        string pTipo;
        string pConsola;
        string pStatus;
        string pPrecio;
        string pStock;
        bool pDisponible;

        public Producto(int idProducto, string pNombre, string pTipo, string pConsola, string pStatus, string pPrecio, string pStock)
        {
            this.idProducto = idProducto;
            this.pNombre = pNombre;
            this.pTipo = pTipo;
            this.pConsola = pConsola;
            this.pStatus = pStatus;
            this.pPrecio = pPrecio;
            this.pStock = pStock;
        }

        public int AgregarProducto(MySqlConnection Connection, Producto producto)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO producto (idProducto, pNombre, pTipo, pConsola, pStatus, pPrecio, pStock, pDisponible) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','true')", producto.idProducto, producto.pNombre, producto.pTipo, producto.pConsola, producto.pStatus, producto.pPrecio, producto.pStock), Connection);
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
                Producto nProducto = new Producto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                Nproducto.Add(nProducto);
            }
            return Nproducto;
        }

        public MySqlDataReader BuscarProducto(MySqlConnection Connection, int idProducto)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM producto WHERE idProducto = '{0}'", idProducto), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public int ModificarProducto(MySqlConnection Connection, Producto producto)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE producto SET pNombre = '{1}', pTipo = '{2}', pConsola = '{3}', pStatus = '{4}', pPrecio = '{5}', pStock = '{6}'  WHERE idProducto = {0}", producto.idProducto, producto.pNombre, producto.pTipo, producto.pConsola, producto.pStatus, producto.pPrecio, producto.pStock), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }

        public int BajaProducto(MySqlConnection Connection, int idProducto)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE producto set pDisponible = 'false' WHERE idProducto = '{0}'",idProducto), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }
    }
}
