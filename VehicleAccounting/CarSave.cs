using System;
using System.Data;
using System.Windows.Forms;

namespace VehicleAccounting
{
    public partial class Form2 : Form
    {
        private readonly ApplicationRepository _ar = new();

        public Form2()
        {
            InitializeComponent();
            Form1_Load();
        }

        private void Form1_Load()
        {
            DataTable allBrandTable = _ar.FindAllBrand();
            DataTable allOwnerTable = _ar.FindAllOwner();

            for (int i = 0; i < allBrandTable.Rows.Count; i++)
            {
                comboBox3.Items.Add(new Item(Convert.ToInt16(allBrandTable.Rows[i]["id"]),
                    Convert.ToString(allBrandTable.Rows[i]["name"])));
            }

            for (int i = 0; i < allOwnerTable.Rows.Count; i++)
            {
                comboBox1.Items.Add(new Item(Convert.ToInt16(allOwnerTable.Rows[i]["id"]),
                    Convert.ToString(allOwnerTable.Rows[i]["last_name"] + " " + allOwnerTable.Rows[i]["first_name"])));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Item selectModel = (Item) comboBox2.SelectedItem;
            Item selectBrand = (Item) comboBox3.SelectedItem;
            Item selectOwner = (Item) comboBox1.SelectedItem;

            String carNumber = textBox8.Text;
            int year = Convert.ToInt32(numericUpDown1.Value);


            int nowYear = DateTime.Now.Year;
            if (year >= 1886 && year <= nowYear)
            {
                String engineVolumeStr = textBox6.Text;
                double engineVolume = Convert.ToDouble(engineVolumeStr);
                _ar.SaveCar(selectBrand.Id, selectModel.Id, selectOwner.Id, year, engineVolume, carNumber);
            }
            else
            {
                MessageBox.Show(@"Wrong year");
            }
            Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            Item selectBrand = (Item) comboBox3.SelectedItem;
            DataTable modelTable = _ar.FindModelByBrandId(selectBrand.Id);

            for (int i = 0; i < modelTable.Rows.Count; i++)
            {
                comboBox2.Items.Add(new Item(Convert.ToInt16(modelTable.Rows[i]["id"]),
                    Convert.ToString(modelTable.Rows[i]["name"])));
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }
}