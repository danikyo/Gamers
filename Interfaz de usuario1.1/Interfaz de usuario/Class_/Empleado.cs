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
        string Nombre;
        string Apellido;
        string Puesto;
        string Contrasena;
        bool Status;
        
        public Empleado() { }

        public Empleado(int idempleado, string Nombre, string Apellido, string Puesto, string Contrasena, bool Status)
        {
            this.idempleado = idempleado;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Puesto = Puesto;
            this.Contrasena = Contrasena;
            this.Status = Status;
        }

        public int idEmpleado
        {
            get { return idempleado; }
            set { idempleado = value; }
        }

        public string eNombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string eApellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        public string ePuesto
        {
            get { return Puesto; }
            set { Puesto = value; }
        }

        public string eContrasena
        {
            get { return Contrasena; }
            set { Contrasena = value; }
        }

        public bool eStatus
        {
            get { return Status; }
            set { Status = value; }
        }

        public static int AgregarEmpleado(MySqlConnection Connection, Empleado empleado)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO empleado (eNombre, eApellido, ePuesto, eContrasena, eStatus) VALUES ('{0}','{1}','{2}','{3}', 'True')",empleado.Nombre,empleado.Apellido,empleado.Puesto,empleado.Contrasena), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
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
    }
}
