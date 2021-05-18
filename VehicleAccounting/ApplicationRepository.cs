using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VehicleAccounting
{
    public class ApplicationRepository
    {
        private readonly DB _db = new();
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

        public DataTable FindCarBeModelIdAndBrandId(int modelId, int brandId)
        {
            DataTable carTable = new DataTable();

            MySqlCommand findCar = new MySqlCommand(
                "Select car.id AS id, co.first_name AS firstName, co.last_name AS lastName, car.number_car AS numberCar, cb.name AS carBrand, cm.name AS carModel FROM car INNER JOIN car_model cm on car.model_id = cm.id INNER JOIN car_owner co on car.owner_id = co.id INNER JOIN car_brand cb on cm.car_brand_id = cb.id WHERE car.brand_id = @bId AND car.model_id = @mId;",
                _db.GetConnection());
            findCar.Parameters.Add("@bId", MySqlDbType.Int64).Value = brandId;
            findCar.Parameters.Add("@mId", MySqlDbType.Int64).Value = modelId;

            _db.OpenConnection();
            _adapter.SelectCommand = findCar;
            _adapter.Fill(carTable);
            _db.CloseConnection();

            return carTable;
        }

        public DataTable FindCarByOwnerLastName(String ownerLastName)
        {
            DataTable carTable = new DataTable();
            MySqlCommand findCar = new MySqlCommand(
                "Select car.id AS id, co.first_name AS firstName, co.last_name AS lastName, car.number_car AS numberCar, cb.name AS carBrand, cm.name AS carModel FROM car INNER JOIN car_model cm on car.model_id = cm.id INNER JOIN car_owner co on car.owner_id = co.id INNER JOIN car_brand cb on cm.car_brand_id = cb.id WHERE co.last_name LIKE @oln;",
                _db.GetConnection());
            findCar.Parameters.Add("@oln", MySqlDbType.VarChar).Value = ownerLastName;

            _db.OpenConnection();
            _adapter.SelectCommand = findCar;
            _adapter.Fill(carTable);
            _db.CloseConnection();

            return carTable;
        }

        public DataTable FindCarByNumber(String carNumber)
        {
            DataTable carTable = new DataTable();

            MySqlCommand findCar = new MySqlCommand(
                "Select car.id AS id, co.first_name AS firstName, co.last_name AS lastName, car.number_car AS numberCar, cb.name AS carBrand, cm.name AS carModel FROM car INNER JOIN car_model cm on car.model_id = cm.id INNER JOIN car_owner co on car.owner_id = co.id INNER JOIN car_brand cb on cm.car_brand_id = cb.id WHERE car.number_car LIKE @cn;",
                _db.GetConnection());
            findCar.Parameters.Add("@cn", MySqlDbType.VarChar).Value = carNumber;

            _db.OpenConnection();
            _adapter.SelectCommand = findCar;
            _adapter.Fill(carTable);
            _db.CloseConnection();

            return carTable;
        }

        public DataTable FindBrandByName(String brandName)
        {
            DataTable brandList = new DataTable();

            MySqlCommand findBrandByNameQuery = new MySqlCommand(
                "SELECT * FROM car_brand WHERE name LIKE @name",
                _db.GetConnection());
            findBrandByNameQuery.Parameters.Add("@name", MySqlDbType.VarChar).Value = brandName;

            _db.OpenConnection();
            _adapter.SelectCommand = findBrandByNameQuery;
            _adapter.Fill(brandList);
            _db.CloseConnection();

            return brandList;
        }

        public void SaveBrand(String brandName)
        {
            _db.OpenConnection();
            MySqlCommand saveBrand = new MySqlCommand(
                "INSERT INTO car_brand (name) VALUES (@name);",
                _db.GetConnection());

            saveBrand.Parameters.Add("@name", MySqlDbType.VarChar).Value = brandName;
            MessageBox.Show(saveBrand.ExecuteNonQuery() == 1 ? @"OK" : @"Some problem");
            _db.CloseConnection();
        }

        public void SaveModel(String modelName, int brandId)
        {
            _db.OpenConnection();
            MySqlCommand saveModel = new MySqlCommand(
                "INSERT INTO car_model (name, car_brand_id) VALUES (@name, @id);",
                _db.GetConnection());

            saveModel.Parameters.Add("@name", MySqlDbType.VarChar).Value = modelName;
            saveModel.Parameters.Add("@id", MySqlDbType.Int64).Value = brandId;

            MessageBox.Show(saveModel.ExecuteNonQuery() == 1 ? @"OK" : @"Some problem");
            _db.CloseConnection();
        }

        public DataTable FindModelByNameAndBrandId(String modelName, int brandId)
        {
            DataTable modelList = new DataTable();

            MySqlCommand findModelByNameAndBrandIdQuery = new MySqlCommand(
                "SELECT * FROM car_model WHERE name LIKE @name AND car_brand_id = @id",
                _db.GetConnection());
            findModelByNameAndBrandIdQuery.Parameters.Add("@name", MySqlDbType.VarChar).Value = modelName;
            findModelByNameAndBrandIdQuery.Parameters.Add("@id", MySqlDbType.Int64).Value = brandId;

            _db.OpenConnection();
            _adapter.SelectCommand = findModelByNameAndBrandIdQuery;
            _adapter.Fill(modelList);
            _db.CloseConnection();

            return modelList;
        }

        public void SaveOwner(String firstName, String lastName, String passportNumber)
        {
            _db.OpenConnection();
            MySqlCommand saveOwnerQuery = new MySqlCommand(
                "INSERT INTO car_owner (first_name, last_name, pasport_number) VALUES (@firstName, @lastName, @passportNumber);",
                _db.GetConnection());

            saveOwnerQuery.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = firstName;
            saveOwnerQuery.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = lastName;
            saveOwnerQuery.Parameters.Add("@passportNumber", MySqlDbType.VarChar).Value = passportNumber;

            MessageBox.Show(saveOwnerQuery.ExecuteNonQuery() == 1 ? @"OK" : @"Some problem");
            _db.CloseConnection();
        }

        public void SaveCar(int brandId, int modelId, int ownerId, int yearCar, float engineVolume)
        {
            _db.OpenConnection();
            MySqlCommand saveCarQuery = new MySqlCommand(
                "INSERT INTO car (brand_id, model_id, owner_id, year_car, engine_volume) VALUES (@brandId, @modelId, @ownerId, @yearCar, @engineVilume);",
                _db.GetConnection());

            saveCarQuery.Parameters.Add("@brandId", MySqlDbType.Int64).Value = brandId;
            saveCarQuery.Parameters.Add("@modelId", MySqlDbType.Int64).Value = modelId;
            saveCarQuery.Parameters.Add("@ownerId", MySqlDbType.Int64).Value = ownerId;
            saveCarQuery.Parameters.Add("@yearCar", MySqlDbType.Int64).Value = yearCar;
            saveCarQuery.Parameters.Add("@engineVolume", MySqlDbType.Float).Value = engineVolume;

            MessageBox.Show(saveCarQuery.ExecuteNonQuery() == 1 ? @"OK" : @"Some problem");
            _db.CloseConnection();
        }

        public DataTable FindOwnerByPassportNumber(String passportNumber)
        {
            DataTable ownerList = new DataTable();

            MySqlCommand findBrandByNameQuery = new MySqlCommand(
                "SELECT * FROM car_owner WHERE car_owner.pasport_number LIKE @passportNumber",
                _db.GetConnection());
            findBrandByNameQuery.Parameters.Add("@passportNumber", MySqlDbType.VarChar).Value = passportNumber;

            _db.OpenConnection();
            _adapter.SelectCommand = findBrandByNameQuery;
            _adapter.Fill(ownerList);
            _db.CloseConnection();

            return ownerList;
        }

        public Boolean ChackValidCarNumber(String carNumber)
        {
            var regex = new Regex("");

            return regex.IsMatch(carNumber);
        }
    }
}