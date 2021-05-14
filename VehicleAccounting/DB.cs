using MySql.Data.MySqlClient;

namespace VehicleAccounting
{
    class DB
    {
        MySqlConnection connection = new ("server=localhost;port=3306;username=root;password=root;database=car_library");
        
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        
        public void closeConnection()
        {
            if(connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection() {
            return connection;
        }
    }
}