using System;
using System.Data;
using System.Windows.Forms;

namespace VehicleAccounting
{
    public partial class ModelUpdate : Form
    {
        private readonly ApplicationRepository _ar = new();

        public ModelUpdate()
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
            GetModel();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item selectModel = (Item) comboBox2.SelectedItem;
            textBox1.Text = selectModel.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item selectModel = (Item) comboBox2.SelectedItem;
            String newName = textBox1.Text;
            _ar.UpdateModel(newName, selectModel.Id);
            GetModel();
        }

        private void GetModel()
        {
            comboBox2.Items.Clear();
            Item selectBrand = (Item) comboBox1.SelectedItem;
            DataTable modelTable = _ar.FindModelByBrandId(selectBrand.Id);

            for (int i = 0; i < modelTable.Rows.Count; i++)
            {
                comboBox2.Items.Add(new Item(Convert.ToInt16(modelTable.Rows[i]["id"]),
                    Convert.ToString(modelTable.Rows[i]["name"])));
            }
        }
    }
}