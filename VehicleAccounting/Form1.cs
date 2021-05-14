using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VehicleAccounting
{
    public partial class Form1 : Form
    {
        private ApplicationRepository _ar = new ();

        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        private void Form1_Load()
        {
            DataTable allBrandTable = _ar.FindAllBrand();
            
            for (int i = 0; i < allBrandTable.Rows.Count; i++)
            {
                brandDropDown.Items.Add(new Item(Convert.ToInt16(allBrandTable.Rows[i]["id"]),
                    Convert.ToString(allBrandTable.Rows[i]["name"])));

                brandDropDownSave.Items.Add(new Item(Convert.ToInt16(allBrandTable.Rows[i]["id"]),
                    Convert.ToString(allBrandTable.Rows[i]["name"])));
            }
        }

        private void ComboboxIndexChange(object sender, EventArgs e)
        {
            modelDropDown.Items.Clear();
            Item selectBrand = (Item) brandDropDown.SelectedItem;
            
            DataTable modelTable = _ar.FindModelByBrandId(selectBrand.Id);
            DataTable carTable = _ar.FindCarByBrandId(selectBrand.Id);

            for (int i = 0; i < modelTable.Rows.Count; i++)
            {
                modelDropDown.Items.Add(new Item(Convert.ToInt16(modelTable.Rows[i]["id"]),
                    Convert.ToString(modelTable.Rows[i]["name"])));
            }
            

            LoadData(carTable);
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item modelValue = (Item) modelDropDown.SelectedItem;
            Item brandValue = (Item) brandDropDown.SelectedItem;

            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable carTable = new DataTable();
            MySqlCommand findCar = new MySqlCommand(
                "Select car.id AS id, co.first_name AS firstName, co.last_name AS lastName, car.number_car AS numberCar, cb.name AS carBrand, cm.name AS carModel FROM car INNER JOIN car_model cm on car.model_id = cm.id INNER JOIN car_owner co on car.owner_id = co.id INNER JOIN car_brand cb on cm.car_brand_id = cb.id WHERE car.brand_id = @bId AND car.model_id = @mId;",
                db.GetConnection());
            findCar.Parameters.Add("@bId", MySqlDbType.Int64).Value = brandValue.Id;
            findCar.Parameters.Add("@mId", MySqlDbType.Int64).Value = modelValue.Id;

            db.OpenConnection();

            adapter.SelectCommand = findCar;
            adapter.Fill(carTable);

            db.CloseConnection();

            LoadData(carTable);
        }

        private void LoadData(DataTable table)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;
        }

        private void searchLastNameButtonClick(object sender, EventArgs e)
        {
            String searchStr = searchText.Text;

            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable carTable = new DataTable();
            MySqlCommand findCar = new MySqlCommand(
                "Select car.id AS id, co.first_name AS firstName, co.last_name AS lastName, car.number_car AS numberCar, cb.name AS carBrand, cm.name AS carModel FROM car INNER JOIN car_model cm on car.model_id = cm.id INNER JOIN car_owner co on car.owner_id = co.id INNER JOIN car_brand cb on cm.car_brand_id = cb.id WHERE co.last_name LIKE @oln;",
                db.GetConnection());
            findCar.Parameters.Add("@oln", MySqlDbType.VarChar).Value = searchStr;

            db.OpenConnection();

            adapter.SelectCommand = findCar;
            adapter.Fill(carTable);

            db.CloseConnection();

            LoadData(carTable);
        }

        private void SearchCarNumberButtonClick(object sender, EventArgs e)
        {
            String searchStr = seathCarNumberField.Text;

            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable carTable = new DataTable();
            MySqlCommand findCar = new MySqlCommand(
                "Select car.id AS id, co.first_name AS firstName, co.last_name AS lastName, car.number_car AS numberCar, cb.name AS carBrand, cm.name AS carModel FROM car INNER JOIN car_model cm on car.model_id = cm.id INNER JOIN car_owner co on car.owner_id = co.id INNER JOIN car_brand cb on cm.car_brand_id = cb.id WHERE car.number_car LIKE @cn;",
                db.GetConnection());
            findCar.Parameters.Add("@cn", MySqlDbType.VarChar).Value = searchStr;

            db.OpenConnection();

            adapter.SelectCommand = findCar;
            adapter.Fill(carTable);

            db.CloseConnection();

            LoadData(carTable);
        }

        private void saveBrand_Click(object sender, EventArgs e)
        {
            String newBrandName = textBox1.Text;

            DB db = new DB();
            DataTable brandList = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand findBrand = new MySqlCommand(
                "SELECT * FROM car_brand WHERE name LIKE @name",
                db.GetConnection());
            findBrand.Parameters.Add("@name", MySqlDbType.VarChar).Value = newBrandName;

            db.OpenConnection();

            adapter.SelectCommand = findBrand;
            adapter.Fill(brandList);

            if (brandList.Rows.Count == 0)
            {
                MySqlCommand saveBrand = new MySqlCommand(
                    "INSERT INTO car_brand (name) VALUES (@name);",
                    db.GetConnection());

                saveBrand.Parameters.Add("@name", MySqlDbType.VarChar).Value = newBrandName;

                MessageBox.Show(saveBrand.ExecuteNonQuery() == 1 ? @"OK" : @"Some problem");
            }
            else
            {
                MessageBox.Show(@"Such a brand (" + newBrandName + @") already exists");
            }

            db.CloseConnection();
            RefreshData();
        }

        private void RefreshData()
        {
            modelDropDown.Items.Clear();
            brandDropDown.Items.Clear();
            brandDropDownSave.Items.Clear();
            Form1_Load();
        }
    }
}