using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Interfaz_de_usuario.Class_
{
    class Empleado
    {
        int idempleado;
        string Nombre;
        string Apellido;
        string Puesto;
        string Contrasena;
        
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

        public static int AgregarEmpleado(MySqlConnection Connection, Empleado empleado)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO empleado (eNombre, eApellido, ePuesto, eContrasena) VALUES ('{0}','{1}','{2}','{3}')",empleado.Nombre,empleado.Apellido,empleado.Puesto,empleado.Contrasena), Connection);
            int retorno = command.ExecuteNonQuery();
            return retorno;
        }
    }
}
