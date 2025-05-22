namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate(Func<double, double, double> operation)
        {
            try
            {
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                labelResult.Text = operation(a, b).ToString();
            }
            catch (FormatException)
            {
                labelResult.Text = "Ошибка ввода!";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e) => Calculate((a, b) => a + b);
        private void buttonSub_Click(object sender, EventArgs e) => Calculate((a, b) => a - b);
        private void buttonMul_Click(object sender, EventArgs e) => Calculate((a, b) => a * b);
        private void buttonDiv_Click(object sender, EventArgs e) => Calculate((a, b) => b != 0 ? a / b : throw new DivideByZeroException());
    }
}
