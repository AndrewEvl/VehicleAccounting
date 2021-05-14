using MySql.Data.MySqlClient;

namespace VehicleAccounting
{
    class DB
    {
        private readonly MySqlConnection _connection = new("server=localhost;port=3306;username=root;password=root;database=car_library");

        public void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
                _connection.Open();
        }

        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return _connection;
        }
    }
}