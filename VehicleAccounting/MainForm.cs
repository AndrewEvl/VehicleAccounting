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

        private void RefreshData()
        {
            modelDropDown.Items.Clear();
            brandDropDown.Items.Clear();
            Form1_Load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModelSave modelSaveForm = new ModelSave();
            modelSaveForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BrandSave brandSaveForm = new BrandSave();
            brandSaveForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OwnerSave ownerSaveForm = new OwnerSave();
            ownerSaveForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BrandUpdate brandUpdateForm = new BrandUpdate();
            brandUpdateForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ModelUpdate modelUpdateForm = new ModelUpdate();
            modelUpdateForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CarInformation carInformationForm = new CarInformation();
            carInformationForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OwnerUpdate ownerUpdateForm = new OwnerUpdate();
            ownerUpdateForm.Show();
        }
    }
}