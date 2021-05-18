using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VehicleAccounting
{
    public partial class Form1 : Form
    {
        private readonly ApplicationRepository _ar = new();

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
            Item selectModel = (Item) modelDropDown.SelectedItem;
            Item selectBrand = (Item) brandDropDown.SelectedItem;

            DataTable carTable = _ar.FindCarBeModelIdAndBrandId(selectModel.Id, selectBrand.Id);

            LoadData(carTable);
        }

        private void LoadData(DataTable table)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;
        }

        private void SearchLastNameButtonClick(object sender, EventArgs e)
        {
            String ownerLastName = searchText.Text;
            DataTable carTable = _ar.FindCarByOwnerLastName(ownerLastName);
            LoadData(carTable);
        }

        private void SearchCarNumberButtonClick(object sender, EventArgs e)
        {
            String carNumber = seathCarNumberField.Text;
            DataTable carTable = _ar.FindCarByNumber(carNumber);
            LoadData(carTable);
        }

        private void saveBrand_Click(object sender, EventArgs e)
        {
            String newBrandName = textBox1.Text;
            DataTable brandList = _ar.FindBrandByName(newBrandName);

            if (brandList.Rows.Count == 0)
                _ar.SaveBrand(newBrandName);
            else
                MessageBox.Show(@"Such a brand (" + newBrandName + @") already exists");
            RefreshData();
        }

        private void RefreshData()
        {
            modelDropDown.Items.Clear();
            brandDropDown.Items.Clear();
            brandDropDownSave.Items.Clear();
            Form1_Load();
        }

        private void saveOwner_Click(object sender, EventArgs e)
        {
            String firstName = textBox3.Text;
            String lastName = textBox4.Text;
            String passportNumber = textBox5.Text;

            DataTable ownerList = _ar.FindOwnerByPassportNumber(passportNumber);

            if (ownerList.Rows.Count == 0)
                _ar.SaveOwner(firstName, lastName, passportNumber);
            else
                MessageBox.Show(@"Owner exist");
        }
    }
}