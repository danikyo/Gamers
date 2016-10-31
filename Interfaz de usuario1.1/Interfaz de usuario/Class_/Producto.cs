using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Interfaz_de_usuario.Class_
{
    public class Producto
    {
        int idProducto;
        string pNombre;
        string pTipo;
        string pConsola;
        string pGenero;
        string pStatus;
        float pPrecio;
        int pStock;
        string pImagen;
        bool pDisponible;

        public Producto(int idProducto, string Nombre, string Tipo, string Consola, string Genero, string Status, float Precio, int Stock, string Imagen, bool disponible)
        {
            this.idProducto = idProducto;
            this.pNombre = Nombre;
            this.pTipo = Tipo;
            this.pConsola = Consola;
            this.pGenero = Genero;
            this.pStatus = Status;
            this.pPrecio = Precio;
            this.pStock = Stock;
            this.pImagen = Imagen;
            this.pDisponible = disponible;
        }

        public int ID
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public string Nombre
        {
            get { return pNombre; }
            set { pNombre = value; }
        }

        public string Tipo
        {
            get { return pTipo; }
            set { pTipo = value; }
        }

        public string Consola
        {
            get { return pConsola; }
            set { pConsola = value; }
        }

        public string Genero
        {
            get { return pGenero; }
            set { pGenero = value; }
        }

        public string Status
        {
            get { return pStatus; }
            set { pStatus = value; }
        }

        public float Precio
        {
            get { return pPrecio; }
            set { pPrecio = value; }
        }

        public int Stock
        {
            get { return pStock; }
            set { pStock = value; }
        }

        public bool disponible
        {
            get { return pDisponible; }
            set { pDisponible = value; }
        }

        public string Ruta
        {
            get { return pImagen; }
            set { pImagen = value; }
        }

        public static int AgregarProducto(MySqlConnection Connection, Producto producto)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO producto (pNombre, pTipo, pConsola, pGenero, pStatus, pPrecio, pStock, pFoto, pDisponible) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', true)", producto.pNombre, producto.pTipo, producto.pConsola, producto.pGenero, producto.pStatus, producto.pPrecio, producto.pStock, producto.pImagen), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }

        public static IList<Producto> MostrarProductos(MySqlConnection Connection)
        {
            List<Producto> Nproducto = new List<Producto>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM producto WHERE pDisponible = true"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Producto nProducto = new Producto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetFloat(6), reader.GetInt32(7), reader.GetString(8), reader.GetBoolean(9));
                Nproducto.Add(nProducto);
            }
            return Nproducto;
        }

        public static MySqlDataReader BuscarProducto(MySqlConnection Connection, string idProducto)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM producto WHERE idProducto = '{0}'", idProducto), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static int ModificarProducto(MySqlConnection Connection, Producto producto)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE producto SET pNombre = '{1}', pTipo = '{2}', pConsola = '{3}', pGenero = '{4}', pStatus = '{5}', pPrecio = '{6}', pStock = '{7}', pFoto = '{8}'  WHERE idProducto = {0}", producto.idProducto, producto.Nombre, producto.Tipo, producto.Consola, producto.Genero, producto.Status, producto.Precio, producto.Stock, producto.pImagen), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }

        public static int BajaProducto(MySqlConnection Connection, int idProducto)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE producto SET pDisponible = false WHERE idProducto = '{0}'",idProducto), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }
    }
}
