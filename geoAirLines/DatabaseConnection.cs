using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geoAirLines
{
    internal class DatabaseConnection
    {
        private static SqlConnection? _connection;

        public static SqlConnection GetConnection()
        {
            if (_connection == null)
            {
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={documentsPath}\AirLinesDb.mdf;Integrated Security=True;Connect Timeout=30";
                _connection = new SqlConnection(connectionString);
            }
            return _connection;
        }
    }
}
