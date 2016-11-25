using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Interfaz_de_usuario.Class_
{
    public class Connection
    {
        public MySqlConnection myConnection;

        public Connection()
        {
            myConnection = new MySqlConnection("server = db4free.net; port = 3306; database = databasedm94; Uid = danikyo; pwd = abc123");
        }

        public bool OpenConnection()
        {
            try
            {
                myConnection.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                return false;
                throw ex;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                myConnection.Close();
                return true;
            }
            catch(MySqlException ex)
            {
                return false;
                throw ex;
            }
        }
    }
}
