using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Interfaz_de_usuario.Class_
{
    public class Cliente
    {
        int idcliente;
        string Nombre;
        string Apellidos;
        string Direccion;
        string FechaNac;
        string e_mail;
        string Tel;
        string RFC;
        string DomFiscal;
        string RazonSocial;
        string CP;
        string Pais;
        string Estado;
        string Municipio;
        float Saldo;
        bool disponible;

        /*public Cliente(int idcliente, string Nombre, string Apellidos, DateTime FechaNac, float Saldo)
        {
            this.idcliente = idcliente;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.FechaNac = FechaNac;
            this.Saldo = Saldo;
        }*/

        public Cliente(int idcliente, string Nombre, string Apellidos, string Direccion, string FechaNac, string e_mail, string Tel,
            string RFC, string DomFiscal, string RazonSocial, string CP, string Pais, string Estado, string Municipio, float Saldo, bool disponible)
        {
            this.idcliente = idcliente;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Direccion = Direccion;
            this.FechaNac = FechaNac;
            this.e_mail = e_mail;
            this.Tel = Tel;
            this.RFC = RFC;
            this.DomFiscal = DomFiscal;
            this.RazonSocial = RazonSocial;
            this.CP = CP;
            this.Pais = Pais;
            this.Estado = Estado;
            this.Municipio = Municipio;
            this.Saldo = Saldo;
            this.disponible = disponible;
        }

        public Cliente() { }

        public int cidcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }

        public string cNombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string cApellido
        {
            get { return Apellidos; }
            set { Apellidos = value; }
        }

        public string cDireccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

        public string cFechaNac
        {
            get { return FechaNac; }
            set { FechaNac = value; }
        }

        public string cE_mail
        {
            get { return e_mail; }
            set { e_mail = value; }
        }

        public string cTel
        {
            get { return Tel; }
            set { Tel = value; }
        }

        public string cRFC
        {
            get { return RFC; }
            set { RFC = value; }
        }

        public string cDomFiscal
        {
            get { return DomFiscal; }
            set { DomFiscal = value; }
        }

        public string cRazonSocial
        {
            get { return RazonSocial; }
            set { RazonSocial = value; }
        }

        public string cCP
        {
            get { return CP; }
            set { CP = value; }
        }

        public string cPais
        {
            get { return Pais; }
            set { Pais = value; }
        }

        public string cEstado
        {
            get { return Estado; }
            set { Estado = value; }
        }

        public string cMunicipio
        {
            get { return Municipio; }
            set { Municipio = value; }
        }

        public float cSaldo
        {
            get { return Saldo; }
            set { Saldo = value; }
        }

        public bool cDisponible
        {
            get { return disponible; }
            set { disponible = value; }
        }

        public static int AgregarCliente(MySqlConnection Connection, Cliente cliente)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO cliente (cNombre, cApellido, cDireccion, cFechaNac, cEmail, cTel, cRFC, cDomFiscal, cRazonSocial, cCP, cPais, cEstado, cMunicipio, cSaldo, cDisponible) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','0','1')",
            cliente.Nombre, cliente.Apellidos, cliente.Direccion, cliente.FechaNac, cliente.e_mail, cliente.Tel, cliente.RFC, cliente.DomFiscal, cliente.RazonSocial, cliente.CP, cliente.Pais, cliente.Estado, cliente.Municipio, cliente.Saldo), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }

        public static IList<Cliente> MostrarClientes(MySqlConnection Connection)
        {
            List<Cliente> Ncliente = new List<Cliente>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM cliente"),Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Cliente cliente = new Cliente(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetFloat(14), reader.GetBoolean(15));
                Ncliente.Add(cliente);
            }
            return Ncliente;
        }

        public static int ModificarCliente(MySqlConnection Connection, Cliente cliente)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE cliente SET cNombre = '{0}', cApellido = '{1}', cDireccion = '{2}', cFechaNac = '{3}', cEmail = '{4}', cTel = '{5}', cRFC = '{6}', cDomFiscal = '{7}', cRazonSocial = '{8}', cCP = '{9}', cPais = '{10}', cEstado = '{11}', cMunicipio = '{12}', cSaldo = '{13}' WHERE idCliente = {14}",
            cliente.Nombre, cliente.Apellidos, cliente.Direccion, cliente.FechaNac, cliente.e_mail, cliente.Tel, cliente.RFC, cliente.DomFiscal, cliente.RazonSocial, cliente.CP, cliente.Pais, cliente.Estado, cliente.Municipio, cliente.Saldo, cliente.idcliente), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }

        public static MySqlDataReader BuscarCliente(MySqlConnection Connection, string idCliente)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM cliente WHERE idCliente = '{0}'", idCliente),Connection);
            MySqlDataReader Reader = command.ExecuteReader();
            return Reader;
        }

        public static int BajaCliente(MySqlConnection Connection, int idCliente)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE cliente SET cDisponible = false WHERE idCliente = {0}", idCliente), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }
    }
}
