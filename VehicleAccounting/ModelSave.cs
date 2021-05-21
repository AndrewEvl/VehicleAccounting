using System;
using System.Data;
using System.Windows.Forms;

namespace VehicleAccounting
{
    public partial class ModelSave : Form
    {
        
        private readonly ApplicationRepository _ar = new();
        public ModelSave()
        {
            InitializeComponent();
            Form1_Load();
        }
        
        private void Form1_Load()
        {
            DataTable allBrandTable = _ar.FindAllBrand();

            for (int i = 0; i < allBrandTable.Rows.Count; i++)
            {
                brandDropDownSave.Items.Add(new Item(Convert.ToInt16(allBrandTable.Rows[i]["id"]),
                    Convert.ToString(allBrandTable.Rows[i]["name"])));
            }
        }
        
        private void saveModel_Click(object sender, EventArgs e)
        {
            Item selectItem = (Item) brandDropDownSave.SelectedItem;
            String modelName = textBox2.Text;

            DataTable modelList = _ar.FindModelByNameAndBrandId(modelName, selectItem.Id);

            if (modelList.Rows.Count == 0)
                _ar.SaveModel(modelName, selectItem.Id);
            else
                MessageBox.Show(@"Car model already exists");
            Close();
        }
    }
}