namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
            labelCount.Text = count.ToString();
        }

        private void buttonIncrement_Click(object sender, EventArgs e)
        {
            count++;
            labelCount.Text = count.ToString();
        }

        private void buttonSetInitial_Click(object sender, EventArgs e)
        {
            try
            {
                count = int.Parse(textBoxInitialCount.Text);
                labelCount.Text = count.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("¬ведите корректное число.");
            }
        }
    }
}
