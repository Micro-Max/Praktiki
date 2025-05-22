using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            var lengths = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(word => word.Length.ToString());

            txtOutput.Text = string.Join(" ", lengths);
        }
    }
}
