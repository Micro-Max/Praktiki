namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonHello;
        private TextBox textBoxHello;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.buttonHello = new System.Windows.Forms.Button();
            this.textBoxHello = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonHello
            // 
            this.buttonHello.Location = new System.Drawing.Point(30, 30);
            this.buttonHello.Name = "buttonHello";
            this.buttonHello.Size = new System.Drawing.Size(120, 30);
            this.buttonHello.Text = "Показать приветствие";
            this.buttonHello.UseVisualStyleBackColor = true;
            this.buttonHello.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // textBoxHello
            // 
            this.textBoxHello.Location = new System.Drawing.Point(30, 70);
            this.textBoxHello.Name = "textBoxHello";
            this.textBoxHello.Size = new System.Drawing.Size(200, 23);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.buttonHello);
            this.Controls.Add(this.textBoxHello);
            this.Name = "Form1";
            this.Text = "Задание 1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
