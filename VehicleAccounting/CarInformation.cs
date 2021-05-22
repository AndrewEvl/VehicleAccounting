using System;
using System.Data;
using System.Windows.Forms;

namespace VehicleAccounting
{
    public partial class CarInformation : Form
    {
        private readonly ApplicationRepository _ar = new();

        public CarInformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String carNumberStr = textBox1.Text;
            GetCarInfo(carNumberStr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(label10.Text);
            String carNumber = textBox8.Text;

            _ar.UpdateCar(id, carNumber);

            GetCarInfo(carNumber);
        }


        private void GetCarInfo(String carNumberStr)
        {
            DataTable car = _ar.FindCarByNumber(carNumberStr);
            if (car.Rows.Count == 1)
            {
                String id = Convert.ToString(car.Rows[0]["id"]);
                String brandName = Convert.ToString(car.Rows[0]["carBrand"]);
                String modelName = Convert.ToString(car.Rows[0]["carModel"]);
                String ownerFirstName = Convert.ToString(car.Rows[0]["firstName"]);
                String ownerLastName = Convert.ToString(car.Rows[0]["lastName"]);
                String carNumber = Convert.ToString(car.Rows[0]["numberCar"]);
                String carYear = Convert.ToString(car.Rows[0]["carYear"]);

                label10.Text = id;
                label2.Text = brandName;
                label3.Text = modelName;
                // label4.Text = ownerFirstName + @" " + ownerLastName;
                label4.Text = carYear;
                textBox8.Text = carNumber;
            }
            else
            {
                MessageBox.Show(@"Nothing found by request");
            }
        }
    }
}