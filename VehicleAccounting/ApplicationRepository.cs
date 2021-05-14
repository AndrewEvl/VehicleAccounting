using System.Data;
using MySql.Data.MySqlClient;

namespace VehicleAccounting
{
    public class ApplicationRepository
    {
        private readonly DB               _db      = new();
        private readonly MySqlDataAdapter _adapter = new();
        
        public DataTable FindAllBrand()
        {
            DataTable table = new DataTable();
            MySqlCommand finaAllBrandQuery = new MySqlCommand("SELECT * FROM car_brand", _db.GetConnection());

            _db.OpenConnection();

            _adapter.SelectCommand = finaAllBrandQuery;
            _adapter.Fill(table);

            _db.CloseConnection();
            return table;
        }


        public DataTable FindModelByBrandId(int brandId)
        {
            DataTable modelTable = new DataTable();

            MySqlCommand findModelByBrandIdQuery =
                new MySqlCommand("SELECT * FROM car_model WHERE car_brand_id = @bId", _db.GetConnection());
            findModelByBrandIdQuery.Parameters.Add("@bId", MySqlDbType.Int64).Value = brandId;

            _db.OpenConnection();

            _adapter.SelectCommand = findModelByBrandIdQuery;
            _adapter.Fill(modelTable);

            _db.CloseConnection();
            return modelTable;
        }

        public DataTable FindCarByBrandId(int brandId)
        {
            DataTable carTable = new DataTable();

            MySqlCommand findCarByBrandId = new MySqlCommand(
                "Select car.id AS id, co.first_name AS firstName, co.last_name AS lastName, car.number_car AS numberCar, cb.name AS carBrand, cm.name AS carModel FROM car INNER JOIN car_model cm on car.model_id = cm.id INNER JOIN car_owner co on car.owner_id = co.id INNER JOIN car_brand cb on cm.car_brand_id = cb.id WHERE car.brand_id = @bId;",
                _db.GetConnection());
            findCarByBrandId.Parameters.Add("@bId", MySqlDbType.Int64).Value = brandId;

            _db.OpenConnection();

            _adapter.SelectCommand = findCarByBrandId;
            _adapter.Fill(carTable);

            _db.CloseConnection();
            return carTable;
        }
    }
}