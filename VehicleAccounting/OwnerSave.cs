using System;
using System.Data;
using System.Windows.Forms;

namespace VehicleAccounting
{
    public partial class OwnerSave : Form
    {
        
        private readonly ApplicationRepository _ar = new();
        public OwnerSave()
        {
            InitializeComponent();
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
                MessageBox.Show(@"Owner already exist");
            Close();
        }
    }
}