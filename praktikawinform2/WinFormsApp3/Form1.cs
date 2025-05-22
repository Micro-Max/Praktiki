using System;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbFunction.SelectedIndex = 0; 
            txtX.Text = "1";
            txtY.Text = "-1";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtX.Text);
                double y = double.Parse(txtY.Text);

                double fx = GetFx(x);

                double c;

                if (x + y == 0)
                {
                    c = Math.Pow(fx, 3) - Math.Pow(y, 3) * Math.Cos(x);
                }
                else if (x + y > 0)
                {
                    c = Math.Pow(fx * y, 2) - Math.Cos(y);
                }
                else // x + y < 0
                {
                    c = y * Math.Pow(fx, 2) + Math.PI;
                }

                txtResult.Text = c.ToString("F4");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при вычислении: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double GetFx(double x)
        {
            switch (cmbFunction.SelectedItem.ToString())
            {
                case "sh(x)":
                    return Math.Sinh(x);
                case "x^2":
                    return x * x;
                case "e^x":
                    return Math.Exp(x);
                default:
                    throw new Exception("Не выбрана функция f(x)");
            }
        }
    }
}
