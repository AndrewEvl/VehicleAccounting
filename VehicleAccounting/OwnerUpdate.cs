using System;
using System.Data;
using System.Windows.Forms;

namespace VehicleAccounting
{
    public partial class OwnerUpdate : Form
    {
        private readonly ApplicationRepository _ar = new();
        public OwnerUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String passportNumberStr = textBox1.Text;

            GetOwner(passportNumberStr);
        }

        private void saveOwner_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(label2.Text);
            String firstName = textBox3.Text;
            String lastName = textBox5.Text;
            String passportNumber = textBox4.Text;
            
            _ar.UpdateOwner(id, firstName, lastName, passportNumber);
            GetOwner(passportNumber);
        }


        private void GetOwner(String passportNumberStr)
        {
            DataTable owner = _ar.FindOwnerByPassportNumber(passportNumberStr);
            if (owner.Rows.Count == 1)
            {
                textBox3.Text = Convert.ToString(owner.Rows[0]["first_name"]);;
                textBox5.Text = Convert.ToString(owner.Rows[0]["last_name"]);;
                textBox4.Text = Convert.ToString(owner.Rows[0]["pasport_number"]);;
                label2.Text = Convert.ToString(owner.Rows[0]["id"]);
            }
            else
            {
                MessageBox.Show(@"Nothing found by request");
            }
        }
    }
}