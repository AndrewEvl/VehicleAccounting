using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VehicleAccounting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        private void Form1_Load()
        {
            DB               db      = new DB();
            DataTable        table   = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand     command = new MySqlCommand("SELECT * FROM car_brand", db.getConnection());
            
            db.openConnection();
            
            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            db.closeConnection();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                brandDropDown.Items.Add(new Item(Convert.ToInt16(table.Rows[i]["id"]), 
                    Convert.ToString(table.Rows[i]["name"])));
                
                brandDropDownSave.Items.Add(new Item(Convert.ToInt16(table.Rows[i]["id"]), 
                    Convert.ToString(table.Rows[i]["name"])));
            }
        }

        private void ComboboxIndexChange(object sender, EventArgs e)
        {
            modelDropDown.Items.Clear();
            Item tmpComboboxValue = (Item)brandDropDown.SelectedItem;

            DB db = new DB();
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            DataTable modelTable = new DataTable();
            MySqlCommand findModel = new MySqlCommand("SELECT * FROM car_model WHERE car_brand_id = @bId", db.getConnection());
            findModel.Parameters.Add("@bId", MySqlDbType.Int64).Value = tmpComboboxValue.Id;
            
            db.openConnection();
            
            DataTable carTable = new DataTable();
            MySqlCommand findCar = new MySqlCommand("Select car.id AS id, co.first_name AS firstName, co.last_name AS lastName, car.number_car AS numberCar, cb.name AS carBrand, cm.name AS carModel FROM car INNER JOIN car_model cm on car.model_id = cm.id INNER JOIN car_owner co on car.owner_id = co.id INNER JOIN car_brand cb on cm.car_brand_id = cb.id WHERE car.brand_id = @bId;", db.getConnection());
            findCar.Parameters.Add("@bId", MySqlDbType.Int64).Value = tmpComboboxValue.Id;
            
            adapter.SelectCommand = findModel;
            adapter.Fill(modelTable);
            
            adapter.SelectCommand = findCar;
            adapter.Fill(carTable);

            for (int i = 0; i < modelTable.Rows.Count; i++)
            {
                modelDropDown.Items.Add(new Item(Convert.ToInt16(modelTable.Rows[i]["id"]),
                    Convert.ToString(modelTable.Rows[i]["name"])));
            }
            
            db.closeConnection();
            
            LoadData(carTable);
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item modelValue = (Item)modelDropDown.SelectedItem;
            Item brandValue = (Item)brandDropDown.SelectedItem;

            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            DataTable carTable = new DataTable();
            MySqlCommand findCar = new MySqlCommand("Select car.id AS id, co.first_name AS firstName, co.last_name AS lastName, car.number_car AS numberCar, cb.name AS carBrand, cm.name AS carModel FROM car INNER JOIN car_model cm on car.model_id = cm.id INNER JOIN car_owner co on car.owner_id = co.id INNER JOIN car_brand cb on cm.car_brand_id = cb.id WHERE car.brand_id = @bId AND car.model_id = @mId;", db.getConnection());
            findCar.Parameters.Add("@bId", MySqlDbType.Int64).Value = brandValue.Id;
            findCar.Parameters.Add("@mId", MySqlDbType.Int64).Value = modelValue.Id;
            
            db.openConnection();
            
            adapter.SelectCommand = findCar;
            adapter.Fill(carTable);
            
            db.closeConnection();
            
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
                db.getConnection());
            findCar.Parameters.Add("@oln", MySqlDbType.VarChar).Value = searchStr;

            db.openConnection();
            
            adapter.SelectCommand = findCar;
            adapter.Fill(carTable);
            
            db.closeConnection();

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
                db.getConnection());
            findCar.Parameters.Add("@cn", MySqlDbType.VarChar).Value = searchStr;
            
            db.openConnection();

            adapter.SelectCommand = findCar;
            adapter.Fill(carTable);
            
            db.closeConnection();

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
                db.getConnection());
            findBrand.Parameters.Add("@name", MySqlDbType.VarChar).Value = newBrandName;
            
            db.openConnection();
            
            adapter.SelectCommand = findBrand;
            adapter.Fill(brandList);

            if (brandList.Rows.Count == 0)
            {
                MySqlCommand saveBrand = new MySqlCommand(
                    "INSERT INTO car_brand (name) VALUES (@name);",
                    db.getConnection());

                saveBrand.Parameters.Add("@name", MySqlDbType.VarChar).Value = newBrandName;
                
                MessageBox.Show(saveBrand.ExecuteNonQuery() == 1 ? @"OK" : @"Some problem");

            }
            else{  
                MessageBox.Show(@"Such a brand (" + newBrandName +@") already exists");
            }
            
            db.closeConnection();
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