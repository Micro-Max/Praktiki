namespace WinFormsApp4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxInitialCount;
        private Button buttonIncrement;
        private Button buttonSetInitial;
        private Label labelCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxInitialCount = new TextBox();
            buttonIncrement = new Button();
            buttonSetInitial = new Button();
            labelCount = new Label();
            SuspendLayout();
            // 
            // textBoxInitialCount
            // 
            textBoxInitialCount.Location = new Point(30, 20);
            textBoxInitialCount.Name = "textBoxInitialCount";
            textBoxInitialCount.Size = new Size(100, 23);
            textBoxInitialCount.TabIndex = 0;
            // 
            // buttonIncrement
            // 
            buttonIncrement.Location = new Point(30, 60);
            buttonIncrement.Name = "buttonIncrement";
            buttonIncrement.Size = new Size(75, 23);
            buttonIncrement.TabIndex = 2;
            buttonIncrement.Text = "Добавить";
            buttonIncrement.Click += buttonIncrement_Click;
            // 
            // buttonSetInitial
            // 
            buttonSetInitial.Location = new Point(150, 20);
            buttonSetInitial.Name = "buttonSetInitial";
            buttonSetInitial.Size = new Size(78, 23);
            buttonSetInitial.TabIndex = 1;
            buttonSetInitial.Text = "Установить";
            buttonSetInitial.Click += buttonSetInitial_Click;
            // 
            // labelCount
            // 
            labelCount.Location = new Point(128, 60);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(100, 23);
            labelCount.TabIndex = 3;
            // 
            // Form1
            // 
            ClientSize = new Size(300, 120);
            Controls.Add(textBoxInitialCount);
            Controls.Add(buttonSetInitial);
            Controls.Add(buttonIncrement);
            Controls.Add(labelCount);
            Name = "Form1";
            Text = "Задание 4";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
