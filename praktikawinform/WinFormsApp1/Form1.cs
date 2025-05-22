namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            textBoxHello.Text = "Hello, World!";
        }
    }
}
