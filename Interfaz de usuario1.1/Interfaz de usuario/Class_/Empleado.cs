using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Interfaz_de_usuario.Class_
{
    public class Empleado
    {
        int idempleado;
        string eNombre;
        string eApellido;
        string ePuesto;
        string eContrasena;
        bool eStatus;
        
        public Empleado() { }

        public Empleado(int idempleado, string Nombre, string Apellido, string Puesto, string Contrasena, bool Status)
        {
            this.idempleado = idempleado;
            this.eNombre = Nombre;
            this.eApellido = Apellido;
            this.ePuesto = Puesto;
            this.eContrasena = Contrasena;
            this.eStatus = Status;
        }

        public int ID
        {
            get { return idempleado; }
            set { idempleado = value; }
        }

        public string Nombre
        {
            get { return eNombre; }
            set { eNombre = value; }
        }

        public string Apellido
        {
            get { return eApellido; }
            set { eApellido = value; }
        }

        public string Puesto
        {
            get { return ePuesto; }
            set { ePuesto = value; }
        }

        public string Contrasena
        {
            get { return eContrasena; }
            set { eContrasena = value; }
        }

        public bool Status
        {
            get { return eStatus; }
            set { eStatus = value; }
        }

        public static int AgregarEmpleado(MySqlConnection Connection, Empleado empleado)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO empleado (eNombre, eApellido, ePuesto, eContrasena, eStatus) VALUES ('{0}','{1}','{2}','{3}',True)",empleado.Nombre,empleado.Apellido,empleado.Puesto,empleado.Contrasena), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }

        public static IList<Empleado> MostrarEmpleado(MySqlConnection Connection)
        {
            List<Empleado> Nempleado = new List<Empleado>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM empleado WHERE eStatus = true"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Empleado empleado = new Empleado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(5));
                Nempleado.Add(empleado);
            }
            return Nempleado;
        }

        public static MySqlDataReader BuscarEmpleado(MySqlConnection Connection, string IDempleado)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM empleado WHERE idempleado = '{0}'", IDempleado), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static int ModificarEmpleado(MySqlConnection Connection, Empleado empleado)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE empleado SET eNombre = '{0}', eApellido = '{1}', ePuesto = '{2}', eContrasena = '{3}' WHERE idEmpleado = {4}", empleado.Nombre, empleado.Apellido, empleado.Puesto, empleado.Contrasena, empleado.idempleado), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }
        
        public static int BajaEmpleado(MySqlConnection Connection, int idempleado)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE empleado SET eStatus = false WHERE  idEmpleado = {0}",idempleado), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }

        public static MySqlDataReader BuscarMaxId(MySqlConnection Connection)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT MAX(idEmpleado) AS idEmpleado FROM empleado"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }
    }
}
