using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        private int[] numbers;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            numbers = new int[50];
            for (int i = 0; i < 50; i++)
                numbers[i] = rand.Next(0, 101); 

            lstArray.Items.Clear();
            foreach (int num in numbers)
                lstArray.Items.Add(num);
        }

        private void btnCountMax_Click(object sender, EventArgs e)
        {
            if (numbers == null || numbers.Length == 0)
            {
                MessageBox.Show("Сначала сгенерируйте массив.");
                return;
            }

            int max = numbers.Max();
            int count = numbers.Count(n => n == max);
            lblResult.Text = $"Максимум: {max}, количество: {count}";
        }
    }
}
