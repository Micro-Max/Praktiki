using System;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();

            double x0 = -2.35;
            double xk = -2.0;
            double dx = 0.05;
            double b = 74.2;

            for (double x = x0; x <= xk + 1e-8; x += dx)
            {
                try
                {
                    double numerator = Math.Log(Math.Pow(Math.Abs(x), 1.25)) + b;
                    double denominator = Math.Pow(x, 2) + 3.82;
                    double y = 0.00084 * numerator / denominator;

                    lstOutput.Items.Add($"x = {x:F2}; y = {y:F6}");
                }
                catch (Exception ex)
                {
                    lstOutput.Items.Add($"x = {x:F2}; Îøèáêà: {ex.Message}");
                }
            }
        }
    }
}
