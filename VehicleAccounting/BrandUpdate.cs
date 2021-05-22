using System;
using System.Data;
using System.Windows.Forms;

namespace VehicleAccounting
{
    public partial class BrandUpdate : Form
    {
        private readonly ApplicationRepository _ar = new();

        public BrandUpdate()
        {
            InitializeComponent();
            Form1_Load();
        }

        private void Form1_Load()
        {
            DataTable allBrandTable = _ar.FindAllBrand();

            for (int i = 0; i < allBrandTable.Rows.Count; i++)
            {
                comboBox1.Items.Add(new Item(Convert.ToInt16(allBrandTable.Rows[i]["id"]),
                    Convert.ToString(allBrandTable.Rows[i]["name"])));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item selectBrand = (Item) comboBox1.SelectedItem;
            DataTable brand = _ar.FindBrandById(selectBrand.Id);

            textBox1.Text = Convert.ToString(brand.Rows[0]["name"]);
            label2.Text = Convert.ToString(brand.Rows[0]["id"]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String newName = textBox1.Text;
            long brandId = Convert.ToInt32(label2.Text);
            _ar.UpdateBrand(brandId, newName);
            comboBox1.Items.Clear();
            Form1_Load();
        }
    }
}