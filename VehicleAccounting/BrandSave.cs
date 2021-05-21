using System;
using System.Data;
using System.Windows.Forms;

namespace VehicleAccounting
{
    public partial class BrandSave : Form
    {
        private readonly ApplicationRepository _ar = new();
        public BrandSave()
        {
            InitializeComponent();
        }
        
        private void saveBrand_Click(object sender, EventArgs e)
        {
            String newBrandName = textBox1.Text;
            DataTable brandList = _ar.FindBrandByName(newBrandName);

            if (brandList.Rows.Count == 0)
                _ar.SaveBrand(newBrandName);
            else
                MessageBox.Show(@"Such a brand (" + newBrandName + @") already exists");
            Close();
        }
    }
}