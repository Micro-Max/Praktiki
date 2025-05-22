namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCtoF_Click(object sender, EventArgs e)
        {
            try
            {
                double celsius = double.Parse(textBoxTemperature.Text);
                double fahrenheit = (celsius * 9 / 5) + 32;
                labelResult.Text = fahrenheit.ToString("F2") + " °F";
            }
            catch (FormatException)
            {
                labelResult.Text = "Неверный ввод!";
            }
        }

        private void buttonFtoC_Click(object sender, EventArgs e)
        {
            try
            {
                double fahrenheit = double.Parse(textBoxTemperature.Text);
                double celsius = (fahrenheit - 32) * 5 / 9;
                labelResult.Text = celsius.ToString("F2") + " °C";
            }
            catch (FormatException)
            {
                labelResult.Text = "Неверный ввод!";
            }
        }
    }
}
