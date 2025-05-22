using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            label1.Text = "Начало работы";
            textBox1.Clear();
        }
    }
}