using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Interfaz_de_usuario.Class_
{
    class Factura
    {
        int idFactura;
        DateTime Fecha;
        //bool Disponible;

        public Factura(int idFactura, DateTime Fecha)
        {
            this.idFactura = idFactura;
            this.Fecha = Fecha;
        }

        public int AgregarFactura(MySqlConnection Connection, Factura factura)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO factura (idFactura, fFecha, fDisponible) VALUES ('{0}','{1}','true')", factura.idFactura, factura.Fecha), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }

        public IList<Factura> MostrarFacturas(MySqlConnection Connection)
        {
            List<Factura> Nfactura = new List<Factura>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM factura"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Factura factura = new Factura(reader.GetInt32(0), reader.GetDateTime(1));
                Nfactura.Add(factura);
            }
            return Nfactura;
        }

        public MySqlDataReader BuscarFactura(MySqlConnection Connection, int idFactura)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM factura WHERE idFactura = '{0}'", idFactura), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public int CancelarFactura(MySqlConnection Connection, int idfactura)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE factura SET fDisponible = 'false' WHERE idFactura = {0}", idfactura), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }
    }
}
