namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string theme = checkBoxDarkTheme.Checked ? "dark" : "light";
            string language = comboBoxLanguage.SelectedItem?.ToString() ?? "undefined";

            File.WriteAllText("settings.ini", $"theme={theme}\nlanguage={language}");
            MessageBox.Show("Настройки сохранены.");
        }
    }
}
