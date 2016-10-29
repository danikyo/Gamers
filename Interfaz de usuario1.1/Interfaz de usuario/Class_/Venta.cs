using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Interfaz_de_usuario.Class_
{
    class Venta
    {
        int idVenta;
        DateTime Fecha;
        int Empleado_idEmpleado;
        int Cliente_idCliente;
        //bool vDisponible;

        public Venta(int idVenta, DateTime Fecha, int Empleado_idEmpleado, int Cliente_idCliente)
        {
            this.idVenta = idVenta;
            this.Fecha = Fecha;
            this.Empleado_idEmpleado = Empleado_idEmpleado;
            this.Cliente_idCliente = Cliente_idCliente;
        }

        public int AgregarVenta(MySqlConnection Connection, Venta venta)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO venta (idVenta, Fecha, Empleado_idEmpleado, Cliente_idCliente, vDisponible) VALUES ('{0}','{1}','{2}','{3}','true')", venta.idVenta, venta.Fecha, venta.Empleado_idEmpleado, venta.Cliente_idCliente), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }

        public IList<Venta> MostrarVentas(MySqlConnection Connection)
        {
            List<Venta> Nventa = new List<Venta>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM factura"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Venta venta = new Venta(reader.GetInt32(0), reader.GetDateTime(1), reader.GetInt32(2), reader.GetInt32(3));
                Nventa.Add(venta);
            }
            return Nventa;
        }

        public MySqlDataReader BuscarVenta(MySqlConnection Connection, int idVenta)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM venta WHERE idventa = '{0}'", idVenta), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public int CancelarFactura(MySqlConnection Connection, int idVenta)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE venta SET vDisponible = 'false' WHERE idVenta = {0}", idVenta), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }
    }
}
