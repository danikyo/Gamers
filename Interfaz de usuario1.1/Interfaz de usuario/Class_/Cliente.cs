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
        string cNombre;
        string cApellidos;
        string cDireccion;
        string cFechaNac;
        string ce_mail;
        string cTel;
        string cRFC;
        string cDomFiscal;
        string cRazonSocial;
        string cCP;
        string cPais;
        string cEstado;
        string cMunicipio;
        float cSaldo;
        bool cdisponible;

        public Cliente(int idcliente, string Nombre, string Apellidos, string Direccion, string FechaNac, string e_mail, string Tel,
            string RFC, string DomFiscal, string RazonSocial, string CP, string Pais, string Estado, string Municipio, float Saldo, bool disponible)
        {
            this.idcliente = idcliente;
            this.cNombre = Nombre;
            this.cApellidos = Apellidos;
            this.cDireccion = Direccion;
            this.cFechaNac = FechaNac;
            this.ce_mail = e_mail;
            this.cTel = Tel;
            this.cRFC = RFC;
            this.cDomFiscal = DomFiscal;
            this.cRazonSocial = RazonSocial;
            this.cCP = CP;
            this.cPais = Pais;
            this.cEstado = Estado;
            this.cMunicipio = Municipio;
            this.cSaldo = Saldo;
            this.cdisponible = disponible;
        }

        public Cliente() { }

        public int ID
        {
            get { return idcliente; }
            set { idcliente = value; }
        }

        public string Nombre
        {
            get { return cNombre; }
            set { cNombre = value; }
        }

        public string Apellido
        {
            get { return cApellidos; }
            set { cApellidos = value; }
        }

        public string Direccion
        {
            get { return cDireccion; }
            set { cDireccion = value; }
        }

        public string FechaNac
        {
            get { return cFechaNac; }
            set { cFechaNac = value; }
        }

        public string E_mail
        {
            get { return ce_mail; }
            set { ce_mail = value; }
        }

        public string Tel
        {
            get { return cTel; }
            set { cTel = value; }
        }

        public string RFC
        {
            get { return cRFC; }
            set { cRFC = value; }
        }

        public string DomFiscal
        {
            get { return cDomFiscal; }
            set { cDomFiscal = value; }
        }

        public string RazonSocial
        {
            get { return cRazonSocial; }
            set { cRazonSocial = value; }
        }

        public string CP
        {
            get { return cCP; }
            set { cCP = value; }
        }

        public string Pais
        {
            get { return cPais; }
            set { cPais = value; }
        }

        public string Estado
        {
            get { return cEstado; }
            set { cEstado = value; }
        }

        public string Municipio
        {
            get { return cMunicipio; }
            set { cMunicipio = value; }
        }

        public float Saldo
        {
            get { return cSaldo; }
            set { cSaldo = value; }
        }

        public bool Disponible
        {
            get { return cdisponible; }
            set { cdisponible = value; }
        }

        public static int AgregarCliente(MySqlConnection Connection, Cliente cliente)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO cliente (cNombre, cApellido, cDireccion, cFechaNac, cEmail, cTel, cRFC, cDomFiscal, cRazonSocial, cCP, cPais, cEstado, cMunicipio, cSaldo, cDisponible) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','0',true)",
            cliente.Nombre, cliente.cApellidos, cliente.cDireccion, cliente.cFechaNac, cliente.ce_mail, cliente.cTel, cliente.cRFC, cliente.cDomFiscal, cliente.cRazonSocial, cliente.cCP, cliente.cPais, cliente.cEstado, cliente.cMunicipio), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }

        public static IList<Cliente> MostrarClientes(MySqlConnection Connection)
        {
            List<Cliente> Ncliente = new List<Cliente>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM cliente Where cDisponible = true"),Connection);
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
            cliente.Nombre, cliente.cApellidos, cliente.cDireccion, cliente.cFechaNac, cliente.ce_mail, cliente.cTel, cliente.cRFC, cliente.cDomFiscal, cliente.cRazonSocial, cliente.cCP, cliente.cPais, cliente.cEstado, cliente.cMunicipio, cliente.cSaldo, cliente.idcliente), Connection);
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
