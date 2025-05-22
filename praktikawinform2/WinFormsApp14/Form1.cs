using System;
using System.Windows.Forms;

namespace WinFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxInput.Text, out int n) && n >= 0)
            {
                int result = Fibonacci(n);
                labelResult.Text = $"F({n}) = {result}";
            }
            else
            {
                labelResult.Text = "¬ведите целое неотрицательное число.";
            }
        }
    }
}
