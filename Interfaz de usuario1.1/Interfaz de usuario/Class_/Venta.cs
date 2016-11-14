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
        string vFecha;
        string vTipoPago;
        string VC;
        string balance;
        int vEmpleado_idEmpleado;
        int vCliente_idCliente;
        bool disponible;

        public Venta(int idVenta, string Fecha, string TipoPago, string VC, bool disponible, string balance, int Empleado_idEmpleado, int Cliente_idCliente)
        {
            this.idVenta = idVenta;
            this.vFecha = Fecha;
            this.vTipoPago = TipoPago;
            this.VC = VC;
            this.disponible = disponible;
            this.balance = balance;
            this.vEmpleado_idEmpleado = Empleado_idEmpleado;
            this.vCliente_idCliente = Cliente_idCliente;
        }

        public int ID
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        public string Fecha
        {
            get { return vFecha; }
            set { vFecha = value; }
        }

        public int ID_Empleado
        {
            get { return vEmpleado_idEmpleado; }
            set { vEmpleado_idEmpleado = value; }
        }

        public int ID_Cliente
        {
            get { return vCliente_idCliente; }
            set { vCliente_idCliente = value; }
        }

        public string TipoPago
        {
            get { return vTipoPago; }
            set { vTipoPago = value; }
        }

        public string vc
        {
            get { return VC; }
            set { VC = value; }
        }

        public string Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public bool Disponible
        {
            get { return disponible; }
            set { disponible = value; }
        }

        public static int AgregarVenta(MySqlConnection Connection, Venta venta)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO venta (vFecha, vTipoPago, VC, vSaldo, Empleado_idEmpleado, Cliente_idCliente, vDisponible) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', true)", venta.vFecha, venta.TipoPago, venta.vc, venta.balance, venta.vEmpleado_idEmpleado, venta.vCliente_idCliente), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }

        public static IList<Venta> MostrarVentas(MySqlConnection Connection)
        {
            List<Venta> Nventa = new List<Venta>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM venta WHERE vDisponible = true AND VC = 'V'"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Venta venta = new Venta(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5), reader.GetInt32(6), reader.GetInt32(7));
                Nventa.Add(venta);
            }
            return Nventa;
        }

        public static IList<Venta> MostrarCompras(MySqlConnection Connection)
        {
            List<Venta> Nventa = new List<Venta>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM venta WHERE vDisponible = true AND VC = 'C'"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Venta venta = new Venta(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5), reader.GetInt32(6), reader.GetInt32(7));
                Nventa.Add(venta);
            }
            return Nventa;
        }

        public static MySqlDataReader BuscarVenta(MySqlConnection Connection, string idVenta)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM venta WHERE idventa = '{0}'", idVenta), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static int CancelarVenta(MySqlConnection Connection, string idVenta)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE venta SET vDisponible = false WHERE idVenta = {0}", idVenta), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }

        public static MySqlDataReader BuscarMaxId(MySqlConnection Connection)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT MAX(idVenta) AS idVenta FROM venta"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }
    }
}
