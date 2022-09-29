using MySql.Data.MySqlClient;

namespace MyWebApi.Data
{
    public class MySqlDbConnection
    {
        public string ConnectionString { get; set; }

        public MySqlDbConnection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public MySqlConnection GetMySqlConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}