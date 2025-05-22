using System;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            int n = 10;
            int[,] matrix = new int[n, n];

            int top = 0, bottom = n - 1;
            int left = 0, right = n - 1;
            int value = 1;

            while (value <= n * n)
            {
                for (int i = left; i <= right && value <= n * n; i++)
                    matrix[top, i] = value++;
                top++;

                for (int i = top; i <= bottom && value <= n * n; i++)
                    matrix[i, right] = value++;
                right--;

                for (int i = right; i >= left && value <= n * n; i--)
                    matrix[bottom, i] = value++;
                bottom--;

                for (int i = bottom; i >= top && value <= n * n; i--)
                    matrix[i, left] = value++;
                left++;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    sb.Append(matrix[i, j].ToString("D3") + " ");
                sb.AppendLine();
            }

            txtMatrix.Text = sb.ToString();
        }
    }
}
