using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtA.Text = "7,5";
            txtB.Text = "1,2";
            txtX.Text = "0,5";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double x = double.Parse(txtX.Text);

                
                double part1 = 4.5 * Math.Pow(a + b, 2) / Math.Pow(a - b, 2);
                double part2 = Math.Sqrt((a + b) * (a - b));
                double part3 = 0.1 * Math.Log(a - b) / Math.Log(a + b) * Math.Exp(Math.Pow(x, 2));

                double result = part1 - part2 + part3;

                txtResult.Text = result.ToString("F4");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при вычислении: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}