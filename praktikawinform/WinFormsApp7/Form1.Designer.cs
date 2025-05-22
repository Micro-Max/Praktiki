namespace WinFormsApp7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private CheckBox checkBoxDarkTheme;
        private ComboBox comboBoxLanguage;
        private Button buttonSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.checkBoxDarkTheme = new CheckBox();
            this.comboBoxLanguage = new ComboBox();
            this.buttonSave = new Button();
            this.SuspendLayout();
            // 
            // checkBoxDarkTheme
            // 
            this.checkBoxDarkTheme.Location = new Point(20, 20);
            this.checkBoxDarkTheme.Text = "Тёмная тема";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.Location = new Point(20, 60);
            this.comboBoxLanguage.Items.AddRange(new object[] { "Русский", "English" });
            this.comboBoxLanguage.SelectedIndex = 0;
            this.comboBoxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new Point(20, 100);
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.ClientSize = new Size(250, 150);
            this.Controls.Add(this.checkBoxDarkTheme);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.buttonSave);
            this.Text = "Настройки";
            this.ResumeLayout(false);
        }
    }
}
