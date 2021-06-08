using System;
using System.Windows.Forms;

namespace VehicleAccounting
{
    public partial class AutorizationForm : Form
    {

        private readonly ApplicationRepository _ar = new();

        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userName = textBox1.Text;
            String password = textBox2.Text;

            autorizationUser(userName, password);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String userName = textBox1.Text;
            String password = textBox2.Text;
            _ar.SaveNewUser(userName, password);
            autorizationUser(userName, password);
        }

        private void autorizationUser(String userName, String password)
        {

            Boolean isRegister = _ar.findUserByPasswordAndName(userName, password);

            if (isRegister)
            {
                Form1 mainForm = new Form1();
                mainForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Пользователь в системе ненайден");
            }
        }
    }
}
