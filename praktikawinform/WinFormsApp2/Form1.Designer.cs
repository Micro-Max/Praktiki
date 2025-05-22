namespace WinFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxName;
        private Button buttonGreet;
        private Label labelGreeting;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            buttonGreet = new Button();
            labelGreeting = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(30, 30);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 23);
            textBoxName.TabIndex = 0;
            // 
            // buttonGreet
            // 
            buttonGreet.Location = new Point(30, 70);
            buttonGreet.Name = "buttonGreet";
            buttonGreet.Size = new Size(106, 30);
            buttonGreet.TabIndex = 1;
            buttonGreet.Text = "Приветствовать";
            buttonGreet.UseVisualStyleBackColor = true;
            buttonGreet.Click += buttonGreet_Click;
            // 
            // labelGreeting
            // 
            labelGreeting.AutoSize = true;
            labelGreeting.Location = new Point(30, 110);
            labelGreeting.Name = "labelGreeting";
            labelGreeting.Size = new Size(0, 15);
            labelGreeting.TabIndex = 2;
            // 
            // Form1
            // 
            ClientSize = new Size(300, 180);
            Controls.Add(textBoxName);
            Controls.Add(buttonGreet);
            Controls.Add(labelGreeting);
            Name = "Form1";
            Text = "Задание 2";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
