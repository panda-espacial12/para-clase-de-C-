using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexión
{
    public class DB
    {
        private string _connectionstring;
        protected SqlConnection _connection
        
        public DB(string server, string db, string user, string password)
        {
            _connectionstring = $"Data Source={server}; initial catalog={db};" +
                $"User={user};password={password}";
        }

        public void connect()
        {
            _connection = new SqlConnection(_connection);
            _connection.Open();
        }

        //con esto cerramos la conecion 
        public void close()
        {
            if(_connection != null && _connection.State ==System.Data.ConnectionState.Open)
            _connection.Close();
        }
    }

}
